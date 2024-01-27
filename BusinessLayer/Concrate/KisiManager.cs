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
    public class KisiManager : IKisiService
    {
         IKisiDal _kisiDal;

        public KisiManager(IKisiDal kisiDal)
        {
            _kisiDal = kisiDal;
        }

        public void TAdd(Kisi t)
        {
            _kisiDal.Insert(t);
        }
        
        public void TDelete(Kisi t)
        {
            _kisiDal.Delete(t);
        }

        public Kisi TGetByID(int id)
        {
            return _kisiDal.GetByID(id);
        }

        public List<Kisi> TGetList()
        {
            return _kisiDal.GetList();
        }

        public void TUpdate(Kisi t)
        {
            _kisiDal.Update(t);
        }
    }
}
