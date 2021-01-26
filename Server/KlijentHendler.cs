using Domen;
using Kontroler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zajednicki;

namespace Server
{
    public class KlijentHendler
    {
        private Socket klijentskiSoket;
        private NetworkStream stream;
        private BinaryFormatter formatter = new BinaryFormatter();
        private Trener logovaniTrener;
        List<Trener> treneri = Controller.Instance.VratiSveTrenere();
        public KlijentHendler(Socket klijentskiSoket)
        {
            this.klijentskiSoket = klijentskiSoket;
            this.stream = new NetworkStream(this.klijentskiSoket);
        }

        internal void ObradiZahteve()
        {
            try
            {
                while (true)
                {
                    Zahtev zahtev = (Zahtev)formatter.Deserialize(stream);
                    Odgovor odgovor = new Odgovor();
                    switch (zahtev.Operacija)
                    { 
                        case Operacija.LogIn:
                            foreach (Trener trener in treneri)
                            {
                                if (trener.KorisnickoIme == zahtev.Trener.KorisnickoIme && trener.Lozinka == zahtev.Trener.Lozinka)
                                {
                                    odgovor.Signal = Signal.UspesnoPrijavljen;
                                    this.logovaniTrener = trener;
                                    odgovor.Trener = trener;
                                    break;
                                }
                            }
                            formatter.Serialize(stream, odgovor);
                            break;

                        case Operacija.VratiGrupe:
                            odgovor.Grupe = Controller.Instance.VratiSveGrupe();
                            formatter.Serialize(stream, odgovor);
                            break;

                        case Operacija.UbaciClana:
                            if (Controller.Instance.SacuvajClana(zahtev.Clan))
                            {
                                odgovor.Signal = Signal.ClanUspesnoDodat;
                            }
                            formatter.Serialize(stream, odgovor);                    
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                //Server.PrijavljeniKorisnici.Remove(korisnik);
            }
        }
    }
}
