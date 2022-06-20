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
    /// Логика взаимодействия для AddEditKormPage.xaml
    /// </summary>
    public partial class AddEditKormPage : Page
    {
        public AddEditKormPage(Корм корм)
        {
            InitializeComponent();
            if (корм == null)
            {
                _Korm = new Корм();
            }
            else
            {
                _Korm = корм;
            }
            DataContext = _Korm;
        }
        private Корм _Korm { get; set; }

        private void SaveClick(object sender, RoutedEventArgs e)
        {
            if (_Korm.Код == 0) EFContext.Context.Корм.Add(_Korm);
            EFContext.Context.SaveChanges();
            MessageBox.Show("Информация сохранена!");
            Manager.Back();
        }
    }
}
