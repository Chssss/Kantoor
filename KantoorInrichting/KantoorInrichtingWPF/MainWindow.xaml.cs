
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
using Microsoft.SqlServer.Server;

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
        public string Lengte="10,0";
        public string Breedte="10,0";
        public string Hoogte="10,0";
        public string Plattegrondcode;

        protected bool muurCheck;
        protected bool isDragging;
        private System.Windows.Point clickPosition;
        private System.Windows.Point currentPosition;

        public MainWindow()
        {
            InitializeComponent();
            LabelTotalPrijs.Content = $"{_totalprijst}€";
            meubelView.XmlInvoegen();
            LabelLengte.Content = $"Lengte:{Lengte}";
            LabelBreedte.Content = $"Breedte:{Breedte}";
            LabelHoogte.Content = $"Hoogte:{Hoogte}";



        }
       public void LadenMap( Dictionary<int, List<string>> canvasitems) 
        {
            foreach (var item in canvasitems)
            {
                double xcoord = Convert.ToDouble(item.Value[5]);
                double ycoord = Convert.ToDouble(item.Value[6]);
                _totalprijst = _totalprijst +Convert.ToDecimal( item.Value[4]);
                LabelTotalPrijs.Content = $"{_totalprijst}€";
                var tempLeverancier = item.Value[7];
                var tempProductcode = item.Value[8];
                var rotatie = item.Value[9];
                AddImageToGeladenMap(item.Value[2], item.Value[3], item.Value[4], xcoord, ycoord,tempLeverancier,tempProductcode,rotatie);
            }
        }
        public void AddImageToGeladenMap(string typeImage, string naamMeubel, string prijs,double xcoord,double ycoord, string leverancier,string productcode, string rotatie)
        {
            if (typeImage.Equals("notitie"))
            {
                TextBlock textblock = new TextBlock();
                textblock.Text = $"{leverancier}";
                textblock.Name = "notitie";
                List<string> list = new List<string>();
                list.Add(naamMeubel);
                list.Add(prijs);
                list.Add(leverancier);
                list.Add(productcode);
                list.Add(rotatie);
                textblock.Tag = list;
                DragCavasPlattegrond.Children.Add(textblock);
                Canvas.SetTop(textblock, ycoord);
                Canvas.SetLeft(textblock, xcoord);
                int index = DragCavasPlattegrond.Children.IndexOf(textblock);
                TextBlock image2 = (TextBlock)DragCavasPlattegrond.Children[index];

                List<string> imageTag = (List<string>)image2.Tag;
                double rotatie1 = Convert.ToDouble(rotatie);
                RotateTransform rotateTransform1 = new RotateTransform(rotatie1);
                var x = image2.ActualWidth / 2;
                var y = image2.ActualHeight / 2;
                rotateTransform1.CenterX = x;
                rotateTransform1.CenterY = y;
                image2.RenderTransform = rotateTransform1;
                imageTag[4] = $"{rotatie}";
                image2.Tag = imageTag;
            }

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

                list.Add(leverancier);
                list.Add(productcode);
                list.Add(rotatie);
                image.Tag = list;
                
                 DragCavasPlattegrond.Children.Add(image);

                Canvas.SetTop(image, ycoord);
                Canvas.SetLeft(image, xcoord);

                int index = DragCavasPlattegrond.Children.IndexOf(image);
                Image image2 = (Image)DragCavasPlattegrond.Children[index];

                List<string> imageTag = (List<string>)image2.Tag;
                double rotatie1 = Convert.ToDouble(rotatie);
                RotateTransform rotateTransform1 = new RotateTransform(rotatie1);
                var x = image2.ActualWidth / 2;
                var y = image2.ActualHeight / 2;
                rotateTransform1.CenterX = x;
                rotateTransform1.CenterY = y;
                image2.RenderTransform = rotateTransform1;
                imageTag[4] = $"{rotatie}";
                image2.Tag = imageTag;

             

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

                list.Add(leverancier);
                list.Add(productcode);
                list.Add(rotatie);
                image.Tag = list;
                
                DragCavasPlattegrond.Children.Add(image);

                Canvas.SetTop(image, ycoord);
                Canvas.SetLeft(image, xcoord);

               int index= DragCavasPlattegrond.Children.IndexOf(image);
               Image image2 = (Image)DragCavasPlattegrond.Children[index];
                
                List<string> imageTag = (List<string>)image2.Tag;
                double rotatie1 = Convert.ToDouble(rotatie);
                RotateTransform rotateTransform1 = new RotateTransform(rotatie1);
                var x = image2.ActualWidth / 2;
                var y = image2.ActualHeight / 2;
                rotateTransform1.CenterX = x;
                rotateTransform1.CenterY = y;
                image2.RenderTransform = rotateTransform1;
                imageTag[4] = $"{rotatie}";
                image2.Tag = imageTag;

                
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

                list.Add(leverancier);
                list.Add(productcode);
                list.Add(rotatie);
                image.Tag = list;
                
                DragCavasPlattegrond.Children.Add(image);
                Canvas.SetTop(image, ycoord);
                Canvas.SetLeft(image, xcoord);
                int index = DragCavasPlattegrond.Children.IndexOf(image);
                Image image2 = (Image)DragCavasPlattegrond.Children[index];

                List<string> imageTag = (List<string>)image2.Tag;
                double rotatie1 = Convert.ToDouble(rotatie);
                RotateTransform rotateTransform1 = new RotateTransform(rotatie1);
                var x = image2.ActualWidth / 2;
                var y = image2.ActualHeight / 2;
                rotateTransform1.CenterX = x;
                rotateTransform1.CenterY = y;
                image2.RenderTransform = rotateTransform1;
                imageTag[4] = $"{rotatie}";
                image2.Tag = imageTag;
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

                list.Add(leverancier);
                list.Add(productcode);
                list.Add(rotatie);
                image.Tag = list;
                
                DragCavasPlattegrond.Children.Add(image);
                Canvas.SetTop(image, ycoord);
                Canvas.SetLeft(image, xcoord);
                int index = DragCavasPlattegrond.Children.IndexOf(image);
                Image image2 = (Image)DragCavasPlattegrond.Children[index];

                List<string> imageTag = (List<string>)image2.Tag;
                double rotatie1 = Convert.ToDouble(rotatie);
                RotateTransform rotateTransform1 = new RotateTransform(rotatie1);
                var x = image2.ActualWidth / 2;
                var y = image2.ActualHeight / 2;
                rotateTransform1.CenterX = x;
                rotateTransform1.CenterY = y;
                image2.RenderTransform = rotateTransform1;
                imageTag[4] = $"{rotatie}";
                image2.Tag = imageTag;
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

                list.Add(leverancier);
                list.Add(productcode);
                list.Add(rotatie);
                image.Tag = list;
                
                DragCavasPlattegrond.Children.Add(image);
                Canvas.SetTop(image, ycoord);
                Canvas.SetLeft(image, xcoord);
                int index = DragCavasPlattegrond.Children.IndexOf(image);
                Image image2 = (Image)DragCavasPlattegrond.Children[index];

                List<string> imageTag = (List<string>)image2.Tag;
                double rotatie1 = Convert.ToDouble(rotatie);
                RotateTransform rotateTransform1 = new RotateTransform(rotatie1);
                var x = image2.ActualWidth / 2;
                var y = image2.ActualHeight / 2;
                rotateTransform1.CenterX = x;
                rotateTransform1.CenterY = y;
                image2.RenderTransform = rotateTransform1;
                imageTag[4] = $"{rotatie}";
                image2.Tag = imageTag;
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

                list.Add(leverancier);
                list.Add(productcode);
                list.Add(rotatie);
                image.Tag = list;
                
                DragCavasPlattegrond.Children.Add(image);
                Canvas.SetTop(image, ycoord);
                Canvas.SetLeft(image, xcoord);
                int index = DragCavasPlattegrond.Children.IndexOf(image);
                Image image2 = (Image)DragCavasPlattegrond.Children[index];

                List<string> imageTag = (List<string>)image2.Tag;
                double rotatie1 = Convert.ToDouble(rotatie);
                RotateTransform rotateTransform1 = new RotateTransform(rotatie1);
                var x = image2.ActualWidth / 2;
                var y = image2.ActualHeight / 2;
                rotateTransform1.CenterX = x;
                rotateTransform1.CenterY = y;
                image2.RenderTransform = rotateTransform1;
                imageTag[4] = $"{rotatie}";
                image2.Tag = imageTag;
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

                list.Add(leverancier);
                list.Add(productcode);
                list.Add(rotatie);
                image.Tag = list;
              
                DragCavasPlattegrond.Children.Add(image);
                Canvas.SetTop(image, ycoord);
                Canvas.SetLeft(image, xcoord);
                int index = DragCavasPlattegrond.Children.IndexOf(image);
                Image image2 = (Image)DragCavasPlattegrond.Children[index];

                List<string> imageTag = (List<string>)image2.Tag;
                double rotatie1 = Convert.ToDouble(rotatie);
                RotateTransform rotateTransform1 = new RotateTransform(rotatie1);
                var x = image2.ActualWidth / 2;
                var y = image2.ActualHeight / 2;
                rotateTransform1.CenterX = x;
                rotateTransform1.CenterY = y;
                image2.RenderTransform = rotateTransform1;
                imageTag[4] = $"{rotatie}";
                image2.Tag = imageTag;
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

                list.Add(leverancier);
                list.Add(productcode);
                list.Add(rotatie);
                image.Tag = list;
               
                DragCavasPlattegrond.Children.Add(image);
                Canvas.SetTop(image, ycoord);
                Canvas.SetLeft(image, xcoord);
                int index = DragCavasPlattegrond.Children.IndexOf(image);
                Image image2 = (Image)DragCavasPlattegrond.Children[index];

                List<string> imageTag = (List<string>)image2.Tag;
                double rotatie1 = Convert.ToDouble(rotatie);
                RotateTransform rotateTransform1 = new RotateTransform(rotatie1);
                var x = image2.ActualWidth / 2;
                var y = image2.ActualHeight / 2;
                rotateTransform1.CenterX = x;
                rotateTransform1.CenterY = y;
                image2.RenderTransform = rotateTransform1;
                imageTag[4] = $"{rotatie}";
                image2.Tag = imageTag;
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

                list.Add(leverancier);
                list.Add(productcode);
                list.Add(rotatie);
                image.Tag = list;
               
                DragCavasPlattegrond.Children.Add(image);
                Canvas.SetTop(image, ycoord);
                Canvas.SetLeft(image, xcoord);
                int index = DragCavasPlattegrond.Children.IndexOf(image);
                Image image2 = (Image)DragCavasPlattegrond.Children[index];

                List<string> imageTag = (List<string>)image2.Tag;
                double rotatie1 = Convert.ToDouble(rotatie);
                RotateTransform rotateTransform1 = new RotateTransform(rotatie1);
                var x = image2.ActualWidth / 2;
                var y = image2.ActualHeight / 2;
                rotateTransform1.CenterX = x;
                rotateTransform1.CenterY = y;
                image2.RenderTransform = rotateTransform1;
                imageTag[4] = $"{rotatie}";
                image2.Tag = imageTag;
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
                var tempLeverancier = meubelView.Catalogus[index].Leverancier;
                var tempProductcode = meubelView.Catalogus[index].Productcode;
                AddImage(meubelView.Catalogus[index].Tag,index, meubelView.Catalogus[index].Naam,tempLeverancier,tempProductcode);


            }
        }
        private void OnMouseRightButtonPressed(object sender, MouseButtonEventArgs e)
        {
            var dragCanvas = sender as DragCanvas;
            var image = e.OriginalSource;
            
            if (dragCanvas != null && image != dragCanvas)
            {
                MessageBoxResult dialogResult = MessageBox.Show("Weet je zeker dat je dit meubel wilt verwijderen?", "Meubel verwijderen", MessageBoxButton.YesNo);
                if (dialogResult == MessageBoxResult.Yes)
                {
                 var index  = dragCanvas.Children.IndexOf((UIElement)image);
                    if (DragCavasPlattegrond.Children[index].GetType() == typeof(Image))
                    {
                        var imageOutCanvas = dragCanvas.Children[index] as Image;
                        List<string> prijs = (List<string>)imageOutCanvas.Tag;
                        _totalprijst = _totalprijst - Convert.ToDecimal(prijs[1]);
                        LabelTotalPrijs.Content = $"{_totalprijst}€";
                        dragCanvas.Children.Remove((UIElement)image);
                        return;
                    }
                        
                    if (DragCavasPlattegrond.Children[index].GetType() == typeof(TextBlock))
                    {
                        var TexBlock = dragCanvas.Children[index] as TextBlock;
                        List<string> prijs = (List<string>)TexBlock.Tag;
                        _totalprijst = _totalprijst - Convert.ToDecimal(prijs[1]);
                        LabelTotalPrijs.Content = $"{_totalprijst}€";
                        dragCanvas.Children.Remove((UIElement)image);
                        return;
                    }
                    if (DragCavasPlattegrond.Children[index].GetType() == typeof(Line))
                    {
                        var line = dragCanvas.Children[index] as Line;
                        List<string> prijs = (List<string>)line.Tag;
                        _totalprijst = _totalprijst - Convert.ToDecimal(prijs[1]);
                        LabelTotalPrijs.Content = $"{_totalprijst}€";
                        dragCanvas.Children.Remove((UIElement)image);
                        return;
                    }




                }
                else if (dialogResult == MessageBoxResult.No)
                {

                }
            }

        }
        public void AddImage(string typeImage,int index, string naamMeubel,string leverancier,string productcode)
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

                list.Add(leverancier);
                list.Add(productcode);
                list.Add("0");

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

                list.Add(leverancier);
                list.Add(productcode);
                list.Add("0");
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

                list.Add(leverancier);
                list.Add(productcode);
                list.Add("0");
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

                list.Add(leverancier);
                list.Add(productcode);
                list.Add("0");
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

                list.Add(leverancier);
                list.Add(productcode);
                list.Add("0");
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

                list.Add(leverancier);
                list.Add(productcode);
                list.Add("0");
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

                list.Add(leverancier);
                list.Add(productcode);
                list.Add("0");
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

                list.Add(leverancier);
                list.Add(productcode);
                list.Add("0");
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

                list.Add(leverancier);
                list.Add(productcode);
                list.Add("0");
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
                
                plattegrondview.VerwijderenCanvasitem(Plattegrondcode);
                
                plattegrondview.PlattegrondNaam = PlattegrondNaam;

                List<Image> ListImages = new List<Image>();
                List<TextBlock> LIstTextBlock = new List<TextBlock>();
                List<Line> ListLine = new List<Line>();
                for (int i = 0; i < DragCavasPlattegrond.Children.Count; i++)
                {
                    if (DragCavasPlattegrond.Children[i].GetType() == typeof(Image))
                    {
                        ListImages.Add((Image)DragCavasPlattegrond.Children[i]);
                    }
                    if (DragCavasPlattegrond.Children[i].GetType() == typeof(TextBlock))
                    {
                        LIstTextBlock.Add((TextBlock)DragCavasPlattegrond.Children[i]);
                    }
                    if (DragCavasPlattegrond.Children[i].GetType() == typeof(Line))
                    {
                       ListLine.Add((Line)DragCavasPlattegrond.Children[i]);
                    }
                }
                foreach (Image item in ListImages)
                {
                        plattegrondview.Plattegrondcode = Plattegrondcode;
                        double x = Canvas.GetLeft(item);
                        double y = Canvas.GetTop(item);


                        //plattegrondview.Plattegrondcode = Plattegrondcode;
                        plattegrondview.CanvasImageType = $"{item.Name}";
                        List<string> list = (List<string>)item.Tag;
                        plattegrondview.CanvasImageName = $"{list[0]}";
                        plattegrondview.CanvasImageTag = $"{list[1]}";

                    plattegrondview.CanvasImageLeverancier= $"{list[2]}";
                    plattegrondview.CanvasImageProductcode = $"{list[3]}";
                    plattegrondview.CanvasImageRotation = $"{list[4]}";
                    plattegrondview.XCoord = $"{x}";
                        plattegrondview.YCoord = $"{y}";
                        string canvasitemcode = $"{plattegrondview.Plattegrondcode}{plattegrondview.CanvasImageType[0]}{plattegrondview.CanvasItemCount}";
                        plattegrondview.CanvasItemcode = canvasitemcode;
                        plattegrondview.CanvasItemCount++;
                   
                    plattegrondview.ToevoegenCanvasItems();
                    
                    
                }
                foreach (TextBlock item in LIstTextBlock)
                {
                    plattegrondview.Plattegrondcode = Plattegrondcode;
                    double x = Canvas.GetLeft(item);
                    double y = Canvas.GetTop(item);


                    //plattegrondview.Plattegrondcode = Plattegrondcode;
                    plattegrondview.CanvasImageType = $"{item.Name}";
                    List<string> list = (List<string>)item.Tag;
                    plattegrondview.CanvasImageName = $"{list[0]}";
                    plattegrondview.CanvasImageTag = $"{list[1]}";

                    plattegrondview.CanvasImageLeverancier = $"{list[2]}";
                    plattegrondview.CanvasImageProductcode = $"{list[3]}";
                    plattegrondview.CanvasImageRotation = $"{list[4]}";
                    plattegrondview.XCoord = $"{x}";
                    plattegrondview.YCoord = $"{y}";
                    string canvasitemcode = $"{plattegrondview.Plattegrondcode}{plattegrondview.CanvasImageType[0]}{plattegrondview.CanvasItemCount}";
                    plattegrondview.CanvasItemcode = canvasitemcode;
                    plattegrondview.CanvasItemCount++;

                    plattegrondview.ToevoegenCanvasItems();


                }
                foreach (Line item in ListLine)
                {
                    plattegrondview.Plattegrondcode = Plattegrondcode;
                    double x = Canvas.GetLeft(item);
                    double y = Canvas.GetTop(item);


                    //plattegrondview.Plattegrondcode = Plattegrondcode;
                    plattegrondview.CanvasImageType = $"{item.Name}";
                    List<string> list = (List<string>)item.Tag;
                    plattegrondview.CanvasImageName = $"{list[0]}";
                    plattegrondview.CanvasImageTag = $"{list[1]}";

                    plattegrondview.CanvasImageLeverancier = $"{list[2]}";
                    plattegrondview.CanvasImageProductcode = $"{list[3]}";
                    plattegrondview.CanvasImageRotation = $"{list[4]}";
                    plattegrondview.XCoord = $"{x}";
                    plattegrondview.YCoord = $"{y}";
                    string canvasitemcode = $"{plattegrondview.Plattegrondcode}{plattegrondview.CanvasImageType[0]}{plattegrondview.CanvasItemCount}";
                    plattegrondview.CanvasItemcode = canvasitemcode;
                    plattegrondview.CanvasItemCount++;

                    plattegrondview.ToevoegenCanvasItems();


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
            List<Image> ListImages = new List<Image>();
            List<TextBlock> LIstTextBlock = new List<TextBlock>();
            List<Line> ListLine = new List<Line>();
            for (int i = 0; i < DragCavasPlattegrond.Children.Count; i++)
            {
                if (DragCavasPlattegrond.Children[i].GetType() == typeof(Image))
                {
                    ListImages.Add((Image)DragCavasPlattegrond.Children[i]);
                }
                if (DragCavasPlattegrond.Children[i].GetType() == typeof(TextBlock))
                {
                    LIstTextBlock.Add((TextBlock)DragCavasPlattegrond.Children[i]);
                }
                if (DragCavasPlattegrond.Children[i].GetType() == typeof(Line))
                {
                    ListLine.Add((Line)DragCavasPlattegrond.Children[i]);
                }
            }
            foreach (Image item in ListImages)
            {
                double x = Canvas.GetLeft(item);
                double y = Canvas.GetTop(item);
                
                
                plattegrondview.Plattegrondcode = $"{plattegrondview.PlattegrondNaam[0]}{plattegrondview.PlattegrondNaam[1]}{plattegrondview.PlattegrondLijst.Count}";
                plattegrondview.CanvasImageType = $"{item.Name}";
                List<string> list = (List<string>)item.Tag;
                plattegrondview.CanvasImageName = $"{list[0]}";
                plattegrondview.CanvasImageTag = $"{list[1]}";
                plattegrondview.CanvasImageLeverancier = $"{list[2]}";
                plattegrondview.CanvasImageProductcode = $"{list[3]}";
                plattegrondview.CanvasImageRotation = $"{list[4]}";
                plattegrondview.XCoord = $"{x}";
                plattegrondview.YCoord = $"{y}";
                plattegrondview.CanvasItemcode = $"{plattegrondview.Plattegrondcode}{plattegrondview.CanvasImageType[0]}{plattegrondview.CanvasItemCount}";
                plattegrondview.CanvasItemCount++;
                plattegrondview.ToevoegenCanvasItems();
            }
            foreach (TextBlock item in LIstTextBlock)
            {
                plattegrondview.Plattegrondcode = $"{plattegrondview.PlattegrondNaam[0]}{plattegrondview.PlattegrondNaam[1]}{plattegrondview.PlattegrondLijst.Count}";
                
                double x = Canvas.GetLeft(item);
                double y = Canvas.GetTop(item);


                //plattegrondview.Plattegrondcode = Plattegrondcode;
                plattegrondview.CanvasImageType = $"{item.Name}";
                List<string> list = (List<string>)item.Tag;
                plattegrondview.CanvasImageName = $"{list[0]}";
                plattegrondview.CanvasImageTag = $"{list[1]}";

                plattegrondview.CanvasImageLeverancier = $"{list[2]}";
                plattegrondview.CanvasImageProductcode = $"{list[3]}";
                plattegrondview.CanvasImageRotation = $"{list[4]}";
                plattegrondview.XCoord = $"{x}";
                plattegrondview.YCoord = $"{y}";
                string canvasitemcode = $"{plattegrondview.Plattegrondcode}{plattegrondview.CanvasImageType[0]}{plattegrondview.CanvasItemCount}";
                plattegrondview.CanvasItemcode = canvasitemcode;
                plattegrondview.CanvasItemCount++;

                plattegrondview.ToevoegenCanvasItems();


            }
            foreach (Line item in ListLine)
            {
                plattegrondview.Plattegrondcode = Plattegrondcode;
                double x = Canvas.GetLeft(item);
                double y = Canvas.GetTop(item);


                //plattegrondview.Plattegrondcode = Plattegrondcode;
                plattegrondview.CanvasImageType = $"{item.Name}";
                List<string> list = (List<string>)item.Tag;
                plattegrondview.CanvasImageName = $"{list[0]}";
                plattegrondview.CanvasImageTag = $"{list[1]}";

                plattegrondview.CanvasImageLeverancier = $"{list[2]}";
                plattegrondview.CanvasImageProductcode = $"{list[3]}";
                plattegrondview.CanvasImageRotation = $"{list[4]}";
                plattegrondview.XCoord = $"{x}";
                plattegrondview.YCoord = $"{y}";
                string canvasitemcode = $"{plattegrondview.Plattegrondcode}{plattegrondview.CanvasImageType[0]}{plattegrondview.CanvasItemCount}";
                plattegrondview.CanvasItemcode = canvasitemcode;
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
            Gebruiktemeubels = GetChilderenFromCanvas();
            foreach (var item in Gebruiktemeubels)
            {
                plattegrondview.ToevoegenGebruikteMeubel(item.Key,Convert.ToInt32(item.Value[1]), Convert.ToDecimal(item.Value[0]),item.Value[2],item.Value[3]);
                totaalprijs = totaalprijs + (Convert.ToInt32(item.Value[1]) * Convert.ToDecimal(item.Value[0]));
            }

            List<GebruikteMeubels> test = plattegrondview.GebruikteMeubelsLijst;

            OverzichtGebruikteMeubels overzichtGebruikteMeubels = new OverzichtGebruikteMeubels();
            overzichtGebruikteMeubels.DGGebruikteMeubels.ItemsSource = test;
            overzichtGebruikteMeubels.LabelTotalprijs.Content = $"Totaalprijs:{totaalprijs}€";
            overzichtGebruikteMeubels.Plattegrondnaam = PlattegrondNaam;
            overzichtGebruikteMeubels.Show();
        }
        private Dictionary<string,List<string>> GetChilderenFromCanvas() 
        {
            Dictionary<string, List<string>> Gebruiktemeubels = new Dictionary<string, List<string>>();
            List<Image> ListImages = new List<Image>();
            for (int i = 0; i < DragCavasPlattegrond.Children.Count; i++)
            {
                if (DragCavasPlattegrond.Children[i].GetType() == typeof(Image))
                {
                    ListImages.Add((Image)DragCavasPlattegrond.Children[i]);
                }
            }
            

            foreach (Image item in ListImages)
            {
                
                List<string> list = (List<string>)item.Tag;
                if (Gebruiktemeubels.ContainsKey(list[0]))
                {
                    int count = Convert.ToInt32(Gebruiktemeubels[list[0]][1]);
                    count++;
                    Gebruiktemeubels[list[0]][1] = $"{count}";
                }


                if (Gebruiktemeubels.ContainsKey(list[0]) == false)
                {
                    if (list[0].Equals("deur") || list[0].Equals("raam")|| list[0].Equals("muur") || list[0].Equals("notitie"))
                    {

                    }
                    else
                    {
                        List<string> listPrijsAantal = new List<string>();
                        listPrijsAantal.Add(list[1]);
                        listPrijsAantal.Add("1");
                        listPrijsAantal.Add(list[2]);
                        listPrijsAantal.Add(list[3]);
                        Gebruiktemeubels.Add(list[0], listPrijsAantal);
                    }

                }


            }
            return Gebruiktemeubels;
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
            list.Add("n.v.t");
            list.Add("n.v.t");
            list.Add("0");
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
            list.Add("n.v.t");
            list.Add("n.v.t");
            list.Add("0");
            image.Tag = list;
            DragCavasPlattegrond.Children.Add(image);
            Canvas.SetTop(image, 10.0);
            Canvas.SetLeft(image, 100.00);
        }
        private void ButtonNotitie_Click(object sender, RoutedEventArgs e)
        {
            NotitieInput notitieInput = new NotitieInput();
            notitieInput.Show();
            notitieInput.ButtonDone.Click += OnButtonDone_Click;
            
        }

        private void OnButtonDone_Click(object sender, RoutedEventArgs e)
        {
            var notitie = sender as Button;
            TextBlock textblock = new TextBlock();
            textblock.Text = $"{notitie.Tag}";
            textblock.Name = "notitie";
            List<string> list = new List<string>();
            list.Add("notitie");
            list.Add($"0,0");
            list.Add($"{notitie.Tag}");
            list.Add("n.v.t");
            list.Add("0");
            textblock.Tag = list;
            DragCavasPlattegrond.Children.Add(textblock);
            Canvas.SetTop(textblock, 10.0);
            Canvas.SetLeft(textblock, 100.00);
        }

        private void ButtonMuur_Check(object sender, RoutedEventArgs e)
        {
            muurCheck = true;
        }

        private void ButtonMuur_Uncheck(object sender, RoutedEventArgs e)
        {
            muurCheck = false;
        }

        public void DragCavasPlattegrond_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (muurCheck == true)
            {
                var dragCanvas = sender as DragCanvas;
                isDragging = true;
                clickPosition = e.GetPosition(dragCanvas);
            }
        }

        public void DragCavasPlattegrond_MouseMove(object sender, MouseEventArgs e)
        {
            var dragCanvas = sender as DragCanvas;
            if (muurCheck == true && isDragging == true)
            {
                currentPosition = e.GetPosition(dragCanvas);
            }
        }

        private void DragCavasPlattegrond_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (muurCheck == true)
            {
                var dragCanvas = sender as DragCanvas;
                isDragging = false;
                Line muur = new Line();
                muur.Stroke = System.Windows.Media.Brushes.Black;
                muur.StrokeThickness = 2;

                muur.X1 = clickPosition.X;
                muur.Y1 = clickPosition.Y;
                muur.X2 = currentPosition.X;
                muur.Y2 = currentPosition.Y;
                dragCanvas.Children.Add(muur);
                List<string> list = new List<string>();
                list.Add("muur");
                list.Add($"0,0");
                list.Add($"{muur.Tag}");
                list.Add("n.v.t");
                list.Add("0");
                muur.Tag = list;
                return;
            }
        }
        private void OnMenuItem_Bestellen_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult dialogResult = MessageBox.Show("Weet je zeker dat je wilt bestellen?", "Bestellen", MessageBoxButton.YesNo);
            if (dialogResult == MessageBoxResult.Yes)
            {
                Dictionary<string, List<string>> Gebruiktemeubels = new Dictionary<string, List<string>>();
                plattegrondview.LeegGebruikteMeubelLijst();
                Gebruiktemeubels = GetChilderenFromCanvas();
                foreach (var item in Gebruiktemeubels)
                {
                    plattegrondview.ToevoegenGebruikteMeubel(item.Key, Convert.ToInt32(item.Value[1]), Convert.ToDecimal(item.Value[0]), item.Value[2], item.Value[3]);

                }
                var LijstGebruikteMeubels = plattegrondview.GebruikteMeubelsLijst;
                plattegrondview.MakeBestelling(LijstGebruikteMeubels,PlattegrondNaam);
                MessageBox.Show("Bestelling is gemaakt", "Bestellen");
            }
            else if (dialogResult == MessageBoxResult.No)
            {

            }
            
        }

        private void OnMouseDownPressed(object sender, MouseButtonEventArgs e)
        {
            var dragCanvas = sender as DragCanvas;
            var mouseButton = e;
            if (dragCanvas != null)
            {
                if (mouseButton.ChangedButton.Equals(MouseButton.Middle))
                {

                    try
                    {
                        Image image = (Image)mouseButton.OriginalSource;
                        List<string> imageTag = (List<string>)image.Tag;
                        double rotatie = Convert.ToDouble(imageTag[4]);
                        if (rotatie == 360)
                        {
                            rotatie = 0;
                        }
                        rotatie = rotatie + 45;
                        RotateTransform rotateTransform1 = new RotateTransform(rotatie);
                        var x = image.ActualWidth / 2;
                        var y = image.ActualHeight / 2;
                        rotateTransform1.CenterX = x;
                        rotateTransform1.CenterY = y;
                        image.RenderTransform = rotateTransform1;
                        imageTag[4] = $"{rotatie}";
                        image.Tag = imageTag;
                    }
                    catch (Exception)
                    {

                        TextBlock textblock = (TextBlock)mouseButton.OriginalSource;
                        List<string> imageTag = (List<string>)textblock.Tag;
                        double rotatie = Convert.ToDouble(imageTag[4]);
                        if (rotatie == 360)
                        {
                            rotatie = 0;
                        }
                        rotatie = rotatie + 45;
                        RotateTransform rotateTransform1 = new RotateTransform(rotatie);
                        var x = textblock.ActualWidth / 2;
                        var y = textblock.ActualHeight / 2;
                        rotateTransform1.CenterX = x;
                        rotateTransform1.CenterY = y;
                        textblock.RenderTransform = rotateTransform1;
                        imageTag[4] = $"{rotatie}";
                        textblock.Tag = imageTag;
                    }
                    
                   
                }
            }
        }

       
    }
}
