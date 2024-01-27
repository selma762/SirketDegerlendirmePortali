using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Kriter
    {
        [Key]
        public int Id { get; set; }
        public string KriterAdi { get; set; }
        public int KriterAgirligi { get; set; }
        public bool  OrtakÖzellikMi { get; set; }
    }
}
