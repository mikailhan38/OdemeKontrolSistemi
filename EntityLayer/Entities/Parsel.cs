using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Parsel
    {
        public int id { get; set; }
        public string ada { get; set; }
        public string parsel { get; set; }
        public string il { get; set; }
        public string ilce { get; set; }
        public string mahalle { get; set; }
        public decimal kamBedel { get; set; }
        
    }
}
