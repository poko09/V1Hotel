using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ProjektHotel
{

    abstract class Pokoj
    {

        public uint nrPokoju = 0;
        public double cena;
        public bool jestDostepny = true;
        public enum Miejsce { JedenOs = 1, DwaOs = 2, TrzyOs = 3, CzteryOs = 4 };
        Miejsce miejsce;
        internal Miejsce Miejsce1 { get => miejsce; set => miejsce = value; }

        public static uint bieżącyNumerPokoju = 0;


        protected Pokoj(Miejsce miejsce)
        {
            this.Miejsce1 = miejsce;
            this.nrPokoju = ++bieżącyNumerPokoju;
        }

        public override string ToString()
        {
            return "Nr pokoju: " + nrPokoju + ", Ilość osób: " + this.Miejsce1.ToString();
        }

        
    }
}