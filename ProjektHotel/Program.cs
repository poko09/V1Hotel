﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ProjektHotel
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Klient klient1 = new Klient("Lucjan", "Nowak", "luceknowa.k@wp.com", "123456789", "1980-02-12", "12312345671",Klient.Tytul.Pan);
            Klient klient2 = new Klient("Jan", "Kowalski", "lucek.nowak@gmail.com", "234567898", "1970-12-11","00764876129", Klient.Tytul.Pan);
            Apartament apartament1 = new Apartament(Pokoj.Miejsce.DwaOs);
            PokojBasic basic1 = new PokojBasic(Pokoj.Miejsce.CzteryOs);
            PokojBasic basic2 = new PokojBasic(Pokoj.Miejsce.DwaOs);
            PokojPremium premium1 = new PokojPremium(Pokoj.Miejsce.JedenOs);
            //Console.WriteLine(apartament1.ToString());
            //Console.WriteLine(basic1.ToString());
            //Console.WriteLine(basic2.ToString());
            //Console.WriteLine(premium1.ToString());

            Rezerwacja rezerwacja1 = new Rezerwacja(new DateTime(2020, 12, 4), new DateTime(2020,12,6), premium1, klient1, Rezerwacja.FormaPłatności.Gotówka);
            Rezerwacja rezerwacja2 = new Rezerwacja(new DateTime(2020, 12, 4), new DateTime(2020, 12, 10), apartament1, klient2, Rezerwacja.FormaPłatności.Karta);

            ZarzadzanieRezerwacjami zarz1 = new ZarzadzanieRezerwacjami();
            zarz1.DodajKlienta(klient1);
            zarz1.DodajKlienta(klient2);

            zarz1.JestCzłonkiem("00764876129");


        }
    }
}
