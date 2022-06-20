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
    /// Логика взаимодействия для AddEditAnimalPage.xaml
    /// </summary>
    public partial class AddEditAnimalPage : Page
    {
        public AddEditAnimalPage(Животные животные)
        {
            InitializeComponent();
            if (животные == null)
            {
                _Animal = new Животные();
            }
            else
            {
                _Animal = животные;
            }
            DataContext = _Animal;
        }
        private Животные _Animal { get; set; }
        private void PageLoaded(object sender, RoutedEventArgs e)
        {
            ComboBoxRoles.ItemsSource = EFContext.Context.Вид.ToList();
        }
         
        private void SaveClick(object sender, RoutedEventArgs e)
        {
            _Animal.Сумма = _Animal.Цена * _Animal.Масса;

            if (_Animal.Код == 0) EFContext.Context.Животные.Add(_Animal);
            EFContext.Context.SaveChanges();
            MessageBox.Show("Информация сохранена!");
            Manager.Back();
        }
    }
}
