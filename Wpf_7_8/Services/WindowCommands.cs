using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Wpf_7_8.Services
{
    public class WindowCommands
    {
        static WindowCommands()
        {
            Search = new RoutedCommand("Search", typeof(MainWindow));
            Reset = new RoutedCommand("Reset", typeof(MainWindow));
            Filter = new RoutedCommand("Filter", typeof(MainWindow));
        }
        public static RoutedCommand Reset { get; set; }
        public static RoutedCommand Search { get; set; }
        public static RoutedCommand Filter { get; set; }
    }
}
