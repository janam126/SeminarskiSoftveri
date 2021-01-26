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
    public partial class FrmUnosClanova : Form
    {
        UnosClanaKontroler kontroler = new UnosClanaKontroler();
        public FrmUnosClanova()
        {
            InitializeComponent();
            try
            {
                cmbGrupa.DataSource = Komunikacija.Instance.VratiGrupe();
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Sistem ne moze da ucita grupe");
                return;
            }
        }

        private void btnUnesiClana_Click(object sender, EventArgs e)
        {
            kontroler.UnesiClana(txtIme.Text, txtPrezime.Text, dtpDatumRodjenja.Value, cmbGrupa.SelectedItem);
        }
    }
}
