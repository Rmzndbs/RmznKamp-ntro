using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericsİntro
{
    class MyList<T>    //generic class demek çalışacağım tip özel bir class demek T  type demek. sadece string ,int değilde senin 
                            //belrittiğin herhangi bir türde çalışabiliyorsun. T ile bana bir tip ver bende ona göre çalışayım demek.
    {
        T[] items; //clasın içinde ancak motodun dışında array tanımladık. ama nevlemekte gerekiyor. 

        //CONSTRUCTOR -  ctor tap tap yapınca oluyor-bir class newlendiğinde çalışan bloğa deniliyor.
        public MyList()     
        {
            items = new T[0];
        }
        public void Add(T item)  // T olarak string verdik. yani biz metotda ona T(tür) olarak ne verirsem ona göre çalışıyor.
        {
            //çalışacağı veri tipini classtani T sayesinde biz veriyoruz. generics class budur.   T tip demek gigi düşün voidin içini                                
            //T yaptık ki o zaman ne verirsem o olsun.   
            //item yazdığın yere istediğin ismi verebilirsin ama genelde item deniyor eleman demek
            T[] tempArray = items;   //tempArray geçiçi dizi demek.  
            items = new T[items.Length+1];    // dizinin eleman sayısını 1 arttır.mevcuttaki kaçsa onu bir arttır. ama nevlediğin için referans
                                              // numarası değişir ve ilk elemanlar kaybolur kaybolmaması için geçiçi dizi oluşturduk.bu dizi 
                                              //kaybolmasın diye eski adresi tutuyor.

            for (int i = 0; i < tempArray.Length; i++)     // ben sana emanaten veri vermiştim onları bana geri versene diyoruz. yani tempArraydekileri
            {
                items[i]= tempArray[i];   // emaneten oluşturduğum tempArray deki elemanlarımı sırasıyla geri alıyorum. 
                                          // Artık items eski değerlerine kavuştu.
            }
            items[items.Length - 1] = item;   // itemsın uzunluğunun -1 demenizin sebebi 0 dan başlıyor olması yani son elemanı demek.
        }   

    }
}
