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
    public class KisiDegerlendirmeManager : IKisiDegerlendirmeService
    {
        IKisiDegerlendirmeDal _kisiDegerlendirmeDal;

        public KisiDegerlendirmeManager(IKisiDegerlendirmeDal kisiDegerlendirmeDal)
        {
            _kisiDegerlendirmeDal = kisiDegerlendirmeDal;
        }

        public void TAdd(KisiDegerlendirme t)
        {
            _kisiDegerlendirmeDal.Insert(t);
        }

        public void TDelete(KisiDegerlendirme t)
        {
            _kisiDegerlendirmeDal.Delete(t);
        }

        public KisiDegerlendirme TGetByID(int id)
        {
            return _kisiDegerlendirmeDal.GetByID(id);
        }

        public List<KisiDegerlendirme> TGetList()
        {
            return _kisiDegerlendirmeDal.GetList();
        }

        public void TUpdate(KisiDegerlendirme t)
        {
            _kisiDegerlendirmeDal.Update(t);
        }
    }
}
