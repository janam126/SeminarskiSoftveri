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

namespace Klijent
{
    public partial class LogIn : Form
    {
        LogInKontroler logInKontroler = new LogInKontroler();
        public LogIn()
        {
            PoveziSaServerom();
            InitializeComponent();
        }

        private void PoveziSaServerom()
        {
            if (Komunikacija.Instance.PoveziSe())
            {
                MessageBox.Show("Uspesno povezivanje");
            }
            else
            {
                MessageBox.Show("Neuspesno povezivanje");
                Environment.Exit(0);
            }
        }

        private void brnPrijava_Click(object sender, EventArgs e)
        {
            logInKontroler.LogIn(txtKorisnickoIme.Text, txtLozinka.Text);
        }
    }
}
