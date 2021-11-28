
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
           
            AddDataToColumns();
            
           
        }

        private void AddDataToColumns()
        {
            #region nepdatabase
            Dictionary<int, List<string>> outputQuerry = new Dictionary<int, List<string>>();
            List<string> list1 = new List<string>();
            List<string> list2 = new List<string>();
            List<string> list3 = new List<string>();
            List<string> list4 = new List<string>();
            List<string> list5 = new List<string>();
            List<string> list6 = new List<string>();
            List<string> list7 = new List<string>();
            List<string> list8 = new List<string>();
            List<string> list9 = new List<string>();
            //list.Add(@"afbeeldingen\stoel.jpg");//0
            /*
           1 tafel |¯¯|
           2 stoel 🦽 
           3 lamp 💡
           4 kast 🗄
           5 plant 🌲
           6 apparaten 🖥
           7 deur 🚪
           8 raam ⬜
           9 tapijt 🔴
            */
            list1.Add("🦽");
            list1.Add("naam");//1
            list1.Add("5,8");//2
            list1.Add("10,6");//3
            list1.Add("8,9");//4
            list1.Add("stoel");//5
            list1.Add("categorie");//6
            outputQuerry.Add(0, list1);
            list2.Add("|¯¯|");
            list2.Add("naam");//1
            list2.Add("5,8");//2
            list2.Add("10,6");//3
            list2.Add("8,9");//4
            list2.Add("tafel");//5
            list2.Add("categorie");//6
            outputQuerry.Add(1, list2);
            list3.Add("💡");
            list3.Add("naam");//1
            list3.Add("5,8");//2
            list3.Add("10,6");//3
            list3.Add("8,9");//4
            list3.Add("lamp");//5
            list3.Add("categorie");//6
            outputQuerry.Add(2, list3);
            list4.Add("🗄");
            list4.Add("naam");//1
            list4.Add("5,8");//2
            list4.Add("10,6");//3
            list4.Add("8,9");//4
            list4.Add("kast");//5
            list4.Add("categorie");//6
            outputQuerry.Add(3, list4);
            list5.Add("🌲");
            list5.Add("naam");//1
            list5.Add("5,8");//2
            list5.Add("10,6");//3
            list5.Add("8,9");//4
            list5.Add("plant");//5
            list5.Add("categorie");//6
            outputQuerry.Add(4, list5);
            list6.Add("🖥");
            list6.Add("naam");//1
            list6.Add("5,8");//2
            list6.Add("10,6");//3
            list6.Add("8,9");//4
            list6.Add("apparaten");//5
            list6.Add("categorie");//6
            outputQuerry.Add(5, list6);
            list7.Add("🚪");
            list7.Add("naam");//1
            list7.Add("5,8");//2
            list7.Add("10,6");//3
            list7.Add("8,9");//4
            list7.Add("deur");//5
            list7.Add("categorie");//6
            outputQuerry.Add(6, list7);
            list8.Add("⬜");
            list8.Add("naam");//1
            list8.Add("5,8");//2
            list8.Add("10,6");//3
            list8.Add("8,9");//4
            list8.Add("raam");//5
            list8.Add("categorie");//6
            outputQuerry.Add(7, list8);
            list9.Add("🔴");
            list9.Add("naam");//1
            list9.Add("5,8");//2
            list9.Add("10,6");//3
            list9.Add("8,9");//4
            list9.Add("tapijt");//5
            list9.Add("categorie");//6
            outputQuerry.Add(8, list9);
            #endregion
            List<Meubel> listMeubels = new List<Meubel>();
            foreach (var item in outputQuerry)
            {
                /* LabelTest.Content= item.Value[0]+"," + item.Value[1]+","+item.Value[2] + ", Lengte: " + item.Value[3] + ", Breedte: " + item.Value[4] 
                      + "," + item.Value[5] + "," + item.Value[6];*/
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

        private void OnButton_ZoekenMeubel_Click(object sender, RoutedEventArgs e)
        {
            _zoekbalk = TBMeubels.ToString();
            //funcitie uit data die Dictionary<int,list<string>> meubels terug geeft die overeen komen met de text in de zoek balk
           // Dictionary<int, List<string>> outputQuerry = output functie
            #region nepdatabase
            Dictionary<int, List<string>> outputQuerry = new Dictionary<int, List<string>>();
            List<string> list1 = new List<string>();
            List<string> list2 = new List<string>();
            List<string> list3 = new List<string>();
            List<string> list4 = new List<string>();
            List<string> list5 = new List<string>();
            List<string> list6 = new List<string>();
            List<string> list7 = new List<string>();
            List<string> list8 = new List<string>();
            List<string> list9 = new List<string>();
            //list.Add(@"afbeeldingen\stoel.jpg");//0
            /*
           1 tafel |¯¯|
           2 stoel 🦽 
           3 lamp 💡
           4 kast 🗄
           5 plant 🌲
           6 apparaten 🖥
           7 deur 🚪
           8 raam ⬜
           9 tapijt 🔴
            */
            list1.Add("🦽");
            list1.Add("naam");//1
            list1.Add("5,8");//2
            list1.Add("10,6");//3
            list1.Add("8,9");//4
            list1.Add("stoel");//5
            list1.Add("categorie");//6
           outputQuerry.Add(0, list1);
            list2.Add("|¯¯|");
            list2.Add("naam");//1
            list2.Add("5,8");//2
            list2.Add("10,6");//3
            list2.Add("8,9");//4
            list2.Add("tafel");//5
            list2.Add("categorie");//6
            outputQuerry.Add(1, list2);
            list3.Add("💡");
            list3.Add("naam");//1
            list3.Add("5,8");//2
            list3.Add("10,6");//3
            list3.Add("8,9");//4
            list3.Add("lamp");//5
            list3.Add("categorie");//6
            outputQuerry.Add(2, list3);
            list4.Add("🗄");
            list4.Add("naam");//1
            list4.Add("5,8");//2
            list4.Add("10,6");//3
            list4.Add("8,9");//4
            list4.Add("kast");//5
            list4.Add("categorie");//6
            outputQuerry.Add(3, list4);
            list5.Add("🌲");
            list5.Add("naam");//1
            list5.Add("5,8");//2
            list5.Add("10,6");//3
            list5.Add("8,9");//4
            list5.Add("plant");//5
            list5.Add("categorie");//6
            outputQuerry.Add(4, list5);
            list6.Add("🖥");
            list6.Add("naam");//1
            list6.Add("5,8");//2
            list6.Add("10,6");//3
            list6.Add("8,9");//4
            list6.Add("apparaten");//5
            list6.Add("categorie");//6
            outputQuerry.Add(5, list6);
            list7.Add("🚪");
            list7.Add("naam");//1
            list7.Add("5,8");//2
            list7.Add("10,6");//3
            list7.Add("8,9");//4
            list7.Add("deur");//5
            list7.Add("categorie");//6
            outputQuerry.Add(6, list7);
            list8.Add("⬜");
            list8.Add("naam");//1
            list8.Add("5,8");//2
            list8.Add("10,6");//3
            list8.Add("8,9");//4
            list8.Add("raam");//5
            list8.Add("categorie");//6
            outputQuerry.Add(7, list8);
            list9.Add("🔴");
            list9.Add("naam");//1
            list9.Add("5,8");//2
            list9.Add("10,6");//3
            list9.Add("8,9");//4
            list9.Add("tapijt");//5
            list9.Add("categorie");//6
            outputQuerry.Add(8, list9);
            #endregion
            List<Meubel> listMeubels = new List<Meubel>();
            foreach (var item in outputQuerry)
            {
              /* LabelTest.Content= item.Value[0]+"," + item.Value[1]+","+item.Value[2] + ", Lengte: " + item.Value[3] + ", Breedte: " + item.Value[4] 
                    + "," + item.Value[5] + "," + item.Value[6];*/
                var afbeelding = item.Value[0];
                var naam = item.Value[1];
                var prijs =System.Convert.ToDecimal( item.Value[2]);
                var lengte = System.Convert.ToDecimal( item.Value[3]);
                var breedte = System.Convert.ToDecimal( item.Value[4]);
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
    }
}
