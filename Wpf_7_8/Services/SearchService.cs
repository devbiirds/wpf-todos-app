using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpf_7_8.Models;

namespace Wpf_7_8.Services
{
    class SearchService
    {
        private static string search_parm;
        public static string Search_parm { get => search_parm; set => search_parm = value; }

        public BindingList<ToDoMod> SearchItems(BindingList<ToDoMod> list, string parm)
        {
            Search_parm = parm;
            var SearchList = new List<ToDoMod>(list);
            var listBinding = new BindingList<ToDoMod>(SearchList.FindAll(SearchPredicate));
            return listBinding;
        }
        private static bool SearchPredicate(ToDoMod bk)
        {
      
            if (bk.Name.Contains(Search_parm) || bk.Description.Contains(Search_parm))
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
