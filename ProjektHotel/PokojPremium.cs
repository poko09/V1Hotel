
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektHotel
{
    [Serializable]
    public class PokojPremium : Pokoj
    {
        static double stawka = 90;
        public static double Stawka { get => stawka; set => value = stawka; }
        public PokojPremium() { }
        public PokojPremium(Miejsce miejsce) : base(miejsce) 
        {
            this.Cena = stawka * (int)Miejsce1;
        }

        public override string ToString()
        {
            return base.ToString() + ", Typ pokoju: " + "Premium" + ", Cena za dobę: " + this.Cena;
        }
    }
}