
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

namespace KantoorInrichtingWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private decimal _totalprijst=(decimal)0.0;
        MeubelViewModel meubelView = new MeubelViewModel();
    
        public MainWindow()
        {
            InitializeComponent();
            LabelTotalPrijs.Content = $"{_totalprijst}€";
            


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
                _totalprijst = _totalprijst + meubelView.Catalogus[index].prijs;
                LabelTotalPrijs.Content = $"{_totalprijst}€";
                
                AddImage(meubelView.Catalogus[index].tag,index);


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
                   
                    _totalprijst = _totalprijst - (decimal)imageOutCanvas.Tag;
                    LabelTotalPrijs.Content = $"{_totalprijst}€";
                    dragCanvas.Children.Remove((UIElement)image);
                }
                else if (dialogResult == MessageBoxResult.No)
                {

                }
            }

        }
        public void AddImage(string typeImage,int index)
        {

            if (typeImage.Equals("tafel"))
            {
                Image image = new Image();
                BitmapImage bi = new BitmapImage();
                // BitmapImage.UriSource must be in a BeginInit/EndInit block.
                bi.BeginInit();
                bi.UriSource = new Uri(@"/Afbeelding/tafel.png", UriKind.RelativeOrAbsolute);
                bi.EndInit();
                image.Source = bi;
                image.Tag = meubelView.Catalogus[index].prijs;
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
                image.Source = bi;
                image.Tag = meubelView.Catalogus[index].prijs;
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
                image.Source = bi;
                image.Tag = meubelView.Catalogus[index].prijs;
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
                image.Source = bi;
                image.Tag = meubelView.Catalogus[index].prijs;
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
                image.Source = bi;
                image.Tag = meubelView.Catalogus[index].prijs;
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
                image.Source = bi;
                image.Tag = meubelView.Catalogus[index].prijs;
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
                image.Source = bi;
                image.Tag = meubelView.Catalogus[index].prijs;
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
                image.Source = bi;
                image.Tag = meubelView.Catalogus[index].prijs;
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
                image.Source = bi;
                image.Tag = meubelView.Catalogus[index].prijs;
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
            
            
            
            
        }

        private void OnButton_RefreshMeubel_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void OnButton_ZoekenMeubelCategorie_Click(object sender, RoutedEventArgs e)
        {
            

            

        }

        

       
    }
}
