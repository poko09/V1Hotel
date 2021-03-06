﻿using ProjektHotel;
using System;
using System.Windows;
namespace GUI
{

    /// <summary>
    /// Logika interakcji dla klasy Klienci.xaml
    /// </summary>
    public partial class Klienci : Window
    {
        ZarzadzanieRezerwacjami zarzadzanie = new ZarzadzanieRezerwacjami();
        uint klientowLiczba;

        public Klienci(ZarzadzanieRezerwacjami zarz)
        {
            
            InitializeComponent();
            if (zarz != null)
            {
                zarzadzanie = zarz;
                klientowLiczba = (uint)zarzadzanie.LiczbaKlientow +1;
                lbKlienci.ItemsSource = zarzadzanie.Klienci;
            }
        }

        private void bDodaj_Click(object sender, RoutedEventArgs e)
        {
            string imie = tbImie.Text;
            string nazwisko = tbNazwisko.Text;
            string email = tbEmail.Text;
            string telefon = tbTelefon.Text;
            string pesel = tbPesel.Text;
            DateTime data = (DateTime)dpDataUr.SelectedDate;
            Klient.Tytul tytul = (cmbTytul.Text == "Pan") ? Klient.Tytul.Pan : Klient.Tytul.Pani;            
            Klient klienci = new Klient(imie, nazwisko, email, telefon, pesel, data, tytul, klientowLiczba);
            zarzadzanie.DodajKlienta(klienci);
            klientowLiczba++;
            lbKlienci.Items.Refresh();
        }
        public void WyczyscWszystkiePola()
        {
            cmbTytul.SelectedIndex = -1;
            dpDataUr.SelectedDate = DateTime.Now;
            tbImie.Clear();
            tbNazwisko.Clear();
            tbEmail.Clear();
            tbPesel.Clear();
        }

        private void bWyczysc_Click(object sender, RoutedEventArgs e)
        {
            WyczyscWszystkiePola();
        }
    }
}