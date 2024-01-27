using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    //IEgitimDal intefacesini kullnamamızın nedeni projenin ilerleyen aşamalarında CRUD operasyonları
    //dışında istenilen entity özel işlem yapılmak istenirse Egitim Dalda imzası atılıp içerisi burada doldurulacaktır.
    public class EfEgitimDal : GenericRepository<Egitim>,IEgitimDal
    {

    }
}
