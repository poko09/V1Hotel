﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace ProjektHotel
{
    [Serializable]
    public class ZarzadzanieRezerwacjami
    {
        List<Rezerwacja> rezerwacje;
        List<Klient> klienci;
        List<Pokoj> pokoje;
        int liczbaKlientow;

        public List<Klient> Klienci { get => klienci; set => klienci = value; }
        public int LiczbaKlientow { get => liczbaKlientow; set => liczbaKlientow = value; }
        public List<Rezerwacja> Rezerwacje { get => rezerwacje; set => rezerwacje = value; }
        public List<Pokoj> Pokoje { get => pokoje; set => pokoje = value; }

        public ZarzadzanieRezerwacjami()
        {
            this.Rezerwacje = new List<Rezerwacja>();
            klienci = new List<Klient>();
            pokoje = new List<Pokoj>();
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

        public bool CzyDostepnyWTerminie(Pokoj pokoj, DateTime dataPoczatkowa, DateTime dataKoncowa)
        {
            if (Rezerwacje.Exists(x => (x.Pokoj.Equals(pokoj)       //x.Pokoj == pokoj
             && !(x.DataZameldowania >= dataKoncowa || x.DataWymeldowania <= dataPoczatkowa))))
            {
                return false;
            }
            else { return true; }
        }

        public void DodajRezerwacje(Rezerwacja rezerwacja)
        {

            /*
            if (Rezerwacje.Exists(x => x.NrRezerwacji == rezerwacja.NrRezerwacji))
            {
                throw new Exception("Rezerwacja o podanym numerze już istenieje.");
            }
            */
            if (CzyDostepnyWTerminie(rezerwacja.Pokoj, rezerwacja.DataZameldowania, rezerwacja.DataWymeldowania))
            {
                Rezerwacje.Add(rezerwacja);
            }
            else
            {
                throw new Exception("Pokoj jest juz zarezerwowany w danym terminie.");
            }

        }

        public void UsunRezerwacje(uint numerRezerwacji)
        {
            Rezerwacje.RemoveAll(x => x.NrRezerwacji == numerRezerwacji);
        }

        public bool CzyNumerPokojuIstnieje(Pokoj pokoj)
        {
            if (Pokoje.Exists(x => x.NrPokoju == pokoj.NrPokoju))
            {
                return true;
            }
            else { return false; }
        }

        public void DodajPokoj(Pokoj pokoj)
        {
            if (CzyNumerPokojuIstnieje(pokoj))
            {
                throw new Exception("Pokoj o danym numerze juz istnieje");
            }
            else
            {
                pokoje.Add(pokoj);
            }
        }

        public void UsunPokoj(uint NrPokoju)
        {
            foreach(Pokoj pokoj in Pokoje)
            {
                if(NrPokoju == pokoj.NrPokoju)
                {
                    pokoje.Remove(pokoj);
                    break;
                }
                
            }
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder("HOTEL \n");
         //   stringBuilder.AppendLine("Liczba klientów: "+liczbaKlientow);
            stringBuilder.AppendLine("Klienci: ");
            foreach (Klient klient in klienci)
            {
                stringBuilder.AppendLine(klient.ToString());
            }
            stringBuilder.AppendLine("Pokoje: ");
            foreach (Pokoj pokoj in Pokoje)
            {
                stringBuilder.AppendLine(pokoj.ToString());
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


        static Type[] types = new Type[] { typeof(Apartament), typeof(PokojBasic), typeof(PokojPremium) };
        public void ZapiszXML(string nazwa)
        {
            using (StreamWriter writer = new StreamWriter(nazwa))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ZarzadzanieRezerwacjami),types);
                serializer.Serialize(writer, this);
            }
        }

        public static ZarzadzanieRezerwacjami OdczytajXML(string nazwa)
        {
            using (StreamReader reader = new StreamReader(nazwa))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ZarzadzanieRezerwacjami),types);
                return serializer.Deserialize(reader) as ZarzadzanieRezerwacjami;
            }
        }

    }
}