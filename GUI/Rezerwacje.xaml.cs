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
using ProjektHotel;

namespace GUI
{
    /// <summary>
    /// Logika interakcji dla klasy Rezerwacje.xaml
    /// </summary>
    public partial class Rezerwacje : Window
    {
        ZarzadzanieRezerwacjami zarzadzanie = new ZarzadzanieRezerwacjami();
        public Rezerwacje(ZarzadzanieRezerwacjami zarz)
        {
            InitializeComponent();
            if (zarzadzanie != null)
            {
                zarzadzanie = zarz;
                lbRezerwacje.ItemsSource = zarzadzanie.Rezerwacje;
                for (int i = 0; i < zarzadzanie.Pokoje.Count; i++)
                {
                    cbPokoj.Items.Add(zarzadzanie.Pokoje[i]);
                }
                for (int i = 0; i < zarzadzanie.LiczbaKlientow; i++)
                {
                    cbKlient.Items.Add(zarzadzanie.Klienci[i]);
                }


            }


        }
        private void WyczyscWszystkiePola()
        {
            cbFormaPlatnosci.SelectedIndex = -1;
            cbKlient.SelectedIndex = -1;
            cbPokoj.SelectedIndex = -1;
            datePickerDataZameldowania.SelectedDate = null;
            datePickerDataWymeldowania.SelectedDate = null;
        }

        private void ButtonClickDodaj(object sender, RoutedEventArgs e)
        {
            if (cbFormaPlatnosci.SelectedIndex == -1 || cbKlient.SelectedIndex == -1 || cbPokoj.SelectedIndex == -1 || datePickerDataZameldowania.SelectedDate == null || datePickerDataWymeldowania.SelectedDate == null)
            {
                MessageBox.Show("Nie wypełniłes wszystkich pól!");
            }
            else
            {
                Rezerwacja nowaRezerwacja = new Rezerwacja();
                //najpierw stworz zmienne i potem przekaz w konstruktorze !!!!, patrz na Wiole
                //Rezerwacja nowaRezerwacja = new Rezerwacja((DateTime)datePickerDataZameldowania.SelectedDate,(DateTime)datePickerDataWymeldowania.SelectedDate,
                //cbPokoj.SelectedItem as Pokoj, cbKlient.SelectedItem as Klient, cbFormaPlatnosci.SelectedItem as enum);
                nowaRezerwacja.Klient = cbKlient.SelectedValue as Klient;
                nowaRezerwacja.Pokoj = cbPokoj.SelectedValue as Pokoj;
                nowaRezerwacja.DataZameldowania = (DateTime)datePickerDataZameldowania.SelectedDate;
                nowaRezerwacja.DataWymeldowania = (DateTime)datePickerDataWymeldowania.SelectedDate;
                nowaRezerwacja.FormaPłatności1 = (cbFormaPlatnosci.Text == "Gotówka") ? Rezerwacja.FormaPłatności.Gotówka : Rezerwacja.FormaPłatności.Karta;
                nowaRezerwacja.Koszt = nowaRezerwacja.Pokoj.Cena * nowaRezerwacja.IleDni(nowaRezerwacja.DataZameldowania, nowaRezerwacja.DataWymeldowania);
                nowaRezerwacja.NrRezerwacji = Rezerwacja.bieżącyNumerRezerwacji++;
                zarzadzanie.DodajRezerwacje(nowaRezerwacja);
                lbRezerwacje.Items.Refresh();
                WyczyscWszystkiePola();
            }
            // _rezerwacja.DataZameldowania = (DateTime)datePickerDataZameldowania.SelectedDate;
            //_rezerwacja.DataWymeldowania = (DateTime)datePickerDataWymeldowania.SelectedDate;
            //_rezerwacja.FormaPłatności1 = (cbFormaPlatnosci.Text == "Gotówka") ? Rezerwacja.FormaPłatności.Gotówka : Rezerwacja.FormaPłatności.Karta;
            //funkcja z dodawaniem czlonka
        }

        private void ButtonClickWyczysc(object sender, RoutedEventArgs e)
        {
            WyczyscWszystkiePola();
        }

        private void ButtonUsun(object sender, RoutedEventArgs e)
        {
            int index = lbRezerwacje.SelectedIndex;
            if (index >= 0)
            {
                zarzadzanie.Rezerwacje.RemoveAt(index);
                lbRezerwacje.Items.Refresh();
            }
        }

        private void ButtonZedytuj(object sender, RoutedEventArgs e)
        {

        }
    }
}

