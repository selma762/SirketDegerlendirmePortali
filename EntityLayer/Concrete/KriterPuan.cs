using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class KriterPuan
    {
        [Key]
        public int Id { get; set; }
        public int KisiId { get; set; }
        public int MeslekKriterId { get; set; }
        public float AldigiPuan { get; set; }
    }
}
