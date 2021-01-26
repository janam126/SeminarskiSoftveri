using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent.Kontroleri
{
    public class UnosClanaKontroler
    {
        internal void UnesiClana(string ime, string prezime, DateTime datumRodjenja, object grupa)
        {
            Clan clan = new Clan
            {
                Ime = ime,
                Prezime = prezime,
                DatumRodjenja = datumRodjenja,

            };

            if(grupa != null)
            {
                clan.Grupa = (GrupaZaTrening)grupa;
            }

            if (Komunikacija.Instance.UbaciClana(clan))
            {
                MessageBox.Show("Sistem je zapamtio clana");
            }
            else
            {
                MessageBox.Show("Sistem ne moze da zapamti clana");
            }
        }
    }
}
