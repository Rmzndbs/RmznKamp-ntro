using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    public class MainClass
    {
        static void Main(string[] args)
        {

           DortIslem  dortIslem = new DortIslem();  // Benim zaten toplama işlemini yapan metotum var o metot DortIslem classının içinde olduğu için benim o classtan bir tane 
                                                    //örnek oluşturmam lazım.
            dortIslem.Topla(100,21);
                                                       //Buradaki sayılara paramatre denir. yani değişkenlik gösterebilen şeyler. 
                                                       //sepete eklede ki parametre nedir üründür. Yani değişken olan metodun çalışması için ihtiyaç olan şey 
            dortIslem.Topla(6,9);








        }




    }
}


