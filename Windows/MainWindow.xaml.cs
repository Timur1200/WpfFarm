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
using WpfFarm.Pages.Acts;
using WpfFarm.Pages.Animals;
using WpfFarm.Pages.Korm;

namespace WpfFarm
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Manager.MainFrame = MainFrame;
        }

        void Go(Page p)
        {
            MainFrame.Navigate(p);
        }
        private void AnimalClick(object sender, RoutedEventArgs e)
        {
            Go(new IndexAnimalsPage());
        }

        private void KormClick(object sender, RoutedEventArgs e)
        {
            Go(new IndexKormPage());
        }

        private void ActClick(object sender, RoutedEventArgs e)
        {
            Go(new IndexActPage());
        }
    }
}
