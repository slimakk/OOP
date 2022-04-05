﻿using System;
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

namespace CV09
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Calculator calc = new Calculator();
        public MainWindow()
        {
            InitializeComponent();
            display.Text = calc.Display;
            pamat.Text = calc.Pamet;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            calc.Tlacitko((sender as Button).Content.ToString());
            display.Text = calc.Display;
            pamat.Text = calc.Pamet;
        }
    }
}
