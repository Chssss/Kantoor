
using KantoorInrichtingWPF.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using KantoorInrichtingWPF.ViewModel;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using Image = System.Windows.Controls.Image;
using System.Drawing;
using WPF.JoshSmith.Controls;
using KantoorInrichtingWPF.View;
using KantoorInrichtingWPF.Model;

namespace KantoorInrichtingWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private decimal _totalprijst=(decimal)0.0;
        MeubelViewModel meubelView = new MeubelViewModel();
        PlattegrondViewModel plattegrondview = new PlattegrondViewModel();
        OpslaanPlattegrond opslaanPlattegrond = new OpslaanPlattegrond();

        public string ProjectNaam;
        public string PlattegrondNaam;
        public string Lengte;
        public string Breedte;
        public string Hoogte;
        public string Plattegrondcode;
        
        public MainWindow()
        {
            InitializeComponent();
            LabelTotalPrijs.Content = $"{_totalprijst}€";
            


        }
       public void LadenMap( Dictionary<int, List<string>> canvasitems) 
        {
            foreach (var item in canvasitems)
            {
                double xcoord = Convert.ToDouble(item.Value[5]);
                double ycoord = Convert.ToDouble(item.Value[6]);
                _totalprijst = _totalprijst +Convert.ToDecimal( item.Value[4]);
                LabelTotalPrijs.Content = $"{_totalprijst}€";
                AddImageToGeladenMap(item.Value[2], item.Value[3], item.Value[4], xcoord, ycoord);
            }
        }
        public void AddImageToGeladenMap(string typeImage, string naamMeubel, string prijs,double xcoord,double ycoord)
        {

            if (typeImage.Equals("tafel"))
            {
                Image image = new Image();
                BitmapImage bi = new BitmapImage();
                // BitmapImage.UriSource must be in a BeginInit/EndInit block.
                bi.BeginInit();
                bi.UriSource = new Uri(@"/Afbeelding/tafel.png", UriKind.RelativeOrAbsolute);
                bi.EndInit();
                image.Name = "tafel";
                image.Source = bi;
                List<string> list = new List<string>();
                list.Add(naamMeubel);
                list.Add(prijs);
                image.Tag = list;
                DragCavasPlattegrond.Children.Add(image);
                Canvas.SetTop(image, ycoord);
                Canvas.SetLeft(image, xcoord);
                
            }
            if (typeImage.Equals("stoel"))
            {
                Image image = new Image();
                BitmapImage bi = new BitmapImage();
                // BitmapImage.UriSource must be in a BeginInit/EndInit block.
                bi.BeginInit();
                bi.UriSource = new Uri(@"/Afbeelding/stoel.png", UriKind.RelativeOrAbsolute);
                bi.EndInit();
                image.Name = "stoel";
                image.Source = bi;
                List<string> list = new List<string>();
                list.Add(naamMeubel);
                list.Add(prijs);
                image.Tag = list;
                DragCavasPlattegrond.Children.Add(image);

                Canvas.SetTop(image, ycoord);
                Canvas.SetLeft(image, xcoord);
            }
            if (typeImage.Equals("tapijt"))
            {
                Image image = new Image();
                BitmapImage bi = new BitmapImage();
                // BitmapImage.UriSource must be in a BeginInit/EndInit block.
                bi.BeginInit();
                bi.UriSource = new Uri(@"/Afbeelding/tapijt.png", UriKind.RelativeOrAbsolute);
                bi.EndInit();
                image.Name = "tapijt";
                image.Source = bi;
                List<string> list = new List<string>();
                list.Add(naamMeubel);
                list.Add(prijs);
                image.Tag = list;
                DragCavasPlattegrond.Children.Add(image);
                Canvas.SetTop(image, ycoord);
                Canvas.SetLeft(image, xcoord);
            }
            if (typeImage.Equals("raam"))
            {
                Image image = new Image();
                BitmapImage bi = new BitmapImage();
                // BitmapImage.UriSource must be in a BeginInit/EndInit block.
                bi.BeginInit();
                bi.UriSource = new Uri(@"/Afbeelding/raam.png", UriKind.RelativeOrAbsolute);
                bi.EndInit();
                image.Name = "raam";
                image.Source = bi;
                List<string> list = new List<string>();
                list.Add(naamMeubel);
                list.Add(prijs);
                image.Tag = list;
                DragCavasPlattegrond.Children.Add(image);
                Canvas.SetTop(image, ycoord);
                Canvas.SetLeft(image, xcoord);
            }
            if (typeImage.Equals("plant"))
            {
                Image image = new Image();
                BitmapImage bi = new BitmapImage();
                // BitmapImage.UriSource must be in a BeginInit/EndInit block.
                bi.BeginInit();
                bi.UriSource = new Uri(@"/Afbeelding/plant.png", UriKind.RelativeOrAbsolute);
                bi.EndInit();
                image.Name = "plant";
                image.Source = bi;
                List<string> list = new List<string>();
                list.Add(naamMeubel);
                list.Add(prijs);
                image.Tag = list;
                DragCavasPlattegrond.Children.Add(image);
                Canvas.SetTop(image, ycoord);
                Canvas.SetLeft(image, xcoord);
            }
            if (typeImage.Equals("lamp"))
            {
                Image image = new Image();
                BitmapImage bi = new BitmapImage();
                // BitmapImage.UriSource must be in a BeginInit/EndInit block.
                bi.BeginInit();
                bi.UriSource = new Uri(@"/Afbeelding/lamp.png", UriKind.RelativeOrAbsolute);
                bi.EndInit();
                image.Name = "lamp";
                image.Source = bi;
                List<string> list = new List<string>();
                list.Add(naamMeubel);
                list.Add(prijs);
                image.Tag = list;
                DragCavasPlattegrond.Children.Add(image);
                Canvas.SetTop(image, ycoord);
                Canvas.SetLeft(image, xcoord);
            }
            if (typeImage.Equals("kast"))
            {
                Image image = new Image();
                BitmapImage bi = new BitmapImage();
                // BitmapImage.UriSource must be in a BeginInit/EndInit block.
                bi.BeginInit();
                bi.UriSource = new Uri(@"/Afbeelding/kast.png", UriKind.RelativeOrAbsolute);
                bi.EndInit();
                image.Name = "kast";
                image.Source = bi;
                List<string> list = new List<string>();
                list.Add(naamMeubel);
                list.Add(prijs);
                image.Tag = list;
                DragCavasPlattegrond.Children.Add(image);
                Canvas.SetTop(image, ycoord);
                Canvas.SetLeft(image, xcoord);
            }
            if (typeImage.Equals("deur"))
            {
                Image image = new Image();
                BitmapImage bi = new BitmapImage();
                // BitmapImage.UriSource must be in a BeginInit/EndInit block.
                bi.BeginInit();
                bi.UriSource = new Uri(@"/Afbeelding/deur.png", UriKind.RelativeOrAbsolute);
                bi.EndInit();
                image.Name = "deur";
                image.Source = bi;
                List<string> list = new List<string>();
                list.Add(naamMeubel);
                list.Add(prijs);
                image.Tag = list;
                DragCavasPlattegrond.Children.Add(image);
                Canvas.SetTop(image, ycoord);
                Canvas.SetLeft(image, xcoord);
            }
            if (typeImage.Equals("apparaten"))
            {
                Image image = new Image();
                BitmapImage bi = new BitmapImage();
                // BitmapImage.UriSource must be in a BeginInit/EndInit block.
                bi.BeginInit();
                bi.UriSource = new Uri(@"/Afbeelding/apparaat.png", UriKind.RelativeOrAbsolute);
                bi.EndInit();
                image.Name = "apparaten";
                image.Source = bi;
                List<string> list = new List<string>();
                list.Add(naamMeubel);
                list.Add(prijs);
                image.Tag = list;
                DragCavasPlattegrond.Children.Add(image);
                Canvas.SetTop(image, ycoord);
                Canvas.SetLeft(image, xcoord);

            }

        }

        private void OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //LabelTest.Content = "test";
            var dataGrid = sender as DataGrid;
            if (dataGrid != null)
            {
                var index = dataGrid.SelectedIndex;
                //LabelTest.Content = index;
                
                //LabelTest.Content= meubelView.Catalogus[index].tag;
                _totalprijst = _totalprijst + meubelView.Catalogus[index].Prijs;
                LabelTotalPrijs.Content = $"{_totalprijst}€";
                
                AddImage(meubelView.Catalogus[index].Tag,index, meubelView.Catalogus[index].Naam);


            }
        }
        private void OnMouseRightButtonPressed(object sender, MouseButtonEventArgs e)
        {
            var dragCanvas = sender as DragCanvas;
            var image = e.OriginalSource;
            
            if (dragCanvas != null)
            {
                MessageBoxResult dialogResult = MessageBox.Show("Weet je zeker dat je dit meubel wilt verwijderen?", "Meubel verwijderen", MessageBoxButton.YesNo);
                if (dialogResult == MessageBoxResult.Yes)
                {
                 var index  = dragCanvas.Children.IndexOf((UIElement)image);
                    var imageOutCanvas = dragCanvas.Children[index] as Image;
                   
                    List<string> prijs = (List<string>)imageOutCanvas.Tag;
                    _totalprijst = _totalprijst - Convert.ToDecimal( prijs[1]);
                    LabelTotalPrijs.Content = $"{_totalprijst}€";
                    dragCanvas.Children.Remove((UIElement)image);
                }
                else if (dialogResult == MessageBoxResult.No)
                {

                }
            }

        }
        public void AddImage(string typeImage,int index, string naamMeubel)
        {

            if (typeImage.Equals("tafel"))
            {
                Image image = new Image();
                BitmapImage bi = new BitmapImage();
                // BitmapImage.UriSource must be in a BeginInit/EndInit block.
                bi.BeginInit();
                bi.UriSource = new Uri(@"/Afbeelding/tafel.png", UriKind.RelativeOrAbsolute);
                bi.EndInit();
                image.Name = "tafel";
                image.Source = bi;
                List<string> list = new List<string>();
                list.Add(naamMeubel);
                list.Add($"{meubelView.Catalogus[index].Prijs}");
                image.Tag = list;
                DragCavasPlattegrond.Children.Add(image);
                Canvas.SetTop(image, 10.0);
                Canvas.SetLeft(image, 100.00);
                
            }
            if (typeImage.Equals("stoel"))
            {
                Image image = new Image();
                BitmapImage bi = new BitmapImage();
                // BitmapImage.UriSource must be in a BeginInit/EndInit block.
                bi.BeginInit();
                bi.UriSource = new Uri(@"/Afbeelding/stoel.png", UriKind.RelativeOrAbsolute);
                bi.EndInit();
                image.Name = "stoel";
                image.Source = bi;
                List<string> list = new List<string>();
                list.Add(naamMeubel);
                list.Add($"{meubelView.Catalogus[index].Prijs}");
                image.Tag = list;
                DragCavasPlattegrond.Children.Add(image);
                
                Canvas.SetTop(image, 10.0);
                Canvas.SetLeft(image, 100.00);
            }
            if (typeImage.Equals("tapijt"))
            {
                Image image = new Image();
                BitmapImage bi = new BitmapImage();
                // BitmapImage.UriSource must be in a BeginInit/EndInit block.
                bi.BeginInit();
                bi.UriSource = new Uri(@"/Afbeelding/tapijt.png", UriKind.RelativeOrAbsolute);
                bi.EndInit();
                image.Name = "tapijt";
                image.Source = bi;
                List<string> list = new List<string>();
                list.Add(naamMeubel);
                list.Add($"{meubelView.Catalogus[index].Prijs}");
                image.Tag = list;
                DragCavasPlattegrond.Children.Add(image);
                Canvas.SetTop(image, 10.0);
                Canvas.SetLeft(image, 100.00);
            }
            if (typeImage.Equals("raam"))
            {
                Image image = new Image();
                BitmapImage bi = new BitmapImage();
                // BitmapImage.UriSource must be in a BeginInit/EndInit block.
                bi.BeginInit();
                bi.UriSource = new Uri(@"/Afbeelding/raam.png", UriKind.RelativeOrAbsolute);
                bi.EndInit();
                image.Name = "raam";
                image.Source = bi;
                List<string> list = new List<string>();
                list.Add(naamMeubel);
                list.Add($"{meubelView.Catalogus[index].Prijs}");
                image.Tag = list;
                DragCavasPlattegrond.Children.Add(image);
                Canvas.SetTop(image, 10.0);
                Canvas.SetLeft(image, 100.00);
            }
            if (typeImage.Equals("plant"))
            {
                Image image = new Image();
                BitmapImage bi = new BitmapImage();
                // BitmapImage.UriSource must be in a BeginInit/EndInit block.
                bi.BeginInit();
                bi.UriSource = new Uri(@"/Afbeelding/plant.png", UriKind.RelativeOrAbsolute);
                bi.EndInit();
                image.Name = "plant";
                image.Source = bi;
                List<string> list = new List<string>();
                list.Add(naamMeubel);
                list.Add($"{meubelView.Catalogus[index].Prijs}");
                image.Tag = list;
                DragCavasPlattegrond.Children.Add(image);
                Canvas.SetTop(image, 10.0);
                Canvas.SetLeft(image, 100.00);
            }
            if (typeImage.Equals("lamp"))
            {
                Image image = new Image();
                BitmapImage bi = new BitmapImage();
                // BitmapImage.UriSource must be in a BeginInit/EndInit block.
                bi.BeginInit();
                bi.UriSource = new Uri(@"/Afbeelding/lamp.png", UriKind.RelativeOrAbsolute);
                bi.EndInit();
                image.Name = "lamp";
                image.Source = bi;
                List<string> list = new List<string>();
                list.Add(naamMeubel);
                list.Add($"{meubelView.Catalogus[index].Prijs}");
                image.Tag = list;
                DragCavasPlattegrond.Children.Add(image);
                Canvas.SetTop(image, 10.0);
                Canvas.SetLeft(image, 100.00);
            }
            if (typeImage.Equals("kast"))
            {
                Image image = new Image();
                BitmapImage bi = new BitmapImage();
                // BitmapImage.UriSource must be in a BeginInit/EndInit block.
                bi.BeginInit();
                bi.UriSource = new Uri(@"/Afbeelding/kast.png", UriKind.RelativeOrAbsolute);
                bi.EndInit();
                image.Name = "kast";
                image.Source = bi;
                List<string> list = new List<string>();
                list.Add(naamMeubel);
                list.Add($"{meubelView.Catalogus[index].Prijs}");
                image.Tag = list;
                DragCavasPlattegrond.Children.Add(image);
                Canvas.SetTop(image, 10.0);
                Canvas.SetLeft(image, 100.00);
            }
            if (typeImage.Equals("deur"))
            {
                Image image = new Image();
                BitmapImage bi = new BitmapImage();
                // BitmapImage.UriSource must be in a BeginInit/EndInit block.
                bi.BeginInit();
                bi.UriSource = new Uri(@"/Afbeelding/deur.png", UriKind.RelativeOrAbsolute);
                bi.EndInit();
                image.Name = "deur";
                image.Source = bi;
                List<string> list = new List<string>();
                list.Add(naamMeubel);
                list.Add($"{meubelView.Catalogus[index].Prijs}");
                image.Tag = list;
                DragCavasPlattegrond.Children.Add(image);
                Canvas.SetTop(image, 10.0);
                Canvas.SetLeft(image, 100.00);
            }
            if (typeImage.Equals("apparaten"))
            {
                Image image = new Image();
                BitmapImage bi = new BitmapImage();
                // BitmapImage.UriSource must be in a BeginInit/EndInit block.
                bi.BeginInit();
                bi.UriSource = new Uri(@"/Afbeelding/apparaat.png", UriKind.RelativeOrAbsolute);
                bi.EndInit();
                image.Name = "apparaten";
                image.Source = bi;
                List<string> list = new List<string>();
                list.Add(naamMeubel);
                list.Add($"{meubelView.Catalogus[index].Prijs}");
                image.Tag = list;
                DragCavasPlattegrond.Children.Add(image);
                Canvas.SetTop(image, 10.0);
                Canvas.SetLeft(image, 100.00);
                
            }

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
            LadenPlategrond ladenPlategrond = new LadenPlategrond();
            ladenPlategrond.Show();
            ladenPlategrond.MouseDoubleClick += LadenPlategrond_MouseDoubleClick;
        }

        private void LadenPlategrond_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void OnMenuItem_opslaan_Click(object sender, RoutedEventArgs e)
        {
          bool output =plattegrondview.CheckPlattegrondcode(Plattegrondcode,ProjectNaam,PlattegrondNaam,Lengte,Breedte,Hoogte);
            if (output==true)
            {
                #region delete en toevoegen
                plattegrondview.VerwijderenCanvasitem(Plattegrondcode);
                #endregion
                plattegrondview.PlattegrondNaam = PlattegrondNaam;
                foreach (Image item in DragCavasPlattegrond.Children)
                {
                        plattegrondview.Plattegrondcode = Plattegrondcode;
                        double x = Canvas.GetLeft(item);
                        double y = Canvas.GetTop(item);


                        //plattegrondview.Plattegrondcode = Plattegrondcode;
                        plattegrondview.CanvasImageType = $"{item.Name}";
                        List<string> list = (List<string>)item.Tag;
                        plattegrondview.CanvasImageName = $"{list[0]}";
                        plattegrondview.CanvasImageTag = $"{list[1]}";
                        plattegrondview.XCoord = $"{x}";
                        plattegrondview.YCoord = $"{y}";
                        string canvasitemcode = $"{plattegrondview.Plattegrondcode}{plattegrondview.CanvasImageType[0]}{plattegrondview.CanvasItemCount}";
                        plattegrondview.CanvasItemcode = canvasitemcode;
                        plattegrondview.CanvasItemCount++;
                    #region delete en toevoegen
                    plattegrondview.ToevoegenCanvasItems();
                    #endregion
                    #region update en toevoegen
                    /* bool check = plattegrondview.CheckCanvasitemcode(canvasitemcode);

                     if (check==true)
                     {

                         plattegrondview.UpdateCanvasItems();
                     }
                     if (check==false)
                     {
                         plattegrondview.ToevoegenCanvasItems();//new canvasitem Toevoegen
                     }*/
                    #endregion
                }
            }
            
        }

        private void OnMenuItem_opslaanAls_Click(object sender, RoutedEventArgs e)
        {
            opslaanPlattegrond.TBLengte.Text = Lengte;
            opslaanPlattegrond.TBPlattegrondNaam.Text = PlattegrondNaam;
            opslaanPlattegrond.TBProjectNaam.Text = ProjectNaam;
            opslaanPlattegrond.TBBreedte.Text = Breedte;
            opslaanPlattegrond.TBHoogte.Text = Hoogte;
            opslaanPlattegrond.Show();
            opslaanPlattegrond.ButtonOpslaan.Click += OnButtonOpslaan_Click;
            
        }

        private void OnButtonOpslaan_Click(object sender, RoutedEventArgs e)
        {
            //PlattegrondNaam, CanvasItemcode, CanvasImageType, CanvasImageName, CanvasImageTag, XCoord, YCoord
            plattegrondview.PlattegrondNaam = opslaanPlattegrond.TBPlattegrondNaam.Text;
            foreach (Image item in DragCavasPlattegrond.Children)
            {
                double x = Canvas.GetLeft(item);
                double y = Canvas.GetTop(item);
                
                
                plattegrondview.Plattegrondcode = $"{plattegrondview.PlattegrondNaam[0]}{plattegrondview.PlattegrondNaam[1]}{plattegrondview.PlattegrondLijst.Count}";
                plattegrondview.CanvasImageType = $"{item.Name}";
                List<string> list = (List<string>)item.Tag;
                plattegrondview.CanvasImageName = $"{list[0]}";
                plattegrondview.CanvasImageTag = $"{list[1]}";
                plattegrondview.XCoord = $"{x}";
                plattegrondview.YCoord = $"{y}";
                plattegrondview.CanvasItemcode = $"{plattegrondview.Plattegrondcode}{plattegrondview.CanvasImageType[0]}{plattegrondview.CanvasItemCount}";
                plattegrondview.CanvasItemCount++;
                plattegrondview.ToevoegenCanvasItems();
            }
           
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
            
            Dictionary<string, List<string>> Gebruiktemeubels = new Dictionary<string, List<string>>();
            decimal totaalprijs = 0;
            plattegrondview.LeegGebruikteMeubelLijst();
            foreach (Image item in DragCavasPlattegrond.Children)
            {
                List<string> list = (List<string>)item.Tag;
                if (Gebruiktemeubels.ContainsKey(list[0]))
                {
                    int count = Convert.ToInt32(Gebruiktemeubels[list[0]][1]);
                    count++;
                    Gebruiktemeubels[list[0]][1] = $"{count}";
                }
                else
                {
                    List<string> listPrijsAantal = new List<string>();
                    listPrijsAantal.Add(list[1]);
                    listPrijsAantal.Add("1");
                    Gebruiktemeubels.Add(list[0], listPrijsAantal);
                }
            }
            foreach (var item in Gebruiktemeubels)
            {
                plattegrondview.ToevoegenGebruikteMeubel(item.Key,Convert.ToInt32(item.Value[1]), Convert.ToDecimal(item.Value[0]));
                totaalprijs = totaalprijs + (Convert.ToInt32(item.Value[1]) * Convert.ToDecimal(item.Value[0]));
            }

            List<GebruikteMeubels> test = plattegrondview.GebruikteMeubelsLijst;

            OverzichtGebruikteMeubels overzichtGebruikteMeubels = new OverzichtGebruikteMeubels();
            overzichtGebruikteMeubels.DGGebruikteMeubels.ItemsSource = test;
            overzichtGebruikteMeubels.LabelTotalprijs.Content = $"{totaalprijs}€";
            overzichtGebruikteMeubels.Show();
        }

        private void OnButton_ZoekenMeubelNaam_Click(object sender, RoutedEventArgs e)
        {
            
            
            
            
        }

        private void OnButton_RefreshMeubel_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void OnButton_ZoekenMeubelCategorie_Click(object sender, RoutedEventArgs e)
        {
            

            

        }

        private void ButtonRaam_Click(object sender, RoutedEventArgs e)
        {
            Image image = new Image();
            BitmapImage bi = new BitmapImage();
            // BitmapImage.UriSource must be in a BeginInit/EndInit block.
            bi.BeginInit();
            bi.UriSource = new Uri(@"/Afbeelding/raam.png", UriKind.RelativeOrAbsolute);
            bi.EndInit();
            image.Name = "raam";
            image.Source = bi;
            List<string> list = new List<string>();
            list.Add("raam");
            list.Add($"0,0");
            image.Tag = list;
            DragCavasPlattegrond.Children.Add(image);
            Canvas.SetTop(image, 10.0);
            Canvas.SetLeft(image, 100.00);
        }

        private void ButtonDeur_Click(object sender, RoutedEventArgs e)
        {
            Image image = new Image();
            BitmapImage bi = new BitmapImage();
            // BitmapImage.UriSource must be in a BeginInit/EndInit block.
            bi.BeginInit();
            bi.UriSource = new Uri(@"/Afbeelding/deur2.png", UriKind.RelativeOrAbsolute);
            bi.EndInit();
            image.Name = "deur";
            image.Source = bi;
            List<string> list = new List<string>();
            list.Add("deur");
            list.Add($"0,0");
            image.Tag = list;
            DragCavasPlattegrond.Children.Add(image);
            Canvas.SetTop(image, 10.0);
            Canvas.SetLeft(image, 100.00);
        }

        private void ButtonMuur_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
