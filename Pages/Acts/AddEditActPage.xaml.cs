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
    /// Логика взаимодействия для AddEditActPage.xaml
    /// </summary>
    public partial class AddEditActPage : Page
    {
        public AddEditActPage()
        {
            InitializeComponent();
            _Act = new АктСписанияКормов();
            _Act.Дата = DateTime.Now;
            DataContext = _Act;
        }
        АктСписанияКормов _Act { get; set; }
        private void PageLoaded(object sender, RoutedEventArgs e)
        {
            ComboBoxAnimal.ItemsSource = EFContext.Context.Животные.ToList();
            ComboBoxKorm.ItemsSource = EFContext.Context.Корм.ToList();

        }
        private void SaveClick(object sender, RoutedEventArgs e)
        {
            if (_Act.Код == 0) EFContext.Context.АктСписанияКормов.Add(_Act);
            try
            {
                EFContext.Context.SaveChanges();
                MessageBox.Show("Информация сохранена!");
                Manager.Back();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

       
    }
}
