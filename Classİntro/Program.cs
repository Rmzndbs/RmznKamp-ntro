using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntro    // proje işimleri pascalcase yani ilk harferi büyük yazılır.
                        // değişkenler veri tutuculardır.     
                        //type safety- tip güvenliği  - a başına türünü belirtmek zorundayız.

{
    public class MainClass
    {



        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);



            string adi = "Engin";
            int yas = 36;

            Kurs kurs1 = new Kurs();    //Senin artık kurs1'in var tipi Kurs ve birdenf azla eleman içeriyor.
            kurs1.KursAdi = "Phayton";
            kurs1.İzlenmeOrani = 68;             // yeni clasımız olan yani türümüz olan kurs1'i altta 3 farkı değerde tanımladığımız için onları teker teker belirtik. 
            kurs1.Egitmeni = "Engin Demirog";


            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "C#";                               // 3 tane kurs değişkenini yeni yazdığım class ile tanımladım yeni türde
            kurs2.İzlenmeOrani = 50;
            kurs2.Egitmeni = "Ramazan Odabaş";

            Kurs kurs3 = new Kurs();                //Clasta birden çok özellik tanımlamış oluyoruz. Önce class satırında tanımlamalar yaptık sonra yazmaya başladık.
            kurs3.İzlenmeOrani = 100;
            kurs3.Egitmeni = "Furkan Totabas";
            kurs3.KursAdi = "Java";


            Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmeni+" "+kurs1.İzlenmeOrani);
            Console.WriteLine(kurs2.KursAdi+" "+ kurs2.Egitmeni+" "+kurs2.İzlenmeOrani);
            Console.WriteLine(kurs3.KursAdi+" "+kurs3.Egitmeni+" "+ kurs3.İzlenmeOrani);


            Console.WriteLine("Bu kısım bitti");
            //Bunu dizi olarak yazmak istersek önceki döngülerde string[] Kurslar = new string[] {}; Örneğinde  olduğu gibi onu Kurs olarka yazıyorsun yani;

            Kurs[] Kurslar = new Kurs[] {kurs1,kurs2,kurs3};       //Kurslar benim koyduğum takma isimdir. Kurs türü olan olan bir dizi yani array tanımladım. 
            foreach (Kurs alyas in Kurslar)
            {
                Console.WriteLine(alyas.KursAdi);        //yukarı alyas adını koyduğum foreach döngüsündeki krus adlarını yaz demek. Kurslar döngüsünü tek tek dönüyor. 
                Console.WriteLine(alyas.Egitmeni + ": " + alyas.İzlenmeOrani);
                
            }


        }
 
    }
    class Kurs    //Sanki sen kendi veri tipini yazıyormuşsun gibi düşün, integer gibi string gibi flood gibi bende Kurs adında veri tipi yazıyorum
    {
        public string KursAdi { get; set; }
        public string Egitmeni { get; set; }         //Kurs türü oluşturuyorum ve bu türde kendim string de int de tanımladım birleşik bir tür yarattım.
        public int İzlenmeOrani { get; set; }
    }
}

