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
            if (zarz != null)
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
                Klient nowyKlient = cbKlient.SelectedValue as Klient;
                Pokoj nowyPokoj = cbPokoj.SelectedValue as Pokoj;
                DateTime nowaDataZameldowania = (DateTime)datePickerDataZameldowania.SelectedDate;
                DateTime nowaDataWymeldowania = (DateTime)datePickerDataWymeldowania.SelectedDate;
                Rezerwacja.FormaPłatności nowaForma = (cbFormaPlatnosci.Text == "Gotówka") ? Rezerwacja.FormaPłatności.Gotówka : Rezerwacja.FormaPłatności.Karta;
                Rezerwacja nowaRezerwacja = new Rezerwacja(nowaDataZameldowania, nowaDataWymeldowania, nowyPokoj, nowyKlient, nowaForma);
                if (zarzadzanie.CzyDostepnyWTerminie(nowyPokoj, nowaDataZameldowania, nowaDataWymeldowania))
                {
                    zarzadzanie.DodajRezerwacje(nowaRezerwacja);
                }
                else
                {
                    MessageBox.Show("Wybrany pokój nie jest dostępny w tym terminie, wybierz inny pokój");
                }
                lbRezerwacje.Items.Refresh();
                WyczyscWszystkiePola();
            }
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
            else
            {
                MessageBox.Show("Zaznacz rezerwację do usunięcia");
            }
        }
    }
}
