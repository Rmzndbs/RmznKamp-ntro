using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDongusu
{
    public class MainClass
    {
        static void Main(string[] args)
        {

            //Sonsuz döngüye düşme ihtimali yüksek olan döngüdür. dikkat etmek lazım.
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Gencay");       //for döngüsünde 100 kere gencay yaz dedik. koşul aralık var anak while da koşul sonsuz.
            }



           // while (true) //(burası koşul)        //while da true mu diyor sonsuz gidiyor.
            {                                      //sonsuza gitmemesi için aşağıdaki gibi yazılır.
                Console.WriteLine("Ramazan");
            }




            bool Kosul = true;//koşul doğruysa
            int Sayac = 90;     //birden başla
            while (Kosul)
            {
                if (Sayac <= 100) { Console.WriteLine("Ramazan Odabaş"); }
                else Kosul = false;
                Sayac++;                                                  //do while döngüsü de var oda önce işlem yapıp sonra koşula bakar.  
                                                                          //while döngüsü ise  önce koşula bakıp sonra işlem yapıyor.






            }
            //1 den 10 a kadar sayı yazdırma işlemi while döngüsü ile.
            int a = 1;
            while (a <= 10) 
            {
                Console.WriteLine(a);                   // a 1 için while döngüsü sürekli başa döner ve tekrar işlemi yapar sonsuz döngye girmemes içinkodun içerisinde a++yani her seferinde a yı 1 arttır yaptık.
                a++;
             }


        }




    }
}


