using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3 //bir classa birden fazla inferface bağlayabilirsin örnek: TasitKrediManager:IloggerService,IkrediManager , bu iki interface le bağlantısı mantığı yok ama birde fazla ınterface bağlayabileceğini bil virgülle ayır.
{//BASE SINIF-İNTERFACE!!!     İnterface: ara yüz demek yani şablon demek!!

    //interface =birbirinin alternatifi olan ama kod içerikleri farklı olan durumalr için kullanırız.
    //NOT: Bütün krediler hesapla işini farklı ele alıyor. Her kredi için farklı oranlar , rakamlar var yani tek başına bir anlam ifade etmiyor. 
    //Yani imzanın (hesapla()) aynı olduğu ama içerisinin farklı olduğu durumlarda Base de oluşturduğumuz Class ı clas olarak değilde İNTERFACE
    // olarak oluştururuz. OOP2 ye bak interface olunca farklı oluyor.class siliyoruz ,void de süslü parantez yok., public yok
    //Bir İNTERFACE şunu anlatır= birisi KrediManager interfaceini kullanırsa o arkadaşım örn, interface deki metodları içermek zorunda
    //örn, TaşırKrediManager , KrediManager interfaceini kullanmak istiyorsa içerisinde hesapla ve bişeyyap metodunu içermek zorunda.
    //Okunulurluğunu arttırmak için interfaceler I harfi ile başlatılır ki interface olduğu anlaşılsın.

    //Hesapla ve biseyyap bunlar her kredide olamsı gereken metotlar.Bunu zorunlu hale getirmiş oluyoruz.
    //İnterface Şablon demek bizde bütün krediler  aşağıdaki şablona yani hesapla ve bişeyyap a uymak zorunda diyoruz
    //İnterfacelerde Newlemek olmaz !!
    //internetlerimize servis diyeceğiz.
    interface IKrediManager
    {
        void Hesapla();
        void BiseyYap();
       
    }
}
