using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2   //nesne yönelimli programlama  //soyutlamanın mantığını kapmaya çalış.
{
    public class MainClass
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri(); //musteri1. yaptığımızda Id ve MusteriNo GerçekMusteri Classında olmamasına 
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";                   //Ragmen geliyor. ":" sayesinde. (inheritance sayesinde)
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "12345678910";


            TuzelMusteri musteri2 =new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.İo";
            musteri2.VergiNo = "123456789";


             


                                                      //eğer senin base sınıfın varsa o sınıf referans tutucudur.
            Musteri musteri3 = new GercekMusteri();   //Musteri classı hem GercekMusterinin referansını tutabiliyor hemde TuzelMusterinin
            Musteri musteri4 = new TuzelMusteri();    // referansını tutabiliyor!!  Bu yüzden MusteriManagerde parametreyi Musteri olarak verdik. 
            
            
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1); //Musteri1 GerçekMusteri classı MusteriManagerde parametrede Musteri istemesine rağmen kızmadı neden? İnheritance
            musteriManager.Ekle(musteri2); //Musteri2 TuzelMusteri classı MusteriManager parametrede Musteri istemesine rağmen kızmadı neden? İnheritance
            musteriManager.Ekle(musteri3);  //Bunları bana sağlayan inheritance'dır.
            musteriManager.Ekle(musteri4); 
            

        }

    }
}

