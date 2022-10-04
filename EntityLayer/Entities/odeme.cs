using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class odeme
    {
        public int id { get; set; }
        public string yolAdi { get; set; }
        public int parselId { get; set; }
        public int malikId { get; set; }
        public decimal toplamBedel { get; set; }
        public int hazirlayanKullanici { get; set; }
        public int kontrolEden { get; set; }
        public int onayVeren { get; set; }
        public int mysNumarasi { get; set; }
        public DateTime islemTarihi { get; set; }
        public ICollection<Parsel> parselList { get; set; }
    }
}
