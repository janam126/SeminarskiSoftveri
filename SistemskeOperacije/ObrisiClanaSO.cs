using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class ObrisiClanaSO : ApstraktnaGenerickaOperacija
    {
        protected override object Execute(DomenskiObjekat domenskiObjekat)
        {
            Clan clan = (Clan)domenskiObjekat;
            if (broker.Obrisi(clan) > 0)
            {
                return true;
            }
            return false;
        }

        protected override object Execute(List<DomenskiObjekat> domenskiObjekti)
        {
            throw new NotImplementedException();
        }

        protected override void Validate(DomenskiObjekat domenskiObjekat)
        {
            if (!(domenskiObjekat is Clan))
            {
                throw new ArgumentException();
            }
        }

        protected override void Validate(List<DomenskiObjekat> domenskiObjekti)
        {
            throw new NotImplementedException();
        }
    }
}
