using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent.Kontroleri
{
    public class ZakazivanjeTerminaKontroler
    {
        public BindingList<Termin> termini = new BindingList<Termin>();
        internal void DodajTermin(string danTermina, string vremeTermina, object grupaNaziv, object trener)
        {
            if(String.IsNullOrEmpty(danTermina) || String.IsNullOrEmpty(vremeTermina))
            {
                MessageBox.Show("Sva polja su obavezna");
                return;
            }

            termini.Add(new Termin
            {
                DanTermina = danTermina,
                VremeTermina = vremeTermina,
                Grupa = (GrupaZaTrening)grupaNaziv,
                Trener = (Trener)trener
            });
        }

        internal void SacuvajTermine()
        {
            if (Komunikacija.Instance.SacuvajSveTermine(termini))
            {
                MessageBox.Show("Sistem je sacuvao termine");
            }
            else
            {
                MessageBox.Show("Sistem ne moze da zapamti termine");
            }
        }
    }
}
