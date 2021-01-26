using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Clan : DomenskiObjekat
    {
        public int ClanID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public GrupaZaTrening Grupa { get; set; }
        public string TableName => "Clan";

        public string InsertValues => $"'{Ime}', '{Prezime}', '{DatumRodjenja}', {Grupa.GrupaID}";

        public string JoinFull => $"c JOIN GrupaZaTrening g ON (c.GrupaID = g.GrupaID)";

        public string JoinTable => throw new NotImplementedException();

        public string KriterijumPretrage => $"ClanID = {ClanID}";

        public string UpdateValues => $"Ime = '{Ime}', Prezime = '{Prezime}', DatumRodjenja = '{DatumRodjenja}', GrupaID = {Grupa.GrupaID}";

        public List<DomenskiObjekat> GetEntities(SqlDataReader reader)
        {
            List<DomenskiObjekat> list = new List<DomenskiObjekat>();
            while (reader.Read())
            {
                Clan clan = new Clan
                {
                    ClanID = reader.GetInt32(0),
                    Ime = reader.GetString(1),
                    Prezime = reader.GetString(2),
                    DatumRodjenja = reader.GetDateTime(3),
                    Grupa = new GrupaZaTrening
                    {
                        GrupaID = reader.GetInt32(4)
                    }
                };
                list.Add(clan);
            }
            return list;
        }

        public DomenskiObjekat GetEntity(SqlDataReader reader)
        {
            Clan clan = new Clan();

            while (reader.Read())
            {
                clan.ClanID = reader.GetInt32(0);
                clan.Ime = reader.GetString(1);
                clan.Prezime = reader.GetString(2);
                clan.DatumRodjenja = reader.GetDateTime(3);
                clan.Grupa = new GrupaZaTrening
                {
                    GrupaID = reader.GetInt32(4)
                };        
            }
            return clan;
        }
    }
}
