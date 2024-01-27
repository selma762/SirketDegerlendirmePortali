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
    public class KriterManager : IKriterService
    {
        IKriterDal _kriterDal;

        public KriterManager(IKriterDal kriterDal)
        {
            _kriterDal = kriterDal;
        }

        public void TAdd(Kriter t)
        {
            _kriterDal.Insert(t);
        }

        public void TDelete(Kriter t)
        {
            _kriterDal.Delete(t);
        }

        public Kriter TGetByID(int id)
        {
            return _kriterDal.GetByID(id);
        }

        public List<Kriter> TGetList()
        {
            return _kriterDal.GetList();
        }

        public void TUpdate(Kriter t)
        {
            _kriterDal.Update(t);
        }
    }
}
