
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektHotel
{
    class Apartament : Pokoj
    {
        static double stawka= 100;
        public Apartament(Miejsce miejsce) : base(miejsce)
        {
            this.cena = stawka * (int)Miejsce1;
        }
        public override string ToString()
        {
            return base.ToString() + ", Typ pokoju: " + "Apartament" + ", Cena za dobę: " + this.cena;
        }

    }
}
