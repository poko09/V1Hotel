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
using ProjektHotel;

namespace GUI
{
    //ZarzadzanieRezerwacjami zarz = new ProjektHotel.ZarzadzanieRezerwacjami();
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonZaloguj_Click(object sender, RoutedEventArgs e)
        {
            new StronaGłówna().Show();
            this.Hide();
            /*if (textBoxLogin.Text == "hotel" && passwordBoxHasło.Password == "zarzadzanie")
            {
                new StronaGłówna().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Błędne hasło lub login");
                textBoxLogin.Clear();
                passwordBoxHasło.Clear();
                textBoxLogin.Focus();
            }*/
        }
    }
}
