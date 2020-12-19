
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektHotel
{
    class PokojPremium : Pokoj
    {
        static double stawka = 90;
        public PokojPremium(Miejsce miejsce) : base(miejsce) 
        {
            this.cena = stawka * (int)Miejsce1;
        }

        public override string ToString()
        {
            return base.ToString() + ", Typ pokoju: " + nameof(PokojPremium) + ", Cena za dobę: " + this.cena;
        }
    }
}