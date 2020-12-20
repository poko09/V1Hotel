using System;
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
            Klient klient1 = new Klient("Lucjan", "Nowak", "luceknowa.k@wp.com", "123456789", "1980-02-12","80021213344", Klient.Tytul.Pan);
            Klient klient2 = new Klient("Jan", "Kowalski", "lucek.nowak@gmail.com", "234567898", "1970-12-11", "70121112345", Klient.Tytul.Pan);
            Klient klient3 = new Klient("Jan", "Kowal", "lucek.nowak@gmail.com", "234567898", "1970-12-11", "70121112345", Klient.Tytul.Pan);
            Apartament apartament1 = new Apartament(Pokoj.Miejsce.DwaOs);
            PokojBasic basic1 = new PokojBasic(Pokoj.Miejsce.CzteryOs);
            PokojBasic basic2 = new PokojBasic(Pokoj.Miejsce.DwaOs);
            PokojPremium premium1 = new PokojPremium(Pokoj.Miejsce.JedenOs);
            //Console.WriteLine(apartament1.ToString());
            //Console.WriteLine(basic1.ToString());
            //Console.WriteLine(basic2.ToString());
            //Console.WriteLine(premium1.ToString());

            Console.WriteLine();

            Rezerwacja rezerwacja1 = new Rezerwacja(new DateTime(2020, 01, 28), new DateTime(2020, 01, 30), apartament1, klient2, Rezerwacja.FormaPłatności.Karta);
            Rezerwacja rezerwacja2 = new Rezerwacja(new DateTime(2020, 01, 30), new DateTime(2020,02,10), premium1, klient1, Rezerwacja.FormaPłatności.Gotówka);
            Rezerwacja rezerwacja3 = new Rezerwacja(new DateTime(2020, 02, 15), new DateTime(2020, 02, 25), premium1, klient1, Rezerwacja.FormaPłatności.Gotówka);

            //Rezerwacja rezerwacja3 = new Rezerwacja();

            Console.WriteLine(rezerwacja1.ToString());
            Console.WriteLine(rezerwacja2.ToString());

            ZarzadzanieRezerwacjami zarzadzanie = new ZarzadzanieRezerwacjami();
            zarzadzanie.DodajKlienta(klient1);
            zarzadzanie.DodajKlienta(klient2);

            zarzadzanie.SortujKlientow();

            zarzadzanie.DodajPokoj(apartament1);
            zarzadzanie.DodajPokoj(basic1);
            zarzadzanie.DodajPokoj(premium1);
            zarzadzanie.DodajPokoj(basic2);

            zarzadzanie.DodajRezerwacje(rezerwacja1);
            zarzadzanie.DodajRezerwacje(rezerwacja2);
            zarzadzanie.DodajRezerwacje(rezerwacja3);

            Console.WriteLine(zarzadzanie);

            Console.WriteLine("serializacja");
            zarzadzanie.ZapiszXML("zarzadzanie.xml");
            
            Console.WriteLine("deserializacja");
            ZarzadzanieRezerwacjami zarz = ZarzadzanieRezerwacjami.OdczytajXML("zarzadzanie.xml");

            Console.WriteLine(zarz);


        }
    }
}
