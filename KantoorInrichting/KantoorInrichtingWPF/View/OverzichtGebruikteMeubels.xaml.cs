﻿using KantoorInrichtingWPF.Model;
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
    /// Interaction logic for OverzichtGebruikteMeubels.xaml
    /// </summary>
    public partial class OverzichtGebruikteMeubels : Window
    {
        public OverzichtGebruikteMeubels()
        {
            InitializeComponent();
           
        }

        private void ButtonTerug_Click(object sender, RoutedEventArgs e)
        {
            
            this.Close();
        }
    }
}
