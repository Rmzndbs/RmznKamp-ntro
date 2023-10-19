    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class MainClass
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;     //2 numara mobilyaya karşılık geliyormuş gibi düşün    bu productı bu şekilde oluşturabiliriz.
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            // yukarıdaki bir seçenek bunu şu şekilde de oluşturabiliriz. 
            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Kalem", UnitPrice = 35 };
            //ister 2 yukarıdaki gibi tek tek yaz istersen hemen üstteki gibi {} içinde yaz ikiside aynı şey. 
            //Pascal case kelimelerin ilk harfi büyük yazılır bu class olduğu anlamına gelir.   
            //Camel Case ile kelimelerin ilk harfinin küçük diğre harflerinin büyük olarak yazılması demek. 
            //case sensitive büyük harf küçük harf duyarlılığıdır.

            //ProductManager productManager = new ProductManager();
            //ProductManager türüsndeki(clasındaki) productManager(istersen x yaz ama doğru yazım bu) isminde
            //=new ise head de yeni bir ProductManager numarası almış demek. sol taraf stack = sağ taraf Heapp
            //ProductManager productManager(STACK bellek)=new PruductManager(HEAP bellek)
            //string isim ="Engin" string türünde isim adında bir isim Engin tanımladık. yukarıdakinin mantığı bu.
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);      //Ekleyeceğim de ne ekleyeceğim işte o parantezin içi parametre(değişken, değişen şeyler) 


           
            
            
            















            ////Return void farkı-ara konu konuyla bağımlı değil o yüzden comendledim
            //productManager.Topla(3, 6); // bu işlem sonucunda ortaya çıkan sonucu başka işlemde kullanmak istiyorum. örneğin 2ile çarpıcam. 
            //                            //voidle yazıldığı için kullanılmaz void tek işlemi yapar bitirir. ama senin o degere ihtiyacın var
            //                            //o yüzden return

            //int toplamaSonucu = productManager.Topla(3, 6); //productManagerdaki toplayı çağırdık. topla aslında bir fonsiyon ben ona 3,6
            //                                                // verdim topladı. o sonucu in toplama sonucuna atadım sonucu kullanıyorum. Return!!

            //Console.WriteLine(toplamaSonucu*2);
            


        }




    }
}


