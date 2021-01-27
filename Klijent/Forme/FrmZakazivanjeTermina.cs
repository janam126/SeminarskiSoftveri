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
    public partial class FrmZakazivanjeTermina : Form
    {
        ZakazivanjeTerminaKontroler kontroler = new ZakazivanjeTerminaKontroler();

        public FrmZakazivanjeTermina()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            kontroler.DodajTermin(txtDanTermina.Text, txtVremeTermina.Text, cmbGrupa.SelectedItem, cmbTrener.SelectedItem);
            dgvPrikazi.DataSource = kontroler.termini;
            dgvPrikazi.Columns["TerminID"].Visible = false;
        }

        private void FrmZakazivanjeTermina_Load(object sender, EventArgs e)
        {
            cmbGrupa.DataSource = Komunikacija.Instance.VratiGrupe();
            cmbTrener.DataSource = Komunikacija.Instance.PrikaziTrenere();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            kontroler.SacuvajTermine();
        }
    }
}
