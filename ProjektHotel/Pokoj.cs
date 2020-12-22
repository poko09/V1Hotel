using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ProjektHotel
{
    [Serializable]
    public abstract class Pokoj :IEquatable<Pokoj>
    {

        uint nrPokoju = 0;
        double cena;
        bool jestDostepny = true;
        public static uint bieżącyNumerPokoju = 0;
        public enum Miejsce { JedenOs = 1, DwaOs = 2, TrzyOs = 3, CzteryOs = 4 };
        Miejsce miejsce;

        public uint NrPokoju { get => nrPokoju; set => nrPokoju = value; }
        public double Cena { get => cena; set => cena = value; }
        public bool JestDostepny { get => jestDostepny; set => jestDostepny = value; }
        public Miejsce Miejsce1 { get => miejsce; set => miejsce = value; }

        public Pokoj() { }
        public Pokoj(Miejsce miejsce)
        {
            this.Miejsce1 = miejsce;
            this.NrPokoju = ++bieżącyNumerPokoju;
        }

        /////// TUUUUUUUUUUUUUUUU ZMIENILAM
        public Pokoj(Miejsce miejsce, int numerPokoju)
        {
            this.Miejsce1 = miejsce; 
            this.NrPokoju = (uint)numerPokoju;
        }

        public override string ToString()
        {
            return "Nr pokoju: " + NrPokoju + ", Ilość osób: " + this.Miejsce1.ToString();
        }

        public bool Equals(Pokoj other)
        {
            return (this.NrPokoju == other.NrPokoju && this.Miejsce1 == other.Miejsce1 && this.GetType() == other.GetType());
        }
    }
}