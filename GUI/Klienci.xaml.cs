using ProjektHotel;
using System.Windows;
namespace GUI
{

    /// <summary>
    /// Logika interakcji dla klasy Klienci.xaml
    /// </summary>
    public partial class Klienci : Window
    {
        Klient _osoba;
        public Klienci()
        {
            InitializeComponent();
        }

        private void bDodaj_Click(object sender, RoutedEventArgs e)
        {
            string imie = tbImie.Text;
            string nazwisko = tbNazwisko.Text;
            string email = tbEmail.Text;
        }
        public Klienci(Klient osoba) : this()
        {
            _osoba = osoba;
            if (_osoba is Klient)
            {
                tbImie.Text = osoba.Imie;
                tbNazwisko.Text = osoba.Nazwisko;
                tbEmail.Text = osoba.Email;
                tbTelefon.Text = osoba.Telefon;
                tbPesel.Text = osoba.Pesel;
               // ZAPYTAJ O DATE URODZENIA?????????
                cmbTytul.Text = ((osoba.Tytul1) == Klient.Tytul.Pani) ? "Pani" : "Pan";
            }
        }

        private void ComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}
