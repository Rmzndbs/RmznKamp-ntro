using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryOperatoru
{
    public class MainClass
    {
        static void Main(string[] args)
        {
            //Bir değişkene /metoda/ property'e Değer atarken , Eğer ki bu değer şarta göre fark edecekse tek satırla bu şart unsurunu yaparak duruma göre değeri döndürmeyi 
            //sağlayan kalıpsal operatördür. yani bir kalıbı vardır.  (if else gibi ama tek satırda yazılıyor.) daha pratik hali diyebiliriz. tek satırdave kalıpta yazılıyor.
            // Kalıbı şöyle:      .....Şart/durum ? .....1.durum(true)...  :  .....2.durum(false) ...... 
            //                                      Şarat true ise 1. durum döndürülür şart false ise 2. durum döndürülecek.   
            // ?: kalıbı senbolüdür.  ve dönecek değerlerin ikiside aynı türde olmalıdır. birisi intecer diğeri string olmaz.

            bool medeniHal = true; 


            string mesaj=medeniHal == true ? "Evlilere Kampanya" : "Bekarlara Kampanya"; // ? ve : var bunu görünce ternary Operatörü diyeceksin.
                                                                                         //true ise evlilere kamp... dönecek false ise bekarlara kamp.. dönecek
            Console.WriteLine(mesaj);
                                                                                            



        }




    }
}

