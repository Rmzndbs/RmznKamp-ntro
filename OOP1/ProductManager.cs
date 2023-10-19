using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ProductManager
    {
        //ProducktManager yada ProcutService gibi isimlendirmelerde anlakı burada ürünle ilgili operasyonlar var.,
        //operasyonlar ekleme , silme , arama , güncelleme , filtreleme vsvs gibi şeyleri içerir.
        public void Add(Product product)    //bu metot diyor ki sen bana Product türünde birşey göndereceksin ben onu product ismiyle tutacağım.
            //ProductManagerin içinden çağıracansın adı Add ve parametre olarak Product türünde birşey ver.//ekleme operasyonu

        {
            Console.WriteLine(product.ProductName+" Eklendi"  );  //void kullandım çünkü ekleyecek bitecek ek birşey yapmayacağım
        
        }
        public void Update(Product product)      //Update güncelleme demek.
        {
            Console.WriteLine(product.ProductName + " Güncellendi");    //burada da void yaptım.

        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        //ARA KONU KONUYLA ALAKASI YOK 
        // void : emir kipinde git ekle,git güncelle ona bir emir kipnde onu çağırıyoruz. bu işlem socunuda ekstra bir bilgiye ihtiyacın 
        //yoksa onu void de yazarsın. void yapar ve bitirir başka yerde kullandırmaz.


        //public int Topla(int sayi1, int sayi2)   //burada int kullandık bunun sonucunu kullanarak farklı kod yazabilirsin.
        //                                         //return  dönmek demek sonucu kullanmana izin veriyor.   
        //{
        //  return sayi1 + sayi2;   
        //}


        //public void Topla2(int sayi1, int sayi2) //burada iki sayı verelim örnek 3,6 toplamı 9 der ve biter o 9 sonucunu başka yerde kullana
        //                                         //mazsın  similasyonu programcs de

        //{
        //    Console.WriteLine(sayi1+sayi2);
        //}




    }
}
