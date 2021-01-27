using Domen;
using Klijent.Kontroleri;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent.Forme
{
    public partial class FrmFormiranjeGrupe : Form
    {
        FormiranjeGrupeKontroler kontroler = new FormiranjeGrupeKontroler();

        public FrmFormiranjeGrupe()
        {
            InitializeComponent();
        }

        private void FrmFormiranjeGrupe_Load(object sender, EventArgs e)
        {
            cmbVrsta.DataSource = Komunikacija.Instance.VratiVrsteGrupa();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            VrstaGrupe vrsta = (VrstaGrupe)cmbVrsta.SelectedItem;
            kontroler.DodavanjeGrupe(vrsta);
        }
    }
}
