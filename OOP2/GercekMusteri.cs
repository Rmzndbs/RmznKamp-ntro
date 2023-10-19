using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
            //individual -Birey
    internal class GercekMusteri: Musteri       //İNHERİTANCE    //GerçekMusteri bir müşteridir. yani Musteri de olan özellikler artık 
    {                                           // GerçekMusteride de vardır demek. ":"  Alt küme gibi düşün.
                                                 //Sadece bu GerçekMusteriye ait özellikleri burada tutuyoruz. 
          
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string TcNo { get; set; }
    }
}
