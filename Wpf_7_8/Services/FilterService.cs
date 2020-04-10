using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpf_7_8.Models;
using Wpf_7_8.Services;
namespace WpfApp_todos.Services
{
    class FilterService
    {
        private static  string filter_parm;

        public static string Filter_parm { get => filter_parm; set => filter_parm = value; }

        public BindingList<ToDoMod> FilterBy(string type,BindingList<ToDoMod> list,string parm)
        {
            Filter_parm = parm;
            var FilterList = new List<ToDoMod>(list);
            if(type == "By Category")
            {
                var listBinding = new BindingList<ToDoMod>(FilterList.FindAll(FilterParmCategory));
                return listBinding;
            }
            if (type == "By Priority")
            {
                var listBinding = new BindingList<ToDoMod>(FilterList.FindAll(FilterParmPriority));
                return listBinding;
            }
         
            return null;
        }

        private static bool FilterParmCategory(ToDoMod bk)
        {

            if (bk.Category == Filter_parm)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static bool FilterParmPriority(ToDoMod bk)
        {

            if (bk.Priority == Filter_parm)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       
    }
}
