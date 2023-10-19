using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {

        public void Ekle(Musteri musteri) 
        {

            Console.WriteLine("Yeni Müsteri Eklendi"+musteri.Ad+musteri.Soyad+musteri.Id);



        }
        public void Silme(Musteri musteri) 
        {
            Console.WriteLine("Müsteri silindi."+musteri.Ad+musteri.Soyad+musteri.Id);
        
        
        }

        public void Listele(Musteri musteri) 
        {
            Console.WriteLine("Müsteriler listelendi"+musteri.Ad+musteri.Soyad+musteri.Id);
        
        
        
        }
        
      




    }
}
