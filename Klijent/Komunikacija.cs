using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Zajednicki;

namespace Klijent
{
    public class Komunikacija
    {
        private static Komunikacija instance;

        private Socket klijentskiSoket;
        private NetworkStream stream;
        private BinaryFormatter formatter = new BinaryFormatter();

        public static Komunikacija Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Komunikacija();
                }
                return instance;
            }
        }

        public bool PoveziSe()
        {
            try
            {
                if (klijentskiSoket == null || !klijentskiSoket.Connected)
                {
                    klijentskiSoket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    klijentskiSoket.Connect("127.0.0.1", 8000);
                    stream = new NetworkStream(klijentskiSoket);
                }
                return true;
            }
            catch (SocketException se)
            {
                return false;
            }
        }

        internal bool LogIn(string korisnickoIme, string lozinka)
        {
            Zahtev zahtev = new Zahtev();
            zahtev.Operacija = Operacija.LogIn;
            zahtev.Trener = new Trener()
            {
                KorisnickoIme = korisnickoIme,
                Lozinka = lozinka
            };
            formatter.Serialize(stream, zahtev);
            Odgovor odgovor = (Odgovor)formatter.Deserialize(stream);

            if(odgovor.Signal == Signal.UspesnoPrijavljen)
            {
                return true;
            }
            return false;
        }

        internal object VratiGrupe()
        {
            Zahtev zahtev = new Zahtev();
            zahtev.Operacija = Operacija.VratiGrupe;
            formatter.Serialize(stream, zahtev);
            Odgovor odgovor = (Odgovor)formatter.Deserialize(stream);
            return odgovor.Grupe;
        }


        internal bool UbaciClana(Clan clan)
        {
            Zahtev zahtev = new Zahtev();
            zahtev.Operacija = Operacija.UbaciClana;
            zahtev.Clan = clan;
            formatter.Serialize(stream, zahtev);
            Odgovor odgovor = (Odgovor)formatter.Deserialize(stream);

            if(odgovor.Signal == Signal.ClanUspesnoDodat)
            {
                return true;
            }
            return false; 
        }

        public List<VrstaGrupe> VratiVrsteGrupa()
        {
            Zahtev zahtev = new Zahtev();
            zahtev.Operacija = Operacija.VratiVrste;
            formatter.Serialize(stream, zahtev);
            Odgovor odgovor = (Odgovor)formatter.Deserialize(stream);
            return odgovor.VrstaGrupe;
        }

        public bool SacuvajGrupu(VrstaGrupe vrstaGrupe)
        {
            Zahtev zahtev = new Zahtev();
            zahtev.Operacija = Operacija.SacuvajGrupu;
            zahtev.VrstaGrupe = vrstaGrupe;
            formatter.Serialize(stream, zahtev);
            Odgovor odgovor = (Odgovor)formatter.Deserialize(stream);
            if(odgovor.Signal == Signal.GrupaUspesnoDodata)
            {
                return true;
            }
            return false;
        }

        internal List<Trener> PrikaziTrenere()
        {
            Zahtev zahtev = new Zahtev();
            zahtev.Operacija = Operacija.VratiTrenere;
            formatter.Serialize(stream, zahtev);
            Odgovor odgovor = (Odgovor)formatter.Deserialize(stream);
            return odgovor.ListaTrenera;
        }


        internal bool SacuvajSveTermine(BindingList<Termin> termini)
        {
            Zahtev zahtev = new Zahtev();
            zahtev.Operacija = Operacija.SacuvajTermine;
            zahtev.Termini = termini;
            formatter.Serialize(stream, zahtev);
            Odgovor odgovor = (Odgovor)formatter.Deserialize(stream);
            if(odgovor.Signal == Signal.UspenoDodatiTermini)
            {
                return true;
            }
            return false;
        }
    }
}
