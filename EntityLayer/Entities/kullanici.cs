using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class kullanici
    {
        [Key]
        public int id { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string unvan { get; set; }
        [StringLength(11)]
        public string tcKimlikNo { get; set; }
    }
}
