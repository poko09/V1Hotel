using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektHotel
{
    //kjhfbjdfb
    class ZarzadzanieRezerwacjami
    {
        List<Klient> klienci;
        int liczbaKlientow;

        public List<Klient> Klienci { get => klienci; set => klienci = value; }
        public int LiczbaKlientow { get => liczbaKlientow; set => liczbaKlientow = value; }

        public ZarzadzanieRezerwacjami()
        {
            klienci = new List<Klient>();
            liczbaKlientow = 0;
        }

        public void DodajKlienta(Klient klient)
        {
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

        public bool JestCzłonkiem(string pesel)
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



        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(Klient klient in klienci)
            {
                sb.AppendLine(klient.ToString());
            }
            return sb.ToString();
        }
    }
}
