﻿
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
        public static double Stawka { get => stawka; set => value = stawka; }

        public override string ToString()
        {
            return base.ToString() + ", Typ pokoju: " + "Apartament" + ", Cena za dobę: " + this.Cena;
        }

    }
}
