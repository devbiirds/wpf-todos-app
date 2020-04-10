using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Shapes;
using Wpf_7_8.Models;

namespace Wpf_7_8.Services
{
    /// <summary>
    /// Логика взаимодействия для CreateTask.xaml
    /// </summary>
    public partial class CreateTask : Window
    {
        private readonly string Path = $"{Environment.CurrentDirectory}\\toDoMod.json";
        private SaveToOrReadFrom _saveToOrReadFrom;

        private string SelectedCategory;
        private string SelectedPriority;
        private string SelectedEndDate;
        private string SelectedDescription;
        private string SelectedTask;
        private object _toDoData;

        public List<string> CategoryL { get; set; }
        public List<string> PriorityL { get; set; }
        public CreateTask()
        {
            CategoryL = new List<string>();
            CategoryL.Add("Личное");
            CategoryL.Add("Работа");
            CategoryL.Add("Учеба");
            CategoryL.Add("Дом");


            PriorityL = new List<string>();
            PriorityL.Add("Высокий");
            PriorityL.Add("Средний");
            PriorityL.Add("низкий");






            InitializeComponent();
            Category.ItemsSource = CategoryL;
            Priority.ItemsSource = PriorityL;
        }

      
        private void Click_ToDo(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            
                
        }

        private void Сlick_AddNewTask(object sender, RoutedEventArgs e)
        {
            ToDoMod data = new ToDoMod(SelectedCategory,SelectedPriority,SelectedEndDate,SelectedDescription,SelectedTask,false);
            MainWindow.AddTask(data);
        }

        private void Category_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            SelectedCategory = comboBox.SelectedItem.ToString();
        }

        private void Priority_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            SelectedPriority = comboBox.SelectedItem.ToString();
        }

        private void EndDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime? selectedDate = EndDate.SelectedDate;
            SelectedEndDate = selectedDate.ToString();
            
        }

        private void Name_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            SelectedTask = textBox.Text;
        }

        private void Description_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            SelectedDescription = textBox.Text;
        }
    }
}
