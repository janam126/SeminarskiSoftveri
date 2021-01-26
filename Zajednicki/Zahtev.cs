using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajednicki
{
    [Serializable]
    public class Zahtev
    {
        public Operacija Operacija { get; set; }
        public Trener Trener { get; set; }
        public Clan Clan { get; set; }
    }

    public enum Operacija
    {
        LogIn,
        VratiGrupe,
        UbaciClana
    }
}
