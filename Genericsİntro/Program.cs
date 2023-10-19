using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericsİntro
{
    public class MainClass
    {
        static void Main(string[] args)
        {
            //burada hazır kalıp list classı olmasaydı napacaktık adlı çalışma. kendi listimi oluşturacağım. 
            
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Engin");

            List<string> liste = new List<string>();
            Console.WriteLine(liste.Count);         //liste.count ile liste.lenght aynı şey eleman sayısı demek.    
         
            
                                                   

                




            
        }




    }
}


