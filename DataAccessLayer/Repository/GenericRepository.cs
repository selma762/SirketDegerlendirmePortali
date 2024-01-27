using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T t)
        {
            using var c = new Context();
            c.Remove(t);//t olarak gelen değerin silme işlemini yapıldı ama veri tabanına yansıtılmadı.
            c.SaveChanges();//veri tabanına yansıtma işlemi yapıldı.
        }

        public T GetByID(int id)
        {
            using var c = new Context();
            return c.Set<T>().Find(id);//T den gelen değeri ayarlanıp id den gelen değer bulunur..
        }

        public List<T> GetList()
        {
            using var c = new Context();
            return c.Set<T>().ToList();//Tden gelen değerlerler listelendi.
        }

        public void Insert(T t)
        {
            using var c = new Context();
            c.Add(t);
            c.SaveChanges();
        }

        public void Update(T t)
        {
            using var c = new Context();
            c.Update(t);
            c.SaveChanges();
        }
    }
}
