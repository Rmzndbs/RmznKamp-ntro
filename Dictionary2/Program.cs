using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary2  //Listelerin key numarasına göre bulunması demek.
{
    public class Program
    {
        static void Main(string[] args)
        {
            MainClass mainClass = new MainClass();
            mainClass.MainStart();
            Console.ReadLine();
        }

    }
    public class MainClass 
    {
        Dictionary<int, string> DicList = new Dictionary<int, string>();  //Keyi int olan içeriği ise string olan DicList adında bir dictionary oluşturduk.

        public void MainStart() 
        {
            DicList.Add(1,"Kaan");                 //add in içine bak int key string value istiyor.//Aynı key numaralarına sahip olamazlar.
            DicList.Add(2, "Numan");
            DicList.Add(3, "Buse");
            DicList.Add(4, "Emir");

            //elaman var mı yokmuyu kontrol etmek için ConstainKey kulanılıyor
            if (DicList.ContainsKey(1))               
            {
                Console.WriteLine("Eleman Var"+DicList[1]);  //Eğer varsa değerini yansıtır. DicList[1]
            }
            else
            {
                Console.WriteLine("Eleman Yok");
            }
            




            Console.WriteLine(DicList[2]);   // içinde key numarasını 2 olanı yazdır diyoruz burada yani numan 



            Console.WriteLine(ListedeAra(3));    // key e bakıp sonuç yazdırıyoruz. 
            Console.WriteLine(ListedeAra(8));        // key yoksa istediğimiz sonuvu döndürdük.
        }
        public string ListedeAra(int aranacak)    //Şimdi içerisinde varsa eğer çıktısını al ve yaz diyebileceğimiz işlemi yazacağız.
        {
            string donenDeger;
            if (DicList.TryGetValue(aranacak , out donenDeger))             //TryGetValue arar bulursa o sonucu geri dışarı atar. 
            {
                return donenDeger;

            }
            else
            {
                return "Listede Eleman Yok";
            }



            //////ENGİN DEMİROĞ DERSİ DEĞİL HATA OLABİLİR. !!!!!!
           
        }
    }


}


