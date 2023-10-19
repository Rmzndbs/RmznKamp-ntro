using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    public class MainClass
    { //döngüler birbirine benzeyen işlemleri tekrar etmek için kullanılır. 
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)                          //döngülerin mantığı kendisi içerideki şartı sağlayana kadar sürekli başa alıp tekrar etmesi yani dönmesi.
            {                                             // Örneğin burada i=1 olarak başla diyor.  i 10 dan küçük eşit şartını sağlayana kadar dön çalış diyor. buda 
                Console.WriteLine(i);                   // 1,2,3,4,5,6,7,8,9,10  olarak yansıt demek.     i++ ise bir bir art demek.
            }                                           //block şartı sağladığı sürece başa dönerek sürekli çalışır.



            for (int i = 1; i <= 8; i=i+2 )
            {
                Console.WriteLine(i);                  //Burada da 2 2 say demek i=i+2 yani 1,3,5,7   en fazla 8  e kadar olduğu için burada bitirdi.
            }



            string Kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";  //Burada dizileri(Array) işliyor tek tek strigler tanımlamaktansa tek bir dizi de bütün stringleri tanımla!
            string Kurs2 = "Programlamaya Başlangıç için temel Kurs";// tek tek yazılmaz ilerde kurs eklendiği zaman ciddi problem olur
            string Kurs3 = "Java ";
            string Kurs4 = "Python";
            

            string[] Kurslar = new string[ ] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya Başlangıç için temel Kurs", "Java","Phyton" ,"Ramazan Odabaş Başarı Öyküsü"};

            for (int i = 0; i < Kurslar.Length; i++)   //i<4 (4 elemanlı) de diyebilirsin ama doğrusu Kurslar.length(eleman sayısı) demek bu kurslar kaç elemanlıysa ona göre dön çalış demek.
            {
                Console.WriteLine(Kurslar[i]);  // ben burada kursların i.ci elemanını yazdırmak istiyorum.
                // Bu Yukarıda yazdığın array(dizi) sayacı sıfırdan başlat 0. elamanı çalıştır , 1. elemanı çalıştır , 2. elemanı  çalıştır yani 3 tane kursu ekrana yazdırdı. 

            }                                    //diziyi döngü ile bağladık. arrayi döngüde çalıştırdık. (programlama dilleri genelde saymaya sıfırdan başlar 
            Console.WriteLine("For Bitti  ");


            //Foreach Dizi temelli yapıları tek tek dönmeye yarıyor. foreach döngüsü    Fordan daha kolay 

            foreach (string kurs in Kurslar)        // Kursları tek tek dolaş demek. Kurslar ne? Yukarıdaki yazdığımız dizi Array   //freach (string Kurs(bu kurs alyas takma ad ne istersen onu de) in Kurslar(Bu Kurslar da Yukarıda ki dizimiz Array))
            {
                Console.WriteLine(kurs);  // Buradaki Kurs foreach da koyduğum isim döngünün ismi -Kurs dizileri dolaşırken her biri için verdiğimiz takma isim  
            }
        }

    }
}

