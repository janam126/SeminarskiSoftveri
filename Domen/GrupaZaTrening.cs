using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class GrupaZaTrening : DomenskiObjekat
    {
        public int GrupaID { get; set; }
        public int BrojClanova { get; set; }
        public VrstaGrupe VrstaGrupe { get; set; }

        public string TableName => "GrupaZaTrening";

        public string InsertValues => $"{BrojClanova}, {VrstaGrupe.VrstaGrupeID}";

        public string JoinFull => $"g JOIN VrstaGrupe vg ON (g.VrstaGrupeID = vg.VrstaGrupeID)";

        public string JoinTable => throw new NotImplementedException();

        public string KriterijumPretrage => $"GrupaID = {GrupaID}";

        public string UpdateValues => $"BrojClanova = {BrojClanova}, VrstaGrupeID = {VrstaGrupe.VrstaGrupeID}";

        public List<DomenskiObjekat> GetEntities(SqlDataReader reader)
        {
            List<DomenskiObjekat> list = new List<DomenskiObjekat>();
            while (reader.Read())
            {
                GrupaZaTrening grupa = new GrupaZaTrening
                {
                    GrupaID = reader.GetInt32(0),
                    BrojClanova = reader.GetInt32(1),
                    VrstaGrupe = new VrstaGrupe
                    {
                        VrstaGrupeID = reader.GetInt32(2),
                        NazivVrste = reader.GetString(4)
                    }
                };
                list.Add(grupa);
            }
            return list;
        }

        public DomenskiObjekat GetEntity(SqlDataReader reader)
        {
            GrupaZaTrening grupa = new GrupaZaTrening();

            while (reader.Read())
            {
                grupa.GrupaID = reader.GetInt32(0);
                grupa.BrojClanova = reader.GetInt32(1);
                grupa.VrstaGrupe = new VrstaGrupe
                {
                    VrstaGrupeID = reader.GetInt32(2),
                    NazivVrste = reader.GetString(4)
                };
            }
            return grupa;
        }

        public override string ToString()
        {
            return  VrstaGrupe.NazivVrste+" "+BrojClanova.ToString();
        }
    }
}
