using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    public class MainClass
    {
        static void Main(string[] args)
        {
            //Diktionary sınıfı içinde sizin belirleyeceğiniz bir keye uygun olarak değer sakalar. key türünü belirlemeniz şarttır.(int,string vs)
            
            Dictionary<string,int>AdYas=new Dictionary<string,int>();
            //veri ekliyoruz
            AdYas.Add("amy",25);
            AdYas.Add("mehmet", 17);
            AdYas.Add("birisi",30);

            foreach (var degeroku in AdYas)
            {
                Console.WriteLine(degeroku);
            }
            //değer sayma özelliği vardır.
            var eleman = AdYas.Count();
            Console.WriteLine();
            Console.WriteLine("Elaman sayısı = "+eleman);

            //Silme işlemi de vardır.
            AdYas.Remove("birisi");
            Console.WriteLine();
            foreach (var degeroku in AdYas)
            {
                Console.WriteLine(degeroku);
            }
            Console.ReadLine();


        }

        


    }
}


