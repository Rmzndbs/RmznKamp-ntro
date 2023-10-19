using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{//topla işlemini defalarca kullanacağımız için metod haline getiriyoruz.
    internal class DortIslem    // Burada hesap makinesi yapacağız.    //şuanda urada işlem değil çağıracağımız metodu yazıyoruz. fonksiyon gibi düşün
    {
        //örneğin toplama işlemini her sayfaya ayrı ayrı çağıracağız bu yüzden her sayfada ayrı ayrı yazamayacağımız için metot'a işleyip çağıracağız.
        public void Topla(int sayi1 , int sayi2)                                                //Toplama yapabilmek için iki tane sayıya ihtiyaç var mantıken.
        {
            int toplam = sayi1 + sayi2;                                        //Topla (2,3) dersek 2 sayi1 e denk gelir 3 sayi2 ye denk gelir. 
            Console.WriteLine("Sonuç : " +toplam);
        }

    }
}
