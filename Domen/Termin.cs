using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Termin : DomenskiObjekat
    {
        public int TerminID { get; set; }
        public string DanTermina { get; set; }
        public string VremeTermina { get; set; }
        public GrupaZaTrening Grupa { get; set; }
        public Trener Trener { get; set; }
        public string TableName => "Termin";

        public string InsertValues => $"'{DanTermina}', '{VremeTermina}', {Grupa.GrupaID}, {Trener.TrenerID}";

        public string JoinFull => $"ter JOIN GrupaZaTrening g ON (ter.GrupaID = g.GrupaID) JOIN Trener t ON (ter.Termin = t.TerminID)";

        public string JoinTable => throw new NotImplementedException();

        public string KriterijumPretrage => $"TerminID = {TerminID}";

        public string UpdateValues => $"DanTermina = '{DanTermina}', VremeTermina = '{VremeTermina}', GrupaID = {Grupa.GrupaID}, TrenerID = {Trener.TrenerID}";

        public List<DomenskiObjekat> GetEntities(SqlDataReader reader)
        {
            List<DomenskiObjekat> list = new List<DomenskiObjekat>();
            while (reader.Read())
            {
                Termin termin = new Termin
                {
                    TerminID = reader.GetInt32(0),
                    DanTermina = reader.GetString(1),
                    VremeTermina = reader.GetString(2),
                    Grupa = new GrupaZaTrening
                    {
                        GrupaID = reader.GetInt32(3)
                    },
                    Trener = new Trener
                    {
                        TrenerID = reader.GetInt32(4)
                    }
                };
                list.Add(termin);
            }
            reader.Close();
            return list;
        }

        public DomenskiObjekat GetEntity(SqlDataReader reader)
        {
            Termin termin = new Termin();

            while (reader.Read())
            {
                termin.TerminID = reader.GetInt32(0);
                termin.DanTermina = reader.GetString(1);
                termin.VremeTermina = reader.GetString(2);
                termin.Grupa = new GrupaZaTrening
                {
                    GrupaID = reader.GetInt32(3)
                };
                termin.Trener = new Trener
                {
                    TrenerID = reader.GetInt32(4)
                };
            }
            return termin;
        }
    }
}
