using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegerVeReferansTipler
{
    public class MainClass
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;// sonuç 30 çünkü yukarıdan aşagıya doğru çalışıyor. sayi1=sayi2 yapınca sayı1 de 30 oldu daha sonraki değişiklik onu etkilemez.
            sayi1 = sayi2;
            sayi2 = 65;

            //sayi1 ?? 30 olur !!

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar1[0] = 999;

            //sayilar1[0] ?? 999 olur neden ?


            //sayısal veri tipleri yani ınt ,decimol ,float ,double,bool (true false ama 0-1 olarak tutuyor) bunlar DEĞER TİP
            //array (dizi) ,class,interface  bunlar ise REFERANS TİP

            //YUKARIDAKİ iki durumun sonuçlarının değişik olmasının sebebi nedir ?

            //!!!!!! bellekte STACK    ve    HEAP     diye 2 tane alan var .   sen değer tip olanlara bir tanımlama yaptığın zaman bunlar tamamen STACK'te gerçekleşiyor.
            //yani sen sayı1 diye birşey tanımladığında  ve ona deger olarak 10 verdiğinde herşey stackte gerçekleşiyor.
            //veya sayı2 diye birşey tanımladığında ve ona 20 dediğinde yine stackte tanımlanır çünkü değer tipler stakte gerçekleşir. 
            //ve değer tipler şöyle okunur: sayi1=10 dediğinde sayi1 in değeri =10diye sayi2 nin değeri = 30 diye okunur yukarıdaki ilk durumda sayi1=sayi2 dediğinde 
            //sayi1 in değeri = sayı2 nin değeri yani değeri aktarırsın ve sayi2 ile olan bagını koparırsın.  yani sayi1 de artık 30 olur ama ayrı ayrı değer bunlar 
            //ilerde sayi2 yi 65 yapman sayi1 i değiştirmez cünkü o artık 30. değeri bir kere eşiteldi ve bağlantı koptu. STACK BELLEKTE tutulan şeylerin mantığı bu!!!!
            //Stack
            //sayi1 = 10
            //sayi2 = 20 




            //REFERANS tipler ise hem STACK'TE  hemde HEAP'te tutulur.   mantık şu : 2. durumu düşün yukardaki.
            //sayılar1 diye bir değişken tanımladın stackte new dediğin anda sayılar1 için head de yeni bir alan oluştur ve değerleri oraya yaz diyorsun array olduğu için böyle. 
            //bu ikisinin bağlantısı ise bir adres değerleri var onun üzerindne tutuluyor.      int de olsa arrayler bir referans tiptir.
            //NOT:NEW DEMEK BELLEKTE YENİ BİR ADRES DEĞERİ OLUŞTUR DEMEK!!!!!    

            //adres degeri= referans numarası diye de okunur!!

            // stack                                              Head
            //sayılar1(101 adresdegeri olsun)                   [10,20,30](101 adres değeri bununda)
            //sayilar2(102 adres degeri olsun)                  [100,200,300](102 adres degeri bununda)
           
            
            //sen sayilar1=sayilar2 dendiğinde bunu şöyle okumalısın.  sayılar1 in referans numarası = sayılar2 nin referans numarası.  
            //yani sayılar1'inde artık referans numarası 102 olduğu için 101 referans numarsındakilerle işi kalmıyor bağlantı tamamen kopuyor.

            //değertipler de değer atanır bağ kopmaz ama referans tiplerde adresi atıyorsun bağ kopar.  adres= referans numarası 
            //artık sayılar1 de sayılar2 de 102 referans numaralı alanda oldukları için sayılar2 de yapacağın değişiklik sayılar1de de olur. 
            //artık 101 referans numarasını tutan birşey olmadığı için 101 referans numarası çöp oluyor. işe yaramaz çalışmayan kod durumuna geliyor. 










        }



    }
}


