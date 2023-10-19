using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class BasvuruManager
    {//Hangi krediye göre başvuru yapaağını belirlenmeli bunları teker teker de yazamayayız bu yüzden interface olan ve hepsinin referansını turan 
        //IKrediManager olarak tutabilirim.
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)    //Elimde herkesin referansını tutabile bir tür olduğu için parametre olarak onu veririz. 
        {
            //başvuran bilgilerini değerlendirme 
            krediManager.Hesapla();   // IKrediManager üzerinden işlem yaptığımız için ben () içine ihtiyaç versem onun hesaplasını çalıştırır.  
                                      //taşıt versem bellekteki taşıt kredinin hesaplası çalışır . ona göre konut versem ona göre hesaplama yapar. 



            loggerService.Log();      //Logger konusudnan sonra ekledik bunları dersin devamı, parametreye ve buraday



        }
        //Aslında burada method injection yapıyoruz yani bu metodun kullanacağı kredinin ne olacağını, loglayıcının ne olacağını enjecte ediyoruz.

        //Banka örneğini düşün bankadaki memurla konuşuyorsun. sana bir tane yada birden fazla kredi önerisinde bulunacak. sayısı belli değil 
        //sonuçta yüzlerce kredi var ona uygun bir önbilgilendirme kodu yazacağız. ve sayı belli olmadığı için lisle ile yapıyoruz.
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler) //Aynı veri türünde(IKrediManager) belli sayıda ve o sayıda belirsizse List kullanılır.
        {                                                               //Bana bir liste ver adı krediler olsun veri türü de IKrediManager olsun. 0 tane de alabilir yüzlerce de.

            foreach (var kredi in krediler)
            {
                kredi.Hesapla();         //kredilerdeki her bir kredinin hesaplasını yap. her birini tek tek dolaş hesapla
            }
        }

        public void BasvuruYap2(IKrediManager krediManager, List<ILoggerService> loggerServices)   //Bir tane log yollamayacağım birden fazla yollayacağım için List yapıyorum.
        {
            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)   //Birden fazla yollayacağım için her bir logger ı çalıştır, dön diyorum.
            {
                loggerService.Log();   // her bir loglayıcıyı çalıştır.
            }
        
        
        } 
    }
}
