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
        // List<Pokoj> listaPokoi = new List<Pokoj>();

        public Pokoje(ZarzadzanieRezerwacjami zarz)
        {
            InitializeComponent();
            if (zarzadzanie != null)
            {
                zarzadzanie = zarz;
                lbListaPokoi.ItemsSource = zarzadzanie.Pokoje;// listaPokoi;

            }
        }
        public void WyczyscWszystkiePola()
        {
            cmbRodzajPokoju.SelectedIndex = -1;
            cmbLiczbaMiejsc.SelectedIndex = -1;
            tbNumerPokoju.Clear();
        }
        private void buttonDodajPokoj_Click(object sender, RoutedEventArgs e)
        {
            if (cmbLiczbaMiejsc.SelectedIndex == -1 || cmbRodzajPokoju.SelectedIndex == -1)
            {
                MessageBox.Show("Musisz wybrać rodzaj pokoju oraz liczbę miejsc.");
            }
            else
            {
                Pokoj.Miejsce miejsce = (cmbLiczbaMiejsc.Text == "1-osobowy") ? Pokoj.Miejsce.JedenOs : (cmbLiczbaMiejsc.Text == "2-osobowy") ?
                    Pokoj.Miejsce.DwaOs : (cmbLiczbaMiejsc.Text == "3-osobowy") ? Pokoj.Miejsce.TrzyOs : Pokoj.Miejsce.CzteryOs;

                if (cmbRodzajPokoju.Text == "Apartament")
                {
                    int numerPokoju;
                    int.TryParse(tbNumerPokoju.Text, out numerPokoju);
                    Apartament apartament = new Apartament(miejsce, numerPokoju);
                    // listaPokoi.Add(apartament);
                    zarzadzanie.DodajPokoj(apartament);
                    lbListaPokoi.Items.Refresh();

                }
                else if (cmbRodzajPokoju.Text == "Pokój Premium")
                {
                    PokojPremium premium = new PokojPremium(miejsce);
                    // listaPokoi.Add(premium);
                    zarzadzanie.DodajPokoj(premium);
                    lbListaPokoi.Items.Refresh();
                }
                else //if (cmbRodzajPokoju.Text == "Pokój Basic")
                {
                    PokojBasic basic = new PokojBasic(miejsce);
                    //listaPokoi.Add(basic);
                    zarzadzanie.DodajPokoj(basic);
                    lbListaPokoi.Items.Refresh();
                }
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
                //listaPokoi.RemoveAt(zaznaczonyPokoj);
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

            /*
            int zaznaczonyPokoj = lbListaPokoi.SelectedIndex;
            if (zaznaczonyPokoj < 0) {
                MessageBox.Show("Nie zaznaczyłeś/aś pokoju do zedytowania.");
            }
            else{
                Pokoj.Miejsce miejsce = (cmbLiczbaMiejsc.Text == "1-osobowy") ? Pokoj.Miejsce.JedenOs : (cmbLiczbaMiejsc.Text == "2-osobowy") ?
                Pokoj.Miejsce.DwaOs : (cmbLiczbaMiejsc.Text == "3-osobowy") ? Pokoj.Miejsce.TrzyOs : Pokoj.Miejsce.CzteryOs;
                Pokoj pokoj;
                if (cmbRodzajPokoju.Text == "Apartament")
                {
                    pokoj = new Apartament(miejsce);

                }
                else if (cmbRodzajPokoju.Text == "Pokój Premium")
                {
                    pokoj = new PokojPremium(miejsce);
                }
                else 
                {
                    pokoj = new PokojBasic(miejsce);
                }
                listaPokoi[zaznaczonyPokoj] = pokoj;
                lista[zaznaczonyPokoj] = pokoj;
                lbListaPokoi.ItemsSource = lista;
            }*/
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
