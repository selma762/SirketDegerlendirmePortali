using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Kisi
    {
        [Key]
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string DogumTarihi { get; set; }
        public string Tel { get; set; }
        public string Mail  { get; set; }
        public string Cinsiyet { get; set; }
        public int MeslekId { get; set; }
        public int EgitimId { get; set; }
        public float TahminiMaas { get; set; }
        public int OncekiHizmetSuresi { get; set; }
        public DateTime SirketteİseBaslamaTrarihi { get; set; }
    }
}
