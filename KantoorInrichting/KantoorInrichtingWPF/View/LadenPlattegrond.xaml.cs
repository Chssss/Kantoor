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
    /// Interaction logic for LadenPlategrond.xaml
    /// </summary>
    public partial class LadenPlategrond : Window
    {
        public LadenPlategrond()
        {
            InitializeComponent();
        }

        private void ButtonTerug_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ButtonZoekenPlattegrondNaam_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonZoekenProjectNaam_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
