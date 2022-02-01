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
    /// Interaction logic for NieuwePlattegrond.xaml
    /// </summary>
    public partial class NieuwePlattegrond : Window
    {
        public NieuwePlattegrond()
        {
            InitializeComponent();
        }

        private void OnButton_Aanmaken_Click(object sender, RoutedEventArgs e)
        {
            if ((TBProject.Text is null) && (TBNaam.Text is null) && TBLengte.Text is null && TBBreedte.Text is null && TBHoogte.Text is null)
            {
                MessageBox.Show("Vul alle velden in om een plattegrond te kunnen toevoegen");
            }
            else
            {
                if (!decimal.TryParse(TBLengte.Text, out decimal __Lengte) || !decimal.TryParse(TBBreedte.Text, out decimal __Breedte) || !decimal.TryParse(TBHoogte.Text, out decimal __Hoogte))
                {
                    MessageBox.Show("Lengte, Breedte en Hoogte moet een getal zijn");
                }
                else
                {
                    MainWindow plattegrondEditor = new MainWindow();
                    plattegrondEditor.ProjectNaam = TBProject.Text;
                    plattegrondEditor.PlattegrondNaam = TBNaam.Text;

                    plattegrondEditor.Lengte = TBLengte.Text;
                    plattegrondEditor.Breedte = TBBreedte.Text;
                    plattegrondEditor.Hoogte = TBHoogte.Text;
                    plattegrondEditor.LabelLengte.Content = $"Lengte:{TBLengte.Text}";
                    plattegrondEditor.LabelBreedte.Content = $"Breedte:{TBBreedte.Text}";
                    plattegrondEditor.LabelHoogte.Content = $"Hoogte:{TBHoogte.Text}";
                    plattegrondEditor.Show();
                    this.Close();
                    MessageBox.Show("Plattegrond is aangemaakt");

                }
            }
            
        }

        private void OnButton_Annuleren_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
