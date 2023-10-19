  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    public class MainClass
    {
        static void Main(string[] args) ////pascal case  yani kelimelerin ilk harf büyük yazılır claslarda 
        {
            //birşeyin tekrar tekrar kullanılabilirliği sağlayan kod bloklarıdır(Spete ekle).    do not repeat yourself (DRY) kapsamında.   clean code (temiz düzgün kod yazma)
            //best practice (doğru uygulama taktikleri.)   metotlara en güzen örnek sepete ekle butonu her sayfanın altında çalışır bir kod var onu her yere koyuyorlar 
            //tekrar tekrar yazmamaış oluyorlar.   herşey classlardan oluşur.       // isimlendirmelerde ilk haflar büyük yazılır. bu bir kuraldır.

            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

            string[] meyveler = new string[] { };


            Urun urun1=new Urun();           // yukarıdaki gibi tek tür değil birden fazla türü bir araya getirmek istedim. için Urun adında class'ta  urun1 adında tür oluşturdum.
                                            // ve bu  tür üç ayrı yapıda olsun dedim string ve double yi bir araya getirdim. 
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2=new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };


           // Type safety- Türün güvenliği ön planda
            foreach (Urun alyas in urunler)          //ın urunler yukarıdaki diziden geliyor. alyas bu döngüye koymak istediğin isim ne istersen. Urun ise türü.
            {
          
                Console.WriteLine(alyas.Adi);
                Console.WriteLine(alyas.Fiyati);
                Console.WriteLine(alyas.Aciklama);         //Burada yazdığımız her bir istekleri arraydaki urunleri teker teker dolaşarak sırasıyla yazıyor.
                Console.WriteLine("----------------");

            }


            Console.WriteLine("------------Metotlar-----------");


            //instance -örnek   class örneği oluşturmak.
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);       //metodu bu şekilde çağırıyoruz.  başka sayfada yazdığımız SepetManeger clasındaki Ekle  metodunu  bu sayfaya çağırdık.
            sepetManager.Ekle(urun2);

            //metot bana tekrar tekrar aynı şeyi kullanabilme imkanı vermiş oluyor.  metot =fonksiyon


            Console.WriteLine("---------------ekle alternatifi---------------");

            sepetManager.EkleAlternatif("armut","yeşil armut", 12,20 );    // ürünü böyle de gönderebilrisin ama neden illa class yapıyoruz ????? 

            sepetManager.EkleAlternatif("elma", "yeşil elma", 15,10);         //stokadedi ekleyince bütün sayfaların kızardı patladı. tek tek düzeltmen lazım.

            sepetManager.EkleAlternatif("karpuz", "diyarbakır karpuzu", 10,1 );

            //encapsulation ayrı ayrı calışacağın yapıları bir kapsül içinde düzenlemeye denir. Örnek eklealternatifteki gibi tek tek yazmak yerine bir class oluşturup özelliikleri orada tanımlamak gibi. 
        }

    }




    
}

