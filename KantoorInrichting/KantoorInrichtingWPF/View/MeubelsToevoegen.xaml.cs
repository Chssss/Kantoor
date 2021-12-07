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
        private bool _stoel;
        private bool _tafel;
        private bool _lamp;
        private bool _kast;
        private bool _plant;
        private bool _apparaten;
        private bool _deur;
        private bool _raam;
        private bool _tapijt;

        private string _naam;
        private string _prijs;
        private string _lengte;
        private string _breedte;
        private string _categorie;
        private string _tag;
        private string _image;
        private string _hoogte;
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
            _naam = TBNaam.Text;
            _prijs = TBPrijs.Text;
            _lengte = TBLengte.Text;
            _breedte = TBBreedte.Text;
            _categorie = TBCategorie.Text;
            _hoogte = TBHoogte.Text;
            _tag = GetTag();
            _image = GetImage();
            //roep funcitie voor toevoegen meubel aan
            Meubel_Database.ToevoegenAanDatabase(_naam, _prijs, _lengte, _breedte, _categorie, _tag, _image,_hoogte);
            this.Close();
        }
       
        private string GetImage() 
        {
            string image = "";
            if (_tag.Equals("stoel"))
            {
                image = "🦼";
            }
            if (_tag.Equals("tafel"))
            {
                image = "|¯¯|";
            }
            if (_tag.Equals("lamp"))
            {
                image = "💡";
            }
            if (_tag.Equals("kast"))
            {
                image = "🗄";
            }
            if (_tag.Equals("plant"))
            {
                image = "🌲";
            }
            if (_tag.Equals("apparaten"))
            {
                image = "🖥";
            }
            if (_tag.Equals("deur"))
            {
                image = "🚪";
            }
            if (_tag.Equals("raam"))
            {
                image = "⬜";
            }
            if (_tag.Equals("tapijt"))
            {
                image = "🔴";
            }
            return image;
        }
        private string GetTag() 
        {
            string tag="";
            if (_stoel==true)
            {
                tag= "stoel";
            }
            if (_tafel == true)
            {
                tag = "tafel";
            }
            if (_kast == true)
            {
                tag = "kast";
            }
            if (_plant == true)
            {
                tag = "plant";
            }
            if (_deur== true)
            {
                tag = "deur";
            }
            if (_raam == true)
            {
                tag = "raam";
            }
            if (_tapijt == true)
            {
                tag = "tapijt";
            }
            if (_lamp == true)
            {
                tag = "lamp";
            }
            if (_apparaten == true)
            {
                tag = "apparaten";
            }
            return tag;
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
