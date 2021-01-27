using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class UcitajVrsteGrupaSO : ApstraktnaGenerickaOperacija
    {
        protected override object Execute(DomenskiObjekat domenskiObjekat)
        {
            List<VrstaGrupe> vrste = broker.VratiSve(domenskiObjekat).OfType<VrstaGrupe>().ToList();
            return vrste;
        }

        protected override object Execute(List<DomenskiObjekat> domenskiObjekti)
        {
            throw new NotImplementedException();
        }

        protected override void Validate(DomenskiObjekat domenskiObjekat)
        {
            if(!(domenskiObjekat is VrstaGrupe))
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
