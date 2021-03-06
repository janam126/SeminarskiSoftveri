﻿using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class UcitajGrupuZaTreningSO : ApstraktnaGenerickaOperacija
    {
        protected override object Execute(DomenskiObjekat domenskiObjekat)
        {
            GrupaZaTrening grupa = (GrupaZaTrening)domenskiObjekat;
            return broker.VratiJedan(grupa);
        }

        protected override object Execute(List<DomenskiObjekat> domenskiObjekti)
        {
            throw new NotImplementedException();
        }

        protected override void Validate(DomenskiObjekat domenskiObjekat)
        {
            if (!(domenskiObjekat is GrupaZaTrening))
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
