﻿using System;
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
using ProjektHotel;


namespace GUI
{
    /// <summary>
    /// Logika interakcji dla klasy StronaGłówna.xaml
    /// </summary>
    public partial class StronaGłówna : Window
    {
        ZarzadzanieRezerwacjami zarzadzanie = new ZarzadzanieRezerwacjami();
        public StronaGłówna()
        {
            InitializeComponent();
            zarzadzanie = ZarzadzanieRezerwacjami.OdczytajXML("zarzadzanie.xml");
        }

        private void buttonCLickRezerwacje(object sender, RoutedEventArgs e)
        {
            Rezerwacje okno = new Rezerwacje(zarzadzanie);
            okno.ShowDialog();
            this.Hide();
        }
    }
}
