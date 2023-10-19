using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class TuzelMusteri: Musteri  //bu ":" işlemi İNHERİTANCE //corporate= Kurumsal demek    -- TuzelMusteri bir müşteridir.
                                          // Musteri de olan özellikler artık TüzenMusteri de de vardır demek.  Alt küme
    {                                      //Sadece TuzelMusteri ye ait özellikleri burada tutuyoruz. 
        public int Id { get; set; }
        public string MusteriNo { get; set; }
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
