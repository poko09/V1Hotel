
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektHotel
{
    [Serializable]
    public class Apartament : Pokoj
    {
        static double stawka= 100;

        public Apartament() { }
        public Apartament(Miejsce miejsce) : base(miejsce)
        {
            this.Cena = Stawka * (int)Miejsce1;
        }

        public Apartament(Miejsce miejsce, int numerPokoju) : base(miejsce, numerPokoju)
        {
            this.Cena = Stawka * (int)Miejsce1;
        }

        public static double Stawka { get => stawka; set => value = stawka; }

        public override string ToString()
        {
            return base.ToString() + ", Typ pokoju: " + nameof(Apartament) + ", Cena za dobę: " + this.Cena;
        }

    }
}
