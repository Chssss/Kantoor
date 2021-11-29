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
        private string _zoekbalk;
        public MeubelsLijst()
        {
            InitializeComponent();
            AddDataToColumns();
        }
        private void OnButton_RefreshMeubel_Click(object sender, RoutedEventArgs e)
        {
            AddDataToColumns();
        }
        private void AddDataToColumns()
        {
            var outputQuerry = Database.GetDatabase();
            List<Meubel> listMeubels = new List<Meubel>();
            foreach (var item in outputQuerry)
            {
                
                var afbeelding = item.Value[0];
                var naam = item.Value[1];
                var prijs = System.Convert.ToDecimal(item.Value[2]);
                var lengte = System.Convert.ToDecimal(item.Value[3]);
                var breedte = System.Convert.ToDecimal(item.Value[4]);
                var tag = item.Value[5];
                var categorie = item.Value[6];
                Meubel meubel = new Meubel(afbeelding, naam, prijs, lengte, breedte, tag, categorie);

                listMeubels.Add(meubel);


            }
            DGMeubels.ItemsSource = listMeubels;
        }
        private void OnButton_Zoeken_Click(object sender, RoutedEventArgs e)
        {
            _zoekbalk = TBZoekbar.Text;
            //funcitie uit data die Dictionary<int,list<string>> meubels terug geeft die overeen komen met de text in de zoek balk

            Dictionary<int, List<string>> outputQuerry = Database.ZoekenDatabse(_zoekbalk);

            List<Meubel> listMeubels = new List<Meubel>();
            foreach (var item in outputQuerry)
            {

                var afbeelding = item.Value[0];
                var naam = item.Value[1];
                var prijs = System.Convert.ToDecimal(item.Value[2]);
                var lengte = System.Convert.ToDecimal(item.Value[3]);
                var breedte = System.Convert.ToDecimal(item.Value[4]);
                var tag = item.Value[5];
                var categorie = item.Value[6];
                Meubel meubel = new Meubel(afbeelding, naam, prijs, lengte, breedte, tag, categorie);

                listMeubels.Add(meubel);


            }
            DGMeubels.ItemsSource = listMeubels;
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
    }
}
