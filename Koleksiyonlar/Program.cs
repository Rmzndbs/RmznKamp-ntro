using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar
{
    public class MainClass
    {
        static void Main(string[] args)
        {

            //string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };       //array 4 elemanlı
            //Console.WriteLine(isimler[0]);       //isimlerin 0 ıncı elemanını consola yazdırmak.(yani ilk elemanı)
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            ////isimler[4] = "İlker"; // isimlere 5. elemanı ekledik
            //// Console.WriteLine(isimler[4]);// bu şekilde çalışmaz   çünkü arraylar genişletilemez. ilk ne oluşturduysan odur.

            //isimler = new string[5];    //isimler 5 elemanlı  ve 5. elemanı ilker dersen bu çalışır ama new string dediğin için isimlerin adresi değişti
            //isimler[4] = "ilker";      //HEAPteyeni referans numarası atamış oldun. yani 5. elemanı ilker ama ilk 4 elemanı boş yani  kaybetmiş oldun.
            ////bu yüzden arrayler sık kullanılmaz asıl sık kullanılan KOLEKSİYONLARdır.

            //KOLEKSİYONLAR
            
            List<string>isimler2= new List<string> {"Engin","Murat","Kerem","Halil"};
            Console.WriteLine(isimler2[0]);   //list i biz yazmadık. c# ın bize sunduğu hazır claslardan birisi direkt onu kullandık.
            Console.WriteLine(isimler2[1]);   // kullana bilmek için en üstte usingde using System.Collections.Generic; olması lazım yoksa 
                                              // list yaz solunda çıkan ampulden ekle.
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add ("İlker");      
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]); 

            
             

             






        }




    }
}


