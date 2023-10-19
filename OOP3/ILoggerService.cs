using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3    //bir classa birden fazla inferface bağlayabilirsin örnek: TasitKrediManager:IloggerService,IkrediManager , bu iki interface le bağlantısı mantığı yok ama birde fazla ınterface bağlayabileceğini bil virgülle ayır.
{//projemizde loglama yapmak istiyoruz.
 //Loglama:kim ne zaman hangi operasyonu çağırdığıdır. Yani bir nevi o sistemde olan hareketleri döktüğümüz bir dökümdür.!!
 //farklı yöntemlerle uygulanabilir ,logları dosyada , veritabanında , smsde ,mailde , sitemizde  vsvs alternatifleri çok hepsinin imzası aynı ama
 // veri tabanına yazarken , sms atarken , mailde , dosyada yani hepsinin kodları farklıdır.
 //interfacelere servis diyeceğiz.
    internal interface ILoggerService
    {
        void Log(); 
    }
}
