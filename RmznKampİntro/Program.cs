using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RmznKampİntro
{
    public class MainClass
    {
        static void Main(string[] args)
        {
            //değişken oluştururken ilk harf küçük yazılır daha sonra gelen kelimeler birleşik ve büyük yazılır. 

            // proje işimleri pascalcase yani ilk harferi büyük yazılır.

            // değişkenler veri tutuculardır.     
            //type safety- tip güvenliği  - başına türünü belirtmek zorundayız.

            string kategoriEtiketi = "KategorilerOlarak değiştir dedi";     //Type safety tip güvenliği ön planda bu yüzden başında type (veri türü var).

            Console.WriteLine(kategoriEtiketi);// kendini tekrarlama değişkene tanımla tek tek yazmak büyük hata olur!
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);


            int ogrenciSayisi = 32000;     // İnteger sayısal değerler için (tam sayılar) veri türü.
            double faizOrani = 1.45;   // double ise ondalıklı sayılar için geçerli olan veri tipidir. 





            bool sistemeGirisYapmisMi = true;// sisteme giriş yapmış mı true- false iki durumu belirtiyorsun bunun bool ile yapıyorsun.


            if (sistemeGirisYapmisMi == true)// şart yazılır. şartı sağlarsa geçerşi kod çalışır.
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");               // if yazıp tab tab yaparsan şablon karşına çıkıyor.
            }                                                                // If ( İçine Şartı yazıyorsun) { Şartı sağlarsa çalıştıracağı kodu yaz}    
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }


            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)// şartı içine yazılır şartı sağlıyorsa parantezdeki kod çalışır. 
            { 
                Console.WriteLine("Azalış Oku"); 
            }
            else if (dolarDun < dolarBugun)     //2. şart olarak düşün. 
            {
                Console.WriteLine("Artış Oku");
            }
            else    // hiçbir şart sağlamazsa bunu çalıştır.    
            { 
                Console.WriteLine("Değişmedi Oku"); 
            }
        }

    }
}
