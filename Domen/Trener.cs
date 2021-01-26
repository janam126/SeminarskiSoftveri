using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Trener : DomenskiObjekat
    {
        public int TrenerID { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string TableName => "Trener";

        public string InsertValues => throw new NotImplementedException();

        public string JoinFull => throw new NotImplementedException();

        public string JoinTable => throw new NotImplementedException();

        public string KriterijumPretrage => $"TrenerID = {TrenerID}";

        public string UpdateValues => throw new NotImplementedException();

        public List<DomenskiObjekat> GetEntities(SqlDataReader reader)
        {
            List<DomenskiObjekat> list = new List<DomenskiObjekat>();
            while (reader.Read())
            {
                Trener trener = new Trener
                {
                    TrenerID = reader.GetInt32(0),
                    KorisnickoIme = reader.GetString(1),
                    Lozinka = reader.GetString(2),
                    Ime = reader.GetString(3),
                    Prezime = reader.GetString(4),
                    DatumRodjenja = reader.GetDateTime(5)
                };
                list.Add(trener);
            }
            reader.Close();
            return list;
        }

        public DomenskiObjekat GetEntity(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
