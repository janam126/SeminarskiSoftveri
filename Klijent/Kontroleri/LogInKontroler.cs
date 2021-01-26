using Klijent.Forme;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent.Kontroleri
{
    public class LogInKontroler
    {
        internal void LogIn(string korisnickoIme, string lozinka)
        {
            if(String.IsNullOrEmpty(korisnickoIme) || String.IsNullOrEmpty(lozinka))
            {
                MessageBox.Show("Sva polja su obavezna");
                return;
            }

            if (Komunikacija.Instance.LogIn(korisnickoIme, lozinka))
            {
                MessageBox.Show("Uspesno ste se prijavili");
                Glavna glavna = new Glavna();
                glavna.ShowDialog();
            }
            else
            {
                MessageBox.Show("Neuspesna prijava");
            }
        }
    }
}
