using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public class MainClass
    {
        static void Main(string[] args)     //İNTERFACELER(Şablon demek)
        {
            //IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();



            //TasitKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();



            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();




            //interfacelerde o interface i implemente eden classın referans numarsını tutabilir!!

            //IKrediManager ihtiyacKrediManager1 = new IhtiyacKrediManager();    //base sınıf bağlantısından dolayı IKrediManager olarakta çalışır.
            //ihtiyacKrediManager.Hesapla();
            //IKrediManager tasitKrediManager1 = new TasitKrediManager();
            //tasitKrediManager.Hesapla();
            //IKrediManager konutKrediManager1 = new KonutKrediManager();
            //konutKrediManager.Hesapla();

           // IKrediManager Bir interface olduğu için newlenemez!!!!!

            IKrediManager ihtiyacKrediManager1 = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager1= new TasitKrediManager();
            IKrediManager konutKrediManager1 = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();       //loglayıcı
            ILoggerService filebaseLoggerService = new FilebaseLoggerService();           //loglayıcı


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager1,databaseLoggerService);   //parametre olarak IkrediManager olarak girdiğimiz için ihtiyaç,konut, taşıt istediğimi gönderebilirim.
                                                                                     //Hangi krediyi gönderdiyesm onun hesaplasını çalıştırmış oluyorum.
            basvuruManager.BasvuruYap(tasitKrediManager1,filebaseLoggerService);

            //basvuruManager.BasvuruYap(tasitKrediManager1);
            //basvuruManager.BasvuruYap(konutKrediManager1);
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), databaseLoggerService);  //newlemeyi yukarıdaki gibi ayrı da yapabilirsin.
                                                                                          //buradaki gibi de newleyebilirsin. Esnaf kredisini !!


            basvuruManager.BasvuruYap(konutKrediManager1, new SmsLoggerService());  //Bu şekilde de newleyebilrisin yukarıda ki gibi ayrı da newleyebilirsin.


            Console.WriteLine("-------------------Birden Fazla Logger Göndermek ----------------------");

            List<IKrediManager> krediler =new List<IKrediManager>() {ihtiyacKrediManager1,tasitKrediManager1 };//bir tane de birden fazla da gönderebiliriz. 
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

            

            List<ILoggerService> loggers = new List<ILoggerService> {new FilebaseLoggerService(),new SmsLoggerService() };
            basvuruManager.BasvuruYap2(new EsnafKredisiManager(), loggers);













        }

    }
}

