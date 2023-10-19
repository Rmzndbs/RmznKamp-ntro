using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    public class MainClass
    {
        static void Main(string[] args)
        {

            //Switch-case Kodun akışında belirli bir şarta göre yönlendirme yapmamızı (farklı algoritma çalıştırmamızı yada farklı operasyon gerçekleştirmemzi sağlar.
            //switch-case yapılanması bir değişkenin değerinin sadece eşitlik durumlarını kontrol ederken kullanılabilir. yani eşit mi yada eşit değilmi diyorsun mantık bu kadar.

            //Özelliği sadece eşitlik durumuna bakılır. Eşit mi değil mi bu kadar. 

            //switch (...Değer yazılır...)      Eşitlik durumu kontrol edilecek olan değer yazılmalıdır. 
            // switch-case yapılanmasıda kontrol edilen değer ile eşitlik sağlayan değer var ise diğer caselere bakmaksızın switch bloğundan çıkılacaktır. 
            //switch -case de hiçbir case eşitliği sağlayamıyorsa default ile break arasındaki kod çalışacaktır. default kalıbı zorunlu değildir.


            string adi = "Ahmet";

            switch (adi)         //Kontrol edilen değerin türü neyse case bloklarındaki değerlerde aynı olmak zorundadır. string se string int ise int dir. aynı tür oalcak.

            {
                case "mehmet":
                    Console.WriteLine("Adı Mehmet");  //yukarıda string tanımladık adı ahmet  case de adı mehmet ise break ile case arasındaki kodu yazdırır. değilse diğer case e geçer.
                    break;
                case "Ayşe":
                    Console.WriteLine("Adı ayşe");   //adı ayşe mi diye kontrol eder. öyleyse kodu yazdırır değildi diğer case e geçer

                    break;
                case "Hilmi":
                    Console.WriteLine("Adı Hilmi");   //caselerdeki değerler statik yani sabir değerler olmak zorundadır. değişken olamaz!!  case "ayse": burada değişken değer olmaz.
                    break;
                case "Ahmet":
                    Console.WriteLine("Adı Ahmet"); // ahmet eşit mi ever bunu çalıştırır ve switch blogundan çıkar
                    break;
                default:           //default u else blogu gibi düşüebilirsin. 

                    Console.WriteLine("Hiçbiri eşit değil");     //default eğer hiçbiri eşleştirmeye uymuyorsa konulabilir. konulmak zorunda değil.
                    break;

                    // case bloklarıın sıralamsı ve defaultun yerleştirildiği yer önemli değildir. 

            }


        }




    }
}


