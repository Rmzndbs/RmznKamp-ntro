using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class SepetManager// manager, dal, service , dataaccess gibi ifadeler görürsek bunlar bir operasyon tutuyor anlamına geliyor. Nasıl ki classlarda prop yani özellik tutuyorsak manager da operasyon tutuyoruz.
    {//naming convention- isimlendirme kuralı  metodları büyük harfle başlat.
        public void Ekle(Urun urun)   // eğer bir yerde normal parantez görüyorsan anla ki orada metot çalışıyor.   // parametre olarak urun ekledik.
        {// ne ile çalışacağını parametre olarak veriyoruz. Urun tipi demek urun ise birazdan aşağıda yazacağımız kodlarda kullanmak için isimlendirme.
            // ekle diyince ne ekleyeceğim Urun bu kadar basit.
            Console.WriteLine(" Tebrikler Sepete Eklendi.  : "+urun.Adi);     // biz bir satır yazdık normalde 100 lerce satırda olabilir. buradaki amaç ben Ekle yi çagıracağım publıc void ekle bloğu
                                                      // tamamen  çağırmış olacağım. Ekle bloğun

        }

        //bir tane daha metot yapıyoru. burayı anlamazsan matematik çalışmasına gir hesap makinesinde basit olarak anlatmaya çalıştık.

        //yukarında ki Ekle için alternatif bir metot yazdık.  yukarıdaki başka bir metot bu başka bir metot. 

        //Bir classın içinde birden fazla metot olabilir. 

        public void EkleAlternatif(string urunAdi , string aciklama , double fiyat, int stokAdedi)  //  buradaki gibi alternatifin içine tek tek yazmak hata! zaten tek tek
            //yazmamak için yukarıdaki Ekle metodundaki gibi daha önce Uruncs de yazdığımız class ı kullandık. içindeki ürünlerin Urun clası ile ilgisi yok. normal değişken bunlar.

            
        {
            Console.WriteLine("Tebrikler . Sepete eklendi : " + urunAdi  );     // urunu void alternatigteki gibi tek tek de yazabilrizi neden yazmamalıyız ?????
                                                                            // class olarak yazmalıyız sebebi ise ilerde değişiklik yapmak istersen tek tek mi düzelteceksin!!!
                                                                            //örnek firma dedi ki buna stokadedini de ekle tek tek eklemek zorudnasın parametreleri düzgün kullan.


        }

    }
}