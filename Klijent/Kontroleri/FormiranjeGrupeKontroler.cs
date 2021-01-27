using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent.Kontroleri
{
    public class FormiranjeGrupeKontroler
    {
        public void DodavanjeGrupe(VrstaGrupe vrsta)
        {
            if (Komunikacija.Instance.SacuvajGrupu(vrsta))
            {
                MessageBox.Show("Sistem je zapamtio grupu za trening");
            }
            else
            {
                MessageBox.Show("Sistem ne moze da zapamti grupu za trening");
            }
        }
    }
}
