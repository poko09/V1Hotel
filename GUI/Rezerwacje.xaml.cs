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
        Rezerwacja _rezerwacja;
        public Rezerwacje()
        {
            InitializeComponent();
            
        }

        public Rezerwacje(Rezerwacja rezerwacja) :this()
        {
            _rezerwacja = rezerwacja;
            datePickerDataZameldowania.Text = rezerwacja.DataZameldowania.ToString();
            datePickerDataWymeldowania.Text = rezerwacja.DataWymeldowania.ToString();
            cbFormaPlatnosci.Text = ((rezerwacja.FormaPłatności1) == Rezerwacja.FormaPłatności.Gotówka) ? "Gotówka" : "Karta";
        }

        private void ButtonClickDodaj(object sender, RoutedEventArgs e)
        {
            //tu powinnam dodac ify jesli jest cos puste
            _rezerwacja.DataZameldowania = (DateTime)datePickerDataZameldowania.SelectedDate;
            _rezerwacja.DataWymeldowania = (DateTime)datePickerDataWymeldowania.SelectedDate;
            _rezerwacja.FormaPłatności1 = (cbFormaPlatnosci.Text == "Gotówka") ? Rezerwacja.FormaPłatności.Gotówka : Rezerwacja.FormaPłatności.Karta;
        }
    }
}
