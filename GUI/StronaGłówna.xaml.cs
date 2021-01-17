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
    /// Logika interakcji dla klasy StronaGłówna.xaml
    /// </summary>
    public partial class StronaGłówna : Window
    {
        ZarzadzanieRezerwacjami zarzadzanie = new ZarzadzanieRezerwacjami();
        //ObservableCollection<Pokoj> listaPokoi;
        public StronaGłówna()
        {
            InitializeComponent();
            zarzadzanie = ZarzadzanieRezerwacjami.OdczytajXML("zarzadzanie.xml");
        }

        private void buttonPokoje_Click(object sender, RoutedEventArgs e)
        {
            Pokoje okno = new Pokoje(zarzadzanie);
            okno.ShowDialog();
            this.Hide();
        }

        private void buttonRezerwacje_Click(object sender, RoutedEventArgs e)
        {
            Rezerwacje okno = new Rezerwacje(zarzadzanie);
            okno.ShowDialog();
            this.Hide();
        }

        private void buttonKlienci_Click(object sender, RoutedEventArgs e)
        {
            Klienci okno = new Klienci(zarzadzanie);
            okno.ShowDialog();
            this.Hide();
        }
    }
}