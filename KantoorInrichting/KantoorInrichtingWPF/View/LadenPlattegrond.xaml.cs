using KantoorInrichtingWPF.ViewModel;
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

namespace KantoorInrichtingWPF.View
{
    /// <summary>
    /// Interaction logic for LadenPlategrond.xaml
    /// </summary>
    public partial class LadenPlategrond : Window
    {
        PlattegrondViewModel plattegrondViewModel = new PlattegrondViewModel();
        public LadenPlategrond()
        {
            InitializeComponent();
        }

        private void ButtonTerug_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ButtonZoekenPlattegrondNaam_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonZoekenProjectNaam_Click(object sender, RoutedEventArgs e)
        {

        }

        private void OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var dataGrid = sender as DataGrid;
            if (dataGrid != null)
            {
                /*
                ProjectNaam;
                PlattegrondNaam;
                Lengte;
                Breedte;
                Hoogte;
                Plattegrondcode;
                */
                var index = dataGrid.SelectedIndex;
                MainWindow mainWindow = new MainWindow();
                mainWindow.ProjectNaam = plattegrondViewModel.PlattegrondLijst[index].ProjectNaam;
                mainWindow.PlattegrondNaam = plattegrondViewModel.PlattegrondLijst[index].PlattegrondNaam;
                mainWindow.Plattegrondcode = plattegrondViewModel.PlattegrondLijst[index].Plattegrondcode;
                mainWindow.Lengte = plattegrondViewModel.PlattegrondLijst[index].Lengte;
                mainWindow.Breedte = plattegrondViewModel.PlattegrondLijst[index].Breedte;
                mainWindow.Hoogte = plattegrondViewModel.PlattegrondLijst[index].Hoogte;
                mainWindow.Show();
                mainWindow.LadenMap( plattegrondViewModel.PlattegrondLijst[index].Canvas);
                this.Close();

            }
        }

        private void OnMouseRightButtonPressed(object sender, MouseButtonEventArgs e)
        {
            var dataGrid = sender as DataGrid;
            if (dataGrid != null)
            {
                var index = dataGrid.SelectedIndex;
                
               MessageBoxResult dialogResult = MessageBox.Show($"Weet je zeker dat je deze plattegrond({plattegrondViewModel.PlattegrondLijst[index].PlattegrondNaam}) wilt verwijderen?", "Plattegrond verwijderen", MessageBoxButton.YesNo);
                if (dialogResult == MessageBoxResult.Yes)
                {
                    plattegrondViewModel.VerwijderenPlattegrond(plattegrondViewModel.PlattegrondLijst[index].Plattegrondcode);
                    var btn = ButoonRefresh;
                    btn.Command.Execute(btn.CommandParameter);
                }
                else if (dialogResult == MessageBoxResult.No)
                {

                }

            }
            
             plattegrondViewModel.UpdatePlattegrondenLijstExecute();
        }

        
    }
}
