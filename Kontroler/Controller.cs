using DBBroker;
using Domen;
using SistemskeOperacije;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontroler
{
    public class Controller
    {
        private static Controller instance;
        private Broker broker = new Broker();

        public static Controller Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Controller();
                }
                return instance;
            }
        }

        public bool SacuvajClana(Clan clan)
        {
            ApstraktnaGenerickaOperacija operacija = new ZapamtiClanaSO();
            return (bool)operacija.ExecuteSO(clan);
        }

        public bool SacuvajTermine(List<Termin> termini)
        {
            ApstraktnaGenerickaOperacija operacija = new ZapamtiTermineSO();
            return (bool)operacija.ExecuteSO(termini);
        }

        public bool SacuvajGrupuZaTrening(GrupaZaTrening grupa)
        {
            ApstraktnaGenerickaOperacija operacija = new ZapamtiGrupuZaTreningSO();
            return (bool)operacija.ExecuteSO(grupa);
        }

        public List<Clan> NadjiClanove(Clan clan)
        {
            ApstraktnaGenerickaOperacija operacije = new NadjiClanaSO();
            List<Clan> clanovi = (List<Clan>)operacije.ExecuteSO(clan);
            return clanovi;
        }

        public List<Termin> NadjiTermine(Termin termin)
        {
            ApstraktnaGenerickaOperacija operacije = new NadjiTerminSO();
            List<Termin> termini = (List<Termin>)operacije.ExecuteSO(termin);
            return termini;
        }

        public List<GrupaZaTrening> NadjiGrupeZaTrening(GrupaZaTrening grupa)
        {
            ApstraktnaGenerickaOperacija operacije = new NadjiGrupuZaTreningSO();
            List<GrupaZaTrening> grupe = (List<GrupaZaTrening>)operacije.ExecuteSO(grupa);
            return grupe;
        }

        public List<GrupaZaTrening> VratiSveGrupe()
        {
            ApstraktnaGenerickaOperacija operacija = new UcitajListuGrupaSO();
            List<GrupaZaTrening> grupe = (List<GrupaZaTrening>)operacija.ExecuteSO(new GrupaZaTrening());
            return grupe;
        }

        public List<Trener> VratiSveTrenere()
        {
            ApstraktnaGenerickaOperacija operacija = new UcitajListuTreneraSO();
            List<Trener> treneri = (List<Trener>)operacija.ExecuteSO(new Trener());
            return treneri;
        }

        public Clan UcitajClana(Clan clan)
        {
            ApstraktnaGenerickaOperacija operacija = new UcitajClanaSO();
            return (Clan)operacija.ExecuteSO(clan);
        }

        public Termin UcitajTermin(Termin termin)
        {
            ApstraktnaGenerickaOperacija operacija = new UcitajTerminSO();
            return (Termin)operacija.ExecuteSO(termin);
        }

        public GrupaZaTrening UcitajGrupuZaTrening(GrupaZaTrening grupa)
        {
            ApstraktnaGenerickaOperacija operacija = new UcitajGrupuZaTreningSO();
            return (GrupaZaTrening)operacija.ExecuteSO(grupa);
        }

        public bool ObrisiClana(Clan clan)
        {
            ApstraktnaGenerickaOperacija operacija = new ObrisiClanaSO();
            return (bool)operacija.ExecuteSO(clan);
        }

        public bool ObrisiTermin(Termin termin)
        {
            ApstraktnaGenerickaOperacija operacija = new ObrisiTerminSO();
            return (bool)operacija.ExecuteSO(termin);
        }


        public List<VrstaGrupe> VratiSveVrste(VrstaGrupe vrsta)
        {
            ApstraktnaGenerickaOperacija operacija = new UcitajVrsteGrupaSO();
            return (List<VrstaGrupe>)operacija.ExecuteSO(vrsta);
        }
    }
}
