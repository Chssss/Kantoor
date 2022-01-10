using KantoorInrichtingWPF.Model;
using KantoorInrichtingWPF.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace KantoorInrichtingWPF.View
{
    /// <summary>
    /// Interaction logic for OverzichtGebruikteMeubels.xaml
    /// </summary>
    public partial class OverzichtGebruikteMeubels : Window
    {
        private string _plattegrondnaam;

        public string Plattegrondnaam { get { return _plattegrondnaam; } set { _plattegrondnaam = value; } }
        public OverzichtGebruikteMeubels()
        {
            InitializeComponent();
           
        }

        private void ButtonTerug_Click(object sender, RoutedEventArgs e)
        {
            
            this.Close();
        }

        private void OnBestellenClick(object sender, RoutedEventArgs e)
        {
            MessageBoxResult dialogResult = MessageBox.Show("Weet je zeker dat je wilt bestellen?", "Bestellen", MessageBoxButton.YesNo);
            if (dialogResult == MessageBoxResult.Yes)
            {
                PlattegrondViewModel plattegrondViewModel = new PlattegrondViewModel();
                List<GebruikteMeubels> LijstGebruikteMeubels = (List<GebruikteMeubels>)DGGebruikteMeubels.ItemsSource;
                plattegrondViewModel.MakeBestelling(LijstGebruikteMeubels,Plattegrondnaam);
                MessageBox.Show("Bestelling is gemaakt", "Bestellen");
            }
            else if (dialogResult == MessageBoxResult.No)
            {

            }
            

        }

    }
}
