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
    /// Interaction logic for OpslaanPlattegrond.xaml
    /// </summary>
    public partial class OpslaanPlattegrond : Window
    {
        public OpslaanPlattegrond()
        {
            InitializeComponent();
        }

        private void OnAnnulerenButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void OnOpslaanButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
