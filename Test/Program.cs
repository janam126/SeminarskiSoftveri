using DBBroker;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Clan clan = new Clan
            //{
            //    ClanID = 1,
            //    Ime = "Ognjen",
            //    Prezime = "Pejcic",
            //    DatumRodjenja = DateTime.Parse("9/23/1998"),
            //    Grupa = new GrupaZaTrening
            //    {
            //        GrupaID = 1
            //    }
            //};

            Termin termin = new Termin
            {
                TerminID = 2,
                DanTermina = "petak subota",
                VremeTermina = "07:00 PM",
                Grupa = new GrupaZaTrening
                {
                    GrupaID = 1
                },
                Trener = new Trener
                {
                    TrenerID = 1
                }

            };

            //GrupaZaTrening grupa = new GrupaZaTrening
            //{
            //    GrupaID = 6,
            //    BrojClanova = 50,
            //    VrstaGrupe = new VrstaGrupe
            //    {
            //        VrstaGrupeID = 1
            //    }
            //};

            Broker broker = new Broker();
            broker.OtvoriKonekciju();

            List<DomenskiObjekat> grupe = broker.VratiSveJoin(new GrupaZaTrening());
            foreach(GrupaZaTrening grupa in grupe)
            {

                Console.WriteLine(grupa.BrojClanova + grupa.VrstaGrupe.NazivVrste);
            }


            //if(broker.Sacuvaj(grupa) == 1)
            //{
            //    Console.WriteLine("Grupa je sacuvana");
            //}

            //List<DomenskiObjekat> objekat = broker.Pronadji(grupa);
            //foreach (GrupaZaTrening g in objekat)
            //{
            //    Console.WriteLine(g.VrstaGrupe.NazivVrste); //ne radi
            //}

            //try
            //{
            //    broker.Azuriraj(grupa);
            //    Console.WriteLine("Grupa je izmenjena");
            //}
            //catch(Exception e)
            //{

            //}

            //List<DomenskiObjekat> objekat = broker.VratiSve(grupa);
            //foreach (GrupaZaTrening g in objekat)
            //{
            //    Console.WriteLine(g.BrojClanova);
            //}

            //if(broker.Sacuvaj(termin) == 1)
            //{
            //    Console.WriteLine("Termin je sacuva");
            //}

            //List<DomenskiObjekat> objekat = broker.Pronadji(termin);
            //foreach(Termin t in objekat)
            //{
            //    Console.WriteLine(t.DanTermina + " " + t.VremeTermina);
            //}

            //try
            //{
            //    broker.Azuriraj(termin);
            //    Console.WriteLine("Termin je izmenjen");
            //}
            //catch(Exception e)
            //{

            //}

            //if(broker.Sacuvaj(clan) == 1)
            //{
            //    Console.WriteLine("Clan je sacuvan");
            //}

            //List<DomenskiObjekat> objekat = broker.Pronadji(clan);
            //foreach (Clan c in objekat)
            //{
            //    Console.WriteLine(c.Ime + " " + c.Prezime);
            //}

            //try
            //{
            //    broker.Azuriraj(clan);
            //    Console.WriteLine("Uspesna izmena");
            //}catch(Exception e)
            //{

            //}

            //List<DomenskiObjekat> objekat = broker.VratiSve(clan);
            //foreach (Clan c in objekat)
            //{
            //    Console.WriteLine(c.Ime + " " + c.Prezime);
            //}



            broker.ZatvoriKonekciju();
        }
    }
}
