using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
    public class GirisBilgisiManager : IGirisBilgisiService
    {
        IGirisBilgisiDal _girisBilgisiDal;

        public GirisBilgisiManager(IGirisBilgisiDal girisBilgisiDal)
        {
            _girisBilgisiDal = girisBilgisiDal;
        }

        public void TAdd(GirisBilgisi t)
        {
            _girisBilgisiDal.Insert(t);
        }

        public void TDelete(GirisBilgisi t)
        {
            _girisBilgisiDal.Delete(t);
        }

        public GirisBilgisi TGetByID(int id)
        {
            return _girisBilgisiDal.GetByID(id);
        }

        public List<GirisBilgisi> TGetList()
        {
            return _girisBilgisiDal.GetList();
        }

        public void TUpdate(GirisBilgisi t)
        {
            _girisBilgisiDal.Update(t);
        }
    }
}
