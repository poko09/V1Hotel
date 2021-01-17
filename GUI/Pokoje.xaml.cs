using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Logika interakcji dla klasy Pokoje.xaml
    /// </summary>
    public partial class Pokoje : Window
    {
        ZarzadzanieRezerwacjami zarzadzanie = new ZarzadzanieRezerwacjami();

        public Pokoje(ZarzadzanieRezerwacjami zarz)
        {
            InitializeComponent();
            if (zarz != null)
            {
                zarzadzanie = zarz;
                lbListaPokoi.ItemsSource = zarzadzanie.Pokoje;

            }
        }
        public void WyczyscWszystkiePola()
        {
            cmbRodzajPokoju.SelectedIndex = -1;
            cmbLiczbaMiejsc.SelectedIndex = -1;
            tbNumerPokoju.Clear();
        }
        // TUTAJ 
        private void buttonDodajPokoj_Click(object sender, RoutedEventArgs e)
        {
            if (cmbLiczbaMiejsc.SelectedIndex == -1 || cmbRodzajPokoju.SelectedIndex == -1 || tbNumerPokoju.Text == "")
            {
                MessageBox.Show("Musisz wybrać rodzaj pokoju, numer pokoju oraz liczbę miejsc.");
            }
            else
            {
                Pokoj.Miejsce miejsce = (cmbLiczbaMiejsc.Text == "1-osobowy") ? Pokoj.Miejsce.JedenOs : (cmbLiczbaMiejsc.Text == "2-osobowy") ?
                Pokoj.Miejsce.DwaOs : (cmbLiczbaMiejsc.Text == "3-osobowy") ? Pokoj.Miejsce.TrzyOs : Pokoj.Miejsce.CzteryOs;
                int numerPokoju;
                int.TryParse(tbNumerPokoju.Text, out numerPokoju);
                Pokoj pokoj;
                if (cmbRodzajPokoju.Text == "Apartament")
                {
                    pokoj = new Apartament(miejsce, numerPokoju);
                }
                else if (cmbRodzajPokoju.Text == "Pokój Premium")
                {
                    pokoj = new PokojPremium(miejsce, numerPokoju);
                }
                else
                {
                    pokoj = new PokojBasic(miejsce, numerPokoju);
                }

                if (zarzadzanie.CzyNumerPokojuIstnieje(pokoj))
                {
                    MessageBox.Show("Pokoj o podanym numerze juz istnieje.");
                }
                else { zarzadzanie.DodajPokoj(pokoj); }

                /*if (cmbRodzajPokoju.Text == "Apartament")
                {
                    Apartament apartament = new Apartament(miejsce, numerPokoju);
                    if (zarzadzanie.CzyNumerPokojuIstnieje(apartament)){
                        MessageBox.Show("Pokoj o podanym numerze juz istnieje.");
                    }
                    else { zarzadzanie.DodajPokoj(apartament); }

                }
                else if (cmbRodzajPokoju.Text == "Pokój Premium")
                {
                    PokojPremium premium = new PokojPremium(miejsce, numerPokoju);
                    if (zarzadzanie.CzyNumerPokojuIstnieje(premium))
                    {
                        MessageBox.Show("Pokoj o podanym numerze juz istnieje.");
                    }
                    else   { zarzadzanie.DodajPokoj(premium); }
                }
                else 
                {
                    PokojBasic basic = new PokojBasic(miejsce, numerPokoju);
                    if (zarzadzanie.CzyNumerPokojuIstnieje(basic))
                    {
                        MessageBox.Show("Pokoj o podanym numerze juz istnieje.");
                    }
                    else
                    { zarzadzanie.DodajPokoj(basic); }
                }*/
                lbListaPokoi.Items.Refresh();
                WyczyscWszystkiePola();
            }
        }
        private void buttonWyczysc_Click(object sender, RoutedEventArgs e)
        {
            WyczyscWszystkiePola();
        }

        private void buttonUsunPokoj_Click(object sender, RoutedEventArgs e)
        {
            int index = lbListaPokoi.SelectedIndex;
            if (index >= 0)
            {
                zarzadzanie.Pokoje.RemoveAt(index);
                lbListaPokoi.Items.Refresh();
            }
        }

        private void buttonEdytuj_Click(object sender, RoutedEventArgs e)
        {
            int index = lbListaPokoi.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Nie zaznaczyłeś/aś pokoju do zedytowania.");
            }
            if (cmbLiczbaMiejsc.SelectedIndex == -1)
            {
                MessageBox.Show("Podaj liczbę miejsc w pokoju.");
            }
            else
            {
                Pokoj.Miejsce miejsce = (cmbLiczbaMiejsc.Text == "1-osobowy") ? Pokoj.Miejsce.JedenOs : (cmbLiczbaMiejsc.Text == "2-osobowy") ?
                    Pokoj.Miejsce.DwaOs : (cmbLiczbaMiejsc.Text == "3-osobowy") ? Pokoj.Miejsce.TrzyOs : Pokoj.Miejsce.CzteryOs;
                zarzadzanie.Pokoje[index].Miejsce1 = miejsce;
                lbListaPokoi.Items.Refresh();
                WyczyscWszystkiePola();
            }
        }

        private void buttonSprawdzDostepnosc_Click(object sender, RoutedEventArgs e)
        {
            int index = lbListaPokoi.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("Nie zaznaczono pokoju z listy.");
            }
            else
            {
                DostepnoscPokoju okno = new DostepnoscPokoju(zarzadzanie.Pokoje[index], zarzadzanie);
                okno.ShowDialog();
            }
        }
    }
}
