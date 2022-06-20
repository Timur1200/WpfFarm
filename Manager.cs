using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfFarm
{
    internal class Manager
    {
        public static Frame MainFrame { get; set; }

        public static void Back()
        {
            if (MainFrame.NavigationService.CanGoBack) MainFrame.NavigationService.GoBack();
        }
    }
}
