using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class KisiDegerlendirme
    {
        [Key]
        public int Id { get; set; }
        public int KisiId { get; set; }
        public int Yil { get; set; }
        public float AldigiDegerlendirmePuani { get; set; }
    }
}
