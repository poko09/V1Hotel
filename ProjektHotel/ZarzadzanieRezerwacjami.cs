using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektHotel
{
    class ZarzadzanieRezerwacjami
    {
        List<Rezerwacja> rezerwacje;
        List<Klient> klienci;
        int liczbaKlientow;

        public List<Klient> Klienci { get => klienci; set => klienci = value; }
        public int LiczbaKlientow { get => liczbaKlientow; set => liczbaKlientow = value; }
        internal List<Rezerwacja> Rezerwacje { get => rezerwacje; set => rezerwacje = value; }

        public ZarzadzanieRezerwacjami()
        {
            this.Rezerwacje = new List<Rezerwacja>();
            klienci = new List<Klient>();
            liczbaKlientow = 0;
        }

        public void DodajKlienta(Klient klient)
        {
            foreach (Klient klient1 in klienci)
            {
                if (klient1.Equals(klient))
                {
                    throw new Exception("Klient jest juz w bazie");
                }
                
            }
            this.klienci.Add(klient);
            liczbaKlientow++;
        }

        public void UsunKlienta(string pesel)
        {
            foreach (Klient klient in klienci)
            {
                if (klient.Pesel == pesel)
                {
                    klienci.Remove(klient);
                    liczbaKlientow--;
                    break;
                }
            }
        }

        /* to chyba mozna zakomentowac bo jest interfejs
        public bool JestKlientem(string pesel)
        {
            int wynik = 0;
            foreach (Klient klient in klienci)
            {
                if (klient.Pesel == pesel)
                {
                    wynik++;
                }
            }
            if (wynik == 1)
            {
                Console.WriteLine("jest");
                return true;
            }
            else
            {
                Console.WriteLine("nie jest");
                return false;
            }
        }
        */

        public void DodajRezerwacje(Rezerwacja rezerwacja)
        {
            if (Rezerwacje.Exists(x => x.NrRezerwacji == rezerwacja.NrRezerwacji))
            {
                throw new Exception("Rezerwacja o podanym numerze już istenieje.");
            }
            else if (Rezerwacje.Exists(x => (x.Pokoj == rezerwacja.Pokoj
             && !(x.DataZameldowania >= rezerwacja.DataWymeldowania || x.DataWymeldowania <= rezerwacja.DataZameldowania))))
            {
                throw new Exception("Pokoj jest juz zarezerwowany w danym terminie.");
            }
            else { Rezerwacje.Add(rezerwacja); }
        }

        public void UsunRezerwacje(uint numerRezerwacji)
        {
            Rezerwacje.RemoveAll(x => x.NrRezerwacji == numerRezerwacji);
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder("HOTEL \n");
            stringBuilder.AppendLine("Klienci: ");
            foreach (Klient klient in klienci)
            {
                stringBuilder.AppendLine(klient.ToString());
            }
            stringBuilder.AppendLine("Rezerwacje: ");
            foreach (Rezerwacja rezerwacja in Rezerwacje)
            {
                stringBuilder.AppendLine(rezerwacja.ToString());
            }
            return stringBuilder.ToString();
        }

        public void SortujKlientow()
        {
            klienci.Sort();
        }
        ///// TERAZ KAROL ROBI COS W SWOJEJ BRANCHY 
        /////ASDASDAS
        ///
    }
}