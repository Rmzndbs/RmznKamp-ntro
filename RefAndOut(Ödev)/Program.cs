
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    public class MainClass
    {
        static void Main(string[] args)
        {

            //var result = Add2(20, 30);
            //Console.WriteLine(result);

            //var result1 = Add3(20); // default deger tanımladığımız için sadece 20 yazdım number4 ü direkt 30 aldı
            //Console.WriteLine(result1);


            //int number = 10;
            //int number1 = 20;                        //number1 20 tanımladım ancak metodda 30 tanımladım. eğer metodda tanımladığım değerin
            //int number2 = 100;                       //çalışmasını istiyorsam onu ref atıyorum metodu referans al demek gibi birşey.
            //var result2 =Add4(ref number1 , number2);
            //Console.WriteLine(result2);
            //var result3 = Add5(out number, number2);

            Console.WriteLine(Multiply(2, 8));
            Console.WriteLine(Multiply2(2,6,5));
            Console.WriteLine(Add10(1,2,3,4,5,6,7,8));



            
        }
        //static int Add2(int number1, int number2) //bana 2 ayrı sayı ver diyor parametre
        //{
        //   var result = number1 + number2;
        //    return result;


        //}

        //static int Add3(int number3, int number4=30)   //number3 verilmek zorunda ancak number4 eğer verilmezse 30 al demek.
        //{                                              //buna default parametre deniliyor. (default= varsayılan demek)
        //    var result2 = number3 + number4;          //default değerler her zaman metodun sonunda olması gerekiyor. number3=30 diyemezsin.
        //    return result2;
        //}
        //static int Add4( ref int number1, int number2)   // ref dediğim için atadığım değeri değil metodun içindeki değeri baz alacak.
        //{
        //    number1 = 30;
        //    return number1 + number2; 


        //}
        //Out keywordu de ref ile aynı mantıkta çalışır. tek farkı şu ref keywordunde number1= 20 ; diye atama yapmak zorundasın. ancak
        //out da number = ; diyebilirsin değer atamak zorunda değilsin. 
        //static int Add5(out int number, int number2)   // ref dediğim için atadığım değeri değil metodun içindeki değeri baz alacak.
        //{
        //    number = 30;                       // out da değer metodun içerisinde yer alması lazım.
        //    return number + number2;


        //}

        //şimdi yeni konu metotların overload aşırı yüklenme

        static int Multiply(int number1, int number2)    //çarpma metodu yazdık. 
        {
            return number1 * number2;
        }

        static int Multiply2 (int number1 , int number2, int number3)// 3 parametreli yazdık. aşırı yükledik arttırdık buna diyorlar. 
        {
            return (number1 * number2 * number3);
        }
        static int Add10(params int[] numbers) // over load yapıp arttırıyorum da ben bunu her arttırdığımda overloard mıyapıcaz 
        {                                                       // tabiki hayır! onun için params keywordunde yazılır.!!
            return numbers.Sum();    // bu sum hazır fonksiyon.       params olarak dizi tanımladık. 
                                     // verilen rakamları topla demek.
        }
    }
}

