﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektHotel
{
    [Serializable]
    public class PokojBasic : Pokoj
    {
        static double stawka = 80;
        public static double Stawka { get => stawka; set => value= stawka; }
        public PokojBasic() { }
        public PokojBasic(Miejsce miejsce) : base(miejsce)
        {
            this.Cena = Stawka * (int)Miejsce1;
        }

        public PokojBasic(Miejsce miejsce, int numerPokoju) : base(miejsce, numerPokoju)
        {
            this.Cena = Stawka * (int)Miejsce1;
        }

        public override string ToString()
        {
            return base.ToString() + ", Typ pokoju: " + nameof(PokojBasic) +", Cena za dobę: " + this.Cena;
        }
    }
}
