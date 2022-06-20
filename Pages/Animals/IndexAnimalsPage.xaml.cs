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

namespace WpfFarm.Pages.Animals
{
    /// <summary>
    /// Логика взаимодействия для IndexAnimalsPage.xaml
    /// </summary>
    public partial class IndexAnimalsPage : Page
    {
        public IndexAnimalsPage()
        {
            InitializeComponent();
        }

        private void PageLoaded(object sender, RoutedEventArgs e)
        {
            DGrid.ItemsSource = EFContext.Context.Животные.ToList();
        }

        private void AddClick(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditAnimalPage(null));
        }

        private void EditClick(object sender, RoutedEventArgs e)
        {
            if (DGrid.SelectedItem == null)
            {
                MessageBox.Show("Нужно выбрать запись!");
                return;
            }
            Животные animal = DGrid.SelectedItem as Животные;
            Manager.MainFrame.Navigate(new AddEditAnimalPage(animal));
        }

        private void DelClick(object sender, RoutedEventArgs e)
        {
            if (DGrid.SelectedItem == null)
            {
                MessageBox.Show("Нужно выбрать запись!");
                return;
            }
            Животные animal = DGrid.SelectedItem as Животные;
            try
            {
                EFContext.Context.Животные.Remove(animal);
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
