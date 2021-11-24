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

        private void OnMenuItem_nieuwePlattegrond_Click(object sender, RoutedEventArgs e)
        {
            NieuwePlattegrond nieuwePlattegrond = new NieuwePlattegrond();
            nieuwePlattegrond.Show();
            nieuwePlattegrond.ButtonAanmaken.Click += OnButtonAanmaken_Click;  
        }

        private void OnButtonAanmaken_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void OnMenuItem_openPlattegrond_Click(object sender, RoutedEventArgs e)
        {

        }

        private void OnMenuItem_opslaan_Click(object sender, RoutedEventArgs e)
        {

        }

        private void OnMenuItem_opslaanAls_Click(object sender, RoutedEventArgs e)
        {

        }

        private void OnMenuItem_export_Click(object sender, RoutedEventArgs e)
        {

        }

        private void OnMenuItem_toevoegen_Click(object sender, RoutedEventArgs e)
        {
            MeubelsToevoegen meubelsToevoegen = new MeubelsToevoegen();
            meubelsToevoegen.Show();
        }

        private void OnMenuItem_wijzigen_Click(object sender, RoutedEventArgs e)
        {

        }

        private void OnMenuItem_lijst_Click(object sender, RoutedEventArgs e)
        {
            MeubelsLijst meubelsLijst = new MeubelsLijst();
            meubelsLijst.Show();
        }

        private void OnButton_Totaalprijs_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
