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
        private bool _stoel;
        private bool _tafel;
        private bool _lamp;
        private bool _kast;
        private bool _plant;
        private bool _apparaten;
        private bool _deur;
        private bool _raam;
        private bool _tapijt;
        public MeubelsToevoegen()
        {
            _tafel = false;
            _stoel = false;
            _lamp = false;
            _kast = false;
            _plant = false;
            _apparaten = false;
            _deur = false;
            _raam = false;
            _tapijt = false;
            InitializeComponent();
           
        }

        private void OnButton_Annuleren_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void OnButton_Toevoegen_Click(object sender, RoutedEventArgs e)
        {
            //roep funcitie voor toevoegen meubel aan
            this.Close();
        }

        private void OnRButton_Tafel_Checked(object sender, RoutedEventArgs e)
        {
            MakeFalse();
            _tafel = true;
            FillLabel();
           
        }

        private void OnRButton_Stoel_Checked(object sender, RoutedEventArgs e)
        {
            MakeFalse();
            _stoel = true;
            FillLabel();
            }

        private void OnRButton_Lamp_Checked(object sender, RoutedEventArgs e)
        {
            MakeFalse();
            _lamp = true;
            FillLabel();
           }

        private void OnRButton_Plant_Checked(object sender, RoutedEventArgs e)
        {
            MakeFalse();
            _plant = true;
            FillLabel();
           }

        private void OnRButton_Kast_Checked(object sender, RoutedEventArgs e)
        {
            MakeFalse();
            _kast = true;
            FillLabel();
            }

        private void OnRButton_Apparaat_Checked(object sender, RoutedEventArgs e)
        {
            MakeFalse();
            _apparaten = true;
            FillLabel();
             }

        private void OnRButton_Deur_Checked(object sender, RoutedEventArgs e)
        {
            MakeFalse();
            _deur = true;
            FillLabel();
        }

        private void OnRButton_Raam_Checked(object sender, RoutedEventArgs e)
        {
            MakeFalse();
            _raam = true;
            FillLabel();
         }

        private void OnRButton_Tapijt_Checked(object sender, RoutedEventArgs e)
        {
            MakeFalse();
            _tapijt = true;
            FillLabel();
                }
        private void MakeFalse() 
        {
            _tafel = false;
            _stoel = false;
            _lamp = false;
            _kast = false;
            _plant = false;
            _apparaten = false;
            _deur = false;
            _raam = false;
            _tapijt = false;
        }
        private void FillLabel() 
        {
            LabelTafelStoel.Content = "For testing \n Stoel: " + _stoel + "\n Tafel: " + _tafel + "\n Lamp: " + _lamp + "\n Kast: " + _kast +
            "\n Plant: " + _plant + "\n Apparaat: " + _apparaten + "\n Deur: " + _deur + "\n Raam: " + _raam + "\n Tapijt: " + _tapijt;

        }
    }
}
