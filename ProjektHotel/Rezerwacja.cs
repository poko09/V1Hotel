using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ProjektHotel
{
    class Rezerwacja
    {
        uint nrRezerwacji = 0;
        double koszt;
        DateTime dataZameldowania;
        DateTime dataWymeldowania;
        Pokoj pokoj;
        Klient klient;
        public enum FormaPłatności { Gotówka, Karta }
        FormaPłatności formaPłatności;

        public static uint bieżącyNumerRezerwacji = 0;

        public uint NrRezerwacji { get => nrRezerwacji; set => nrRezerwacji = value; }
        public double Koszt { get => koszt; set => koszt = value; }
        public DateTime DataZameldowania { get => dataZameldowania; set => dataZameldowania = value; }
        public DateTime DataWymeldowania { get => dataWymeldowania; set => dataWymeldowania = value; }
        internal Pokoj Pokoj { get => pokoj; set => pokoj = value; }
        internal Klient Klient { get => klient; set => klient = value; }
        internal FormaPłatności FormaPłatności1 { get => formaPłatności; set => formaPłatności = value; }

        public Rezerwacja(DateTime dataZameldowania, DateTime dataWymeldowania, Pokoj pokoj, Klient klient, FormaPłatności formaPłatności)
        {
            if (dataZameldowania < dataWymeldowania)
            {
                this.dataZameldowania = dataZameldowania;
                this.dataWymeldowania = dataWymeldowania;
                this.pokoj = pokoj;
                this.klient = klient;
                this.formaPłatności = formaPłatności;
                this.nrRezerwacji = ++bieżącyNumerRezerwacji;
                this.koszt = pokoj.cena * (int)(dataWymeldowania.Day - dataZameldowania.Day);
            }
            else
            {
                throw new Exception("Data zameldowania musi być wcześniejsza niż data wymeldowania.");
            }
        }

        public int IleDni(DateTime dataZameldowania, DateTime dataWymeldowania)
        {
            int dni = 0;
            dni = (int)(dataWymeldowania.Day - dataZameldowania.Day);
            return dni;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nr rezerwacji: " + this.nrRezerwacji);
            sb.AppendLine("Klient: " + klient.Id);
            sb.AppendLine("Data zameldowania: " + this.dataZameldowania);
            sb.AppendLine("Data wymeldowania: " + this.dataWymeldowania.ToString());
            sb.AppendLine("Ilość nocy: " + IleDni(this.DataZameldowania, this.DataWymeldowania).ToString());
            sb.AppendLine("Nr pokoju: " + pokoj.nrPokoju.ToString());
            sb.AppendLine("Koszt całkowity: " + this.koszt.ToString());
            return sb.ToString();
        }
    }
}