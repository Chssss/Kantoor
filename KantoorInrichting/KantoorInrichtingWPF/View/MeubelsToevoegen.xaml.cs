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
      
        
        
        private void OnRButton_Tafel_Checked(object sender, RoutedEventArgs e)
        {
          
          
           
        }

        private void OnRButton_Stoel_Checked(object sender, RoutedEventArgs e)
        {
           
           
            }

        private void OnRButton_Lamp_Checked(object sender, RoutedEventArgs e)
        {
            
           
           }

        private void OnRButton_Plant_Checked(object sender, RoutedEventArgs e)
        {
            
           }

        private void OnRButton_Kast_Checked(object sender, RoutedEventArgs e)
        {
           
          
            }

        private void OnRButton_Apparaat_Checked(object sender, RoutedEventArgs e)
        {
           
       
             }

        private void OnRButton_Deur_Checked(object sender, RoutedEventArgs e)
        {
            
            
        }

        private void OnRButton_Raam_Checked(object sender, RoutedEventArgs e)
        {
            
            
         }

        private void OnRButton_Tapijt_Checked(object sender, RoutedEventArgs e)
        {
          
           
           
         }
       
       
    }
}
