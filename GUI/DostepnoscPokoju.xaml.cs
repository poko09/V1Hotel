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
    /// Logika interakcji dla klasy DostepnoscPokoju.xaml
    /// </summary>
    public partial class DostepnoscPokoju : Window
    {

        ZarzadzanieRezerwacjami zarzadzanie = new ZarzadzanieRezerwacjami();
        Pokoj pokoj;
        public DostepnoscPokoju(Pokoj pokoj, ZarzadzanieRezerwacjami zarz)
        {
            InitializeComponent();
            this.zarzadzanie = zarz;
            this.pokoj = pokoj;
        }


        private void buttonWroc_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonWyczysc_Click(object sender, RoutedEventArgs e)
        {
            dpDataPoczatkowa.SelectedDate = null;
            dpDataKoncowa.SelectedDate = null;

        }
        private void buttonSprawdz_Click(object sender, RoutedEventArgs e)
        {
            DateTime dataPoczatkowa = (DateTime)dpDataPoczatkowa.SelectedDate;
            DateTime dataKoncowa = (DateTime)dpDataKoncowa.SelectedDate;
            //            zarzadzanie.SprawdzDostepnoscWTerminie(apartament1, new DateTime(2020,01,27), new DateTime(2020,01,29))
            if (zarzadzanie.CzyDostepnyWTerminie(pokoj, dataPoczatkowa, dataKoncowa))
            {
                MessageBox.Show("Pokój jest dostępny w wybranym terminie.");
            }
            else
            {
                MessageBox.Show("Pokój nie jest dostępny w wybranym terminie");
            }
        }
    }
}