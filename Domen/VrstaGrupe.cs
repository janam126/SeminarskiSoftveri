using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class VrstaGrupe : DomenskiObjekat
    {
        public int VrstaGrupeID { get; set; }
        public string NazivVrste { get; set; }

        public string TableName => "VrstaGrupe";

        public string InsertValues => $"'{NazivVrste}'";

        public string JoinFull => throw new NotImplementedException();

        public string JoinTable => throw new NotImplementedException();

        public string KriterijumPretrage => $"VrstaGrupeID = {VrstaGrupeID}";

        public string UpdateValues => $"NazivVrste = '{NazivVrste}'";

        public List<DomenskiObjekat> GetEntities(SqlDataReader reader)
        {
            List<DomenskiObjekat> list = new List<DomenskiObjekat>();
            while (reader.Read())
            {
                VrstaGrupe vrsta = new VrstaGrupe
                {
                    VrstaGrupeID = reader.GetInt32(0),
                    NazivVrste = reader.GetString(1)
                };
                list.Add(vrsta);
            }
            reader.Close();
            return list;
        }

        public DomenskiObjekat GetEntity(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return NazivVrste;
        }
    }
}
