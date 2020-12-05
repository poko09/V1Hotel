using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektHotel
{
    class PokojBasic : Pokoj
    {
        static double stawka = 80;
        public PokojBasic(Miejsce miejsce) : base(miejsce)
        {
            this.cena = stawka * (int)Miejsce1;
        }
        public override string ToString()
        {
            return base.ToString() + ", Typ pokoju: " + "Basic" +", Cena za dobę: " + this.cena;
        }
    }
}
