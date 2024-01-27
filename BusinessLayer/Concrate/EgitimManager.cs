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
    public class EgitimManager : IEgitimService
    {
        IEgitimDal _egitimDal;

        public EgitimManager(IEgitimDal egitimDal)
        {
            _egitimDal = egitimDal;
        }

        public void TAdd(Egitim t)
        {
            _egitimDal.Insert(t);
        }

        public void TDelete(Egitim t)
        {
            _egitimDal.Delete(t);
        }

        public Egitim TGetByID(int id)
        {
            return _egitimDal.GetByID(id);
        }

        public List<Egitim> TGetList()
        {
            return _egitimDal.GetList();
        }

        public void TUpdate(Egitim t)
        {
            _egitimDal.Update(t);
        }
    }
}
