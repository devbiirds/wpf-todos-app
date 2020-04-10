using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Globalization;
using System.ComponentModel;
using Wpf_7_8.Services;
using Wpf_7_8.Models;
using WpfApp_todos.Services;

namespace Wpf_7_8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 
   
    public partial class MainWindow : Window
    {
        public string ViewModel { get; set; }
        public List<string> CategoryL { get; set; }
        public List<string> PriorityL { get; set; }
        private readonly string Path = $"{Environment.CurrentDirectory}\\toDoMod.json";
        private readonly string FilterPath = $"{Environment.CurrentDirectory}\\filter.json";
        private readonly string SearchPath = $"{Environment.CurrentDirectory}\\search.json";
        public static BindingList<ToDoMod> _toDoData;
        private SaveToOrReadFrom _saveToOrReadFrom;
        private SaveToOrReadFrom _filterIOService;
        private SaveToOrReadFrom _searchIOService;
        private FilterService _filterService;
        private SearchService _searchService;
    
        public MainWindow()
        {
            CategoryL = new List<string>();
            CategoryL.Add("Личное");
            CategoryL.Add("Работа");
            CategoryL.Add("Учеба");
            CategoryL.Add("Дом");
         

            PriorityL = new List<string>();
            PriorityL.Add("Высокий");
            PriorityL.Add("Средний");
            PriorityL.Add("Низкий");


            


            InitializeComponent();

          
            Category.ItemsSource = CategoryL;
            Priority.ItemsSource = PriorityL;
        }

        public void ShowViewModel()
        {
            MessageBox.Show(ViewModel);

        }
        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            App.LanguageChanged += LanguageChanged;

            CultureInfo currLang = App.Language;

            foreach (var lang in App.Languages)
            {
                MenuItem menuLang = new MenuItem();
                menuLang.Header = lang.DisplayName;
                menuLang.Tag = lang;
                menuLang.IsChecked = lang.Equals(currLang);
                menuLang.Click += ChangeLanguageClick;
                menuLanguage.Items.Add(menuLang);
            }

            _saveToOrReadFrom = new SaveToOrReadFrom(Path);
            try
            {
                _toDoData = _saveToOrReadFrom.ReadFrom();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }
            toDoL.ItemsSource = _toDoData;
            _toDoData.ListChanged += _toDoData_ListChanged;
        }
        public static void AddTask(ToDoMod data) {
            _toDoData.Add(data);
            }
        private void _toDoData_ListChanged(object sender, ListChangedEventArgs e)
        {
            if(e.ListChangedType == ListChangedType.ItemAdded || e.ListChangedType == ListChangedType.ItemDeleted || e.ListChangedType == ListChangedType.ItemChanged)
            {
                try
                {
                    _saveToOrReadFrom.Save(sender);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Close();
                }
            }
        }
        private void Click_Ru(object sender, RoutedEventArgs e)
        {
            MenuItem mi = sender as MenuItem;
            CultureInfo lang = mi.Tag as CultureInfo;
            if (lang != null)
            {
                App.Language = lang;
            }

        }


        private void Click_En(object sender, RoutedEventArgs e)
        {
            MenuItem mi = sender as MenuItem;
            CultureInfo lang = mi.Tag as CultureInfo;
            if (lang != null)
            {
                App.Language = lang;
            }
        }

        private void Click_Add(object sender, RoutedEventArgs e)
        {
            CreateTask createTask = new CreateTask();
            createTask.Show();
        }

        private void MenuItem_Click_ByCategory(object sender, RoutedEventArgs e)
        {
            _saveToOrReadFrom = new SaveToOrReadFrom(Path);
            _filterIOService = new SaveToOrReadFrom(FilterPath);
            _filterService = new FilterService();
            MenuItem menuItem = (MenuItem)sender;//определение по какой категории будет фильтр
            try
            {
                toDoL.ItemsSource = _filterService.FilterBy("By Category",_toDoData, menuItem.Header.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
                throw;
            }

        }
        private void MenuItem_Click_ByPriority(object sender, RoutedEventArgs e)
        {
            _saveToOrReadFrom = new SaveToOrReadFrom(Path);
            _filterIOService = new SaveToOrReadFrom(FilterPath);
            _filterService = new FilterService();
            MenuItem menuItem = (MenuItem)sender;//определение по какой категории будет фильтр
            try
            {
                toDoL.ItemsSource = _filterService.FilterBy("By Priority", _toDoData, menuItem.Header.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
                throw;
            }

        }
       
      
        private void LanguageChanged(object sender, EventArgs e)
        {
            CultureInfo currLang = App.Language;

            //Отмечаем нужный пункт смены языка как выбранный язык
            foreach (MenuItem i in menuLanguage.Items)
            {
                CultureInfo ci = i.Tag as CultureInfo;
                i.IsChecked = ci != null && ci.Equals(currLang);
            }
        }

        private void ChangeLanguageClick(object sender, EventArgs e)
        {
            MenuItem mi = sender as MenuItem;
            if (mi != null)
            {
                CultureInfo lang = mi.Tag as CultureInfo;
                if (lang != null)
                {
                    App.Language = lang;
                    
                }
            }

        }
        private void Search(object sender, RoutedEventArgs e)
        {
            _saveToOrReadFrom = new SaveToOrReadFrom(SearchPath);
            _searchIOService = new SaveToOrReadFrom(FilterPath);
            _searchService = new SearchService();
            try
            {
                if(SearchInput.Text != null)
                toDoL.ItemsSource = _searchService.SearchItems(_toDoData, SearchInput.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
                throw;
            }
        }
        private void ResetList(object sender, RoutedEventArgs e)
        {
            _saveToOrReadFrom = new SaveToOrReadFrom(Path);
            toDoL.ItemsSource = _toDoData;
            _toDoData.ListChanged += _toDoData_ListChanged;
        }
    }
}
