
using KantoorInrichtingWPF.Data;
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
        private string _zoekbalk;
        public MainWindow()
        {
            InitializeComponent();
            if (Database.isGevuld==false)
            {
                Database.FillDatabase();
            }
           
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

        private void OnButton_ZoekenMeubelNaam_Click(object sender, RoutedEventArgs e)
        {
            _zoekbalk = TBMeubels.Text;
            //funcitie uit data die Dictionary<int,list<string>> meubels terug geeft die overeen komen met de text in de zoek balk

            Dictionary<int, List<string>> outputQuerry = Database.ZoekenDatabase(_zoekbalk); 
            
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

        private void OnButton_RefreshMeubel_Click(object sender, RoutedEventArgs e)
        {
            AddDataToColumns();
        }

        private void OnButton_ZoekenMeubelCategorie_Click(object sender, RoutedEventArgs e)
        {
            _zoekbalk = TBMeubels.Text;
            //funcitie uit data die Dictionary<int,list<string>> meubels terug geeft die overeen komen met de text in de zoek balk

            Dictionary<int, List<string>> outputQuerry = Database.ZoekenDatabseCategorie(_zoekbalk);

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
    }
}
