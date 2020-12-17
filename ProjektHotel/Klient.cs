using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Diagnostics.CodeAnalysis;

namespace ProjektHotel
{

    class Klient :IEquatable<Klient>, IComparable<Klient>
    {
        public enum Tytul { Pani, Pan };
        ulong id = 0;
        string imie;
        string nazwisko;
        string email;
        string telefon;
        DateTime dataUrodzenia;
        string pesel;
        Tytul tytul;

        public static ulong bieżącyNumerKlienta = 0;


        public Klient(string imie, string nazwisko, string email, string telefon, string dataUrodzenia, string pesel, Tytul tytul)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Email = email;
            Telefon = telefon;
            DateTime.TryParse(dataUrodzenia, out this.dataUrodzenia);
            this.Pesel = pesel;
            this.tytul = tytul;
            this.id = ++bieżącyNumerKlienta;
        }

        public ulong Id { get => id; set => id = value; }
        public string Imie
        {
            get { return imie; }
            set
            {
                Regex wzor = new Regex("^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$");
                if (wzor.IsMatch(value))
                {
                    imie = value;
                }
                else
                {
                    throw new Exception("blad");
                }
            }
        }
        public string Nazwisko
        {
            get { return nazwisko; }
            set
            {
                Regex wzor = new Regex("^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$");
                if (wzor.IsMatch(value))
                {
                    nazwisko = value;
                }
                else
                {
                    throw new Exception("blad");
                }
            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                Regex wzor = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                if (wzor.IsMatch(value))
                {
                    email = value;
                }
                else
                {
                    throw new Exception("blad");
                }
            }
        }
        public string Telefon
        {
            get { return telefon; }
            set
            {
                Regex wzor = new Regex("^[0-9]{9}$");
                if (wzor.IsMatch(value))
                {
                    telefon = value;
                }
                else
                {
                    throw new Exception("blad");

                }
            }
        }


        public DateTime DataUrodzenia //*BLAD* Naprawic blad z DATETIME data urodzenia
        {
            get { return dataUrodzenia; }
            set
            {
                Regex wzor = new Regex("{0:d/M/yyyy HH:mm:ss}");
                if (wzor.IsMatch(Convert.ToDateTime(value).ToString()))
                {
                    dataUrodzenia = value;
                }
                else
                {
                    throw new Exception("blad");
                }
            }
        }

        public string Pesel
        {
            get => pesel;
            set
            {
                Regex wzorzec = new Regex("^\\d{11}$");
                if (wzorzec.IsMatch(value))
                {
                    pesel = value;
                }
                else
                {
                    throw new Exception("bledny pesel");
                }
            }
        }

        public int Wiek()
        {
            return (int)DateTime.Today.Year - dataUrodzenia.Year;
        }

        public override string ToString()
        {
            return "Klient " + this.id + "\nImie " + imie + " nazwisko " + nazwisko + " email " + email + " " + telefon + " data urodzenia " + dataUrodzenia + " pesel " + pesel + " Tytuł " + tytul;
        }

        public bool Equals(Klient other)
        {
            return this.Pesel == other.Pesel;
        }

        public int CompareTo(Klient other)
        {
            if (this.Nazwisko != other.Nazwisko)
                return this.Nazwisko.CompareTo(other.Nazwisko);
            else
                return this.Imie.CompareTo(other.Imie);
        }
    }
}
