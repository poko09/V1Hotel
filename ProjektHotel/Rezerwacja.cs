using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektHotel
{
    [Serializable]
    public class Rezerwacja
    {
        uint nrRezerwacji;
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
        public Pokoj Pokoj { get => pokoj; set => pokoj = value; }
        public Klient Klient { get => klient; set => klient = value; }
        public FormaPłatności FormaPłatności1 { get => formaPłatności; set => formaPłatności = value; }

        public Rezerwacja() { }
        public Rezerwacja(DateTime dataZameldowania, DateTime dataWymeldowania, Pokoj pokoj, Klient klient, FormaPłatności formaPłatności)
        {
            this.dataZameldowania = dataZameldowania;
            this.dataWymeldowania = dataWymeldowania;
            this.pokoj = pokoj;
            this.klient = klient;
            this.formaPłatności = formaPłatności;
            this.nrRezerwacji = ++bieżącyNumerRezerwacji;
            this.koszt = pokoj.Cena * IleDni(this.dataZameldowania,this.dataWymeldowania);
        }

        public Rezerwacja(uint nrRezerwacji, DateTime dataZameldowania, DateTime dataWymeldowania, Pokoj pokoj, Klient klient, FormaPłatności formaPłatności)
        {
            this.nrRezerwacji = nrRezerwacji;
            this.dataZameldowania = dataZameldowania;
            this.dataWymeldowania = dataWymeldowania;
            this.pokoj = pokoj;
            this.klient = klient;
            this.formaPłatności = formaPłatności;
            this.koszt = pokoj.Cena * IleDni(this.dataZameldowania, this.dataWymeldowania);
        }

        public int IleDni(DateTime dataZameldowania, DateTime dataWymeldowania)
        {
            int dni = 0;
            TimeSpan interval = dataWymeldowania - dataZameldowania;
            dni = interval.Days;
            return dni;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nr rezerwacji: " + this.nrRezerwacji);
            sb.AppendLine("Klient: " + klient.Id);
            sb.AppendLine("Data zameldowania: " + this.dataZameldowania.ToString("dd.MM.yyyy"));
            sb.AppendLine("Data wymeldowania: " + this.dataWymeldowania.ToString("dd.MM.yyyy"));
            sb.AppendLine("Ilość nocy: " + IleDni(this.DataZameldowania, this.DataWymeldowania).ToString());
            sb.AppendLine("Nr pokoju: " + pokoj.NrPokoju.ToString());
            sb.AppendLine("Koszt całkowity: " + this.koszt.ToString());
            return sb.ToString();
        }
    }
}
