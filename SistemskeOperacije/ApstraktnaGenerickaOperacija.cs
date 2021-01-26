using DBBroker;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public abstract class ApstraktnaGenerickaOperacija
    {
        protected abstract object Execute(DomenskiObjekat domenskiObjekat);
        protected abstract void Validate(DomenskiObjekat domenskiObjekat);
        protected abstract object Execute(List<DomenskiObjekat> domenskiObjekti);
        protected abstract void Validate(List<DomenskiObjekat> domenskiObjekti);

        protected Broker broker = new Broker();

        public object ExecuteSO(DomenskiObjekat domenskiObjekat)
        {
            object rezultat = null;
            try
            {

                Validate(domenskiObjekat);
                broker.OtvoriKonekciju();
                broker.BeginTransaction();
                rezultat = Execute(domenskiObjekat);
                broker.Commit();
            }
            catch (Exception)
            {
                broker.RollBack();
            }
            finally
            {
                broker.ZatvoriKonekciju();
            }

            return rezultat;
        }

        public object ExecuteSO(List<DomenskiObjekat> domenskiObjekti)
        {
            object rezultat = null;
            try
            {

                Validate(domenskiObjekti);
                broker.OtvoriKonekciju();
                broker.BeginTransaction();
                rezultat = Execute(domenskiObjekti);
                broker.Commit();
            }
            catch (Exception)
            {
                broker.RollBack();
            }
            finally
            {
                broker.ZatvoriKonekciju();
            }

            return rezultat;
        }
    }
}
