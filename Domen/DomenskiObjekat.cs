﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public interface DomenskiObjekat
    {
        string TableName { get; }
        string InsertValues { get; }
        string JoinFull { get; }
        string JoinTable { get; }
        string KriterijumPretrage { get; }
        string UpdateValues { get; }
        List<DomenskiObjekat> GetEntities(SqlDataReader reader);
        DomenskiObjekat GetEntity(SqlDataReader reader);
    }
}
