using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektHotel
{
    class ZarzadzanieRezerwacjami
    {
        List<Rezerwacja> rezerwacje;

        public ZarzadzanieRezerwacjami()
        {
            this.rezerwacje = new List<Rezerwacja>();
        }

        public void DodajRezerwacje(Rezerwacja rezerwacja)
        {
            if (rezerwacje.Exists(x => x.NrRezerwacji == rezerwacja.NrRezerwacji))
            {
                throw new Exception("Rezerwacja o podanym numerze już istenieje.");
            }
            else if (rezerwacje.Exists(x => (x.Pokoj == rezerwacja.Pokoj
             && !(x.DataZameldowania >= rezerwacja.DataWymeldowania || x.DataWymeldowania <= rezerwacja.DataZameldowania))))
            {
                throw new Exception("Pokoj jest juz zarezerwowany w danym terminie.");
            }
            else { rezerwacje.Add(rezerwacja); }
        }

        public void UsunRezerwacje(uint numerRezerwacji)
        {
            rezerwacje.RemoveAll(x => x.NrRezerwacji == numerRezerwacji);
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder("HOTEL \n");
            stringBuilder.AppendLine("Rezerwacje: ");
            foreach(Rezerwacja rezerwacja in rezerwacje)
            {
                stringBuilder.AppendLine(rezerwacja.ToString());
            }
            return stringBuilder.ToString();
        }
    }
}