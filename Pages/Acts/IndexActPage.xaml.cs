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

namespace WpfFarm.Pages.Acts
{
    /// <summary>
    /// Логика взаимодействия для IndexActPage.xaml
    /// </summary>
    public partial class IndexActPage : Page
    {
        public IndexActPage()
        {
            InitializeComponent();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DGrid.ItemsSource = EFContext.Context.АктСписанияКормов.ToList();
        }
        private void AddClick(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditActPage());
        }

       

        

       
    }
}
