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
            Urun urun1 = new Urun();
            urun1.Urunstok = 100;
            urun1.UrunRengi = "pembe";
            urun1.UrunAdedi = 50;
            urun1.UrunAdi = "pantolon";

            Urun urun2= new Urun();
            urun2.Urunstok = 80;
            urun2.UrunRengi = "siyah";
            urun2.UrunAdedi = 40;
            urun2.UrunAdi = "Gömlek";


            Urun[] Urunler = new Urun[] { urun1, urun2 };


            foreach (Urun Alyas in Urunler)
            {
                Console.Write("  " + Alyas.UrunAdedi+"  "+ Alyas.Urunstok+ "  " + Alyas.UrunAdi+ "  " + Alyas.UrunRengi);   
            }







        }

    }

    class Urun 
    {
        public string UrunAdi { get; set; }
        public string UrunRengi  { get; set; }
        public int UrunAdedi { get; set; }
        public int Urunstok { get; set; }
    }
   

}


