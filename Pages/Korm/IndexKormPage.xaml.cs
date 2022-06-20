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

namespace WpfFarm.Pages.Korm
{
    /// <summary>
    /// Логика взаимодействия для IndexKormPage.xaml
    /// </summary>
    public partial class IndexKormPage : Page
    {
        public IndexKormPage()
        {
            InitializeComponent();
        }
        private void PageLoaded(object sender, RoutedEventArgs e)
        {
            DGrid.ItemsSource = EFContext.Context.Корм.ToList();
        }
        private void AddClick(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditKormPage(null));
        }

        private void EditClick(object sender, RoutedEventArgs e)
        {
            if (DGrid.SelectedItem == null)
            {
                MessageBox.Show("Нужно выбрать запись!");
                return;
            }
            Корм korm = DGrid.SelectedItem as Корм;
            Manager.MainFrame.Navigate(new AddEditKormPage(korm));
        }

        private void DelClick(object sender, RoutedEventArgs e)
        {
            if (DGrid.SelectedItem == null)
            {
                MessageBox.Show("Нужно выбрать запись!");
                return;
            }
            Корм корм = DGrid.SelectedItem as Корм;
            try
            {
                EFContext.Context.Корм.Remove(корм);
                EFContext.Context.SaveChanges();
                PageLoaded(null, null);
            }
            catch
            {
                MessageBox.Show("Данную запись нельзя удалить");
            }
        }

       
    }
}
