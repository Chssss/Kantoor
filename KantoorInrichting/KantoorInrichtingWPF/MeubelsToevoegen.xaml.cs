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
    /// Interaction logic for MeubelsToevoegen.xaml
    /// </summary>
    public partial class MeubelsToevoegen : Window
    {
        public MeubelsToevoegen()
        {
            InitializeComponent();
        }

        private void OnButton_Annuleren_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void OnButton_Toevoegen_Click(object sender, RoutedEventArgs e)
        {

            this.Close();
        }
    }
}
