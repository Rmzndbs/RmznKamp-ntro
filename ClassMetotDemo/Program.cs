using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class MainClass
    {
        static void Main(string[] args)
        {
            // classlar ikiye ayrılı içinde özellik barındıranlar ve içerisinde operasyon (metot) barındıranlar!!
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Ramazan";
            musteri1.Soyad = "Odabas";
            musteri1.Id = 10;

            Musteri musteri2= new Musteri();
            musteri2.Ad = "Furkan";
            musteri2.Soyad = "Budabaş";
            musteri2.Id = 20;
            
            Musteri musteri3= new Musteri();
            musteri3.Ad = "Yavuz";
            musteri3.Soyad = "Şudabaş";
            musteri3.Id = 30;


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Silme(musteri2);
            musteriManager.Listele(musteri3);

            Console.WriteLine("------------------kendim yeni deneme listeleme yöntemi------------------------");
            
            
            
        
  
            


            
        }




    }
}


