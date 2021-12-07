using KantoorInrichtingWPF.Data;
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

namespace KantoorInrichtingWPF
{
    /// <summary>
    /// Interaction logic for MeubelsLijst.xaml
    /// </summary>
    public partial class MeubelsLijst : Window
    {
       
        public MeubelsLijst()
        {
            InitializeComponent();
            
        }
        private void OnButton_RefreshMeubel_Click(object sender, RoutedEventArgs e)
        {
            
        }
       
        private void OnButton_Zoeken_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void OnButton_Terug_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void OnButton_MeubelToevoegen_Click(object sender, RoutedEventArgs e)
        {
            MeubelsToevoegen meubelsToevoegen = new MeubelsToevoegen();
            meubelsToevoegen.Show();
        }

        private void OnButton_ZoekenCategorie_Click(object sender, RoutedEventArgs e)
        {
            
           
        }

        private void OnButton_VerwijderMeubel_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
