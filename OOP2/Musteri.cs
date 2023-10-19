using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{//base sınıf ":" den dolayı
    internal class Musteri    //clasların 2 özelliği var 1- içerisinde özellikler tutar. 2- içerisinde operasyonlar tutar. ikisini aynı yerde tutmaz.
    {                         // özellik tuttuğumuz yerde operasyon tutmuyoruz. operasyon tuttuğumuz yerde özelilk tutmuyoruz.
        public int Id { get; set; }           
        public string MusteriNo { get; set; }         
        
        
        //GercekMusteri ve TüzelMusteri classlarının ikisinde de bulunacak özellikleri buraya atadık daha sonra ":" ile alt kümesi yaptık.
        
        

       
        //tc no ve vergi no gibi yerlerde de string kullandık. eğer matematiksel işlemler yapmayacaksan string 
                                        // olarak oluşturman sana kolaylıklar sağlıyormuş.
          //NOT:Eğer bir nesnede bir değeri kullanmak zorunda görünmüyorsa oraya ait değilmiş gerek yokmuş gibi ise 
                                              //sen orada soyutlamada hata yapıyorsundur.

    }//Tüzel müşteri ve gerçek müşteri sırf birbirine benziyor diye birlikte ele alma patlayan noktalar olur. bunu SOLID ın L si diyor
    //sürdürülebilirlik adına üşenme ayrı ayrı class olarak oluşturulmalı.

    // Gerçek müşteri ve tüzel müşteri olarak yeni claslar oluşturduk.
}
