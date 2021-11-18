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

namespace KantoorInrichtingWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_nieuwePlattegrond_Click(object sender, RoutedEventArgs e)
        {
            NieuwePlattegrond nieuwePlattegrond = new NieuwePlattegrond();
            nieuwePlattegrond.Show();
        }

        private void MenuItem_openPlattegrond_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_opslaan_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_opslaanAls_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_export_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_toevoegen_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_wijzigen_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_lijst_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
