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
    /// Interaction logic for InstructiesScherm.xaml
    /// </summary>
    public partial class InstructiesScherm : Window
    {
        string Instructies = "Dubbel klik op een meubel in de lijst met meubels om de meubel op de plattegrond te krijgen.\n" +
                             "Rechtermuisklik om een meubel, tekst, raam, deur of muur om het van de plattegrond te verwijderen.\n" +
                             "Klik met de middelste muisknop op een meubel, deur, raam of tekst om het te draaien.\n" +
                             "Klik op de muur knop om het plaatsen van muren te kunnen doen.\n" +
                             "Plaats een muur door op de plattegrond de linker muis knop ingedrukt te houden en naar een ander punt te bewegen.\n" +
                             "Hou de linker muis knop ingedrukt op een meubel, raam, deur of tekst en beweeg de muis om het te kunnen verplaatsen." +
                             "Druk op de deur knop om een deur op de plattegrond te krijgen.\n" +
                             "Druk op de raam knop om een raam op de plattegrond te krijgen.\n" +
                             "Druk op de notitie knop om een notitie op de plattegrond te krijgen.\n"+
                             "Open een plattegrond door in het opgeslagen plattegronden scherm een plattegrond te selecteren en er dan dubbel op te klikken.\n"+
                             "Verwijder een plattegrond door in het opgeslagen plattegrond scherm een plattegrond te selecteren en er dan met de rechtermuisknop op te kliken.";
                            
        public InstructiesScherm()
        {
            InitializeComponent();
            TBInstructies.Text = Instructies;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
