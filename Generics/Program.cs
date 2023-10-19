using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class MainClass
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();//List classtır. Koleksiyonlardan hatırla. //List hazır Classdır içinde farklı fonksiyonlar da var.
            sehirler.Add("Ankara");  //<> içine ne yazarsan class o oluyor bunun sebebi <T> bizden MyListte öyle oluşturacağız.
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            Console.WriteLine(sehirler.Count);  //List te Count var     count eleman sayısı demek.
            
            
            
            
            //MyList sehirler2 = new MyList(); //MyList artık generic class olduğu için hangi türde çalışacağını belirtmek lazım. yani
            MyList<string> sehirler2 = new MyList<string>(); //string verdik T stringe dönüştü int versek T inte dönüşür.
            sehirler2.Add("Bayburt");
            sehirler2.Add("Bayburt");
            sehirler2.Add("Bayburt");
            sehirler2.Add("Bayburt");
            sehirler2.Add("Bayburt");
            sehirler2.Add("Bayburt");
            Console.WriteLine(sehirler2.Count);


            
        }

    }
    //class MyList  // kendi Listimizi oluşturalım.  //Add in içinde ne istersem ona göre verecek ama ben hepsini kapsayacak birşey yapabilrim.
    //{              //Onun adı da generic yani <T>
    //    public void Add(string İtem)
    //    {

    //    } 
    //}
    class MyList<T>  //Generik class yani çalışma tipi T hangi tiple çalışacağını sen belirlersin.
    {

        T[] _array;
        T[] _tempArray;

        public MyList()
        {
            _tempArray = _array; //_tempArray _arrayin referansını tutuyor. 
            _array = new T[0];   //sıfır elemanlı bir array 
        }
        public void Add(T item)    //buradaki T hangi tipi verirsek ona dönüşüyor.
        {
            _tempArray= _array;
            _array = new T[_array.Length+1]; //Eleman sayısını 1 arttırıyoruz. her yeni eleman verildiğinde ancak eleman sayısını arttırdığımızda
                                             // newlediğimizde tüm data uçuyor gidiyor.3 elemanlı bir arraya 4. elamanı oluşturunca yeni referans atandığında ilk 3 referans gider.
                                             //bu yüzden 4. elemanı atamadan önce ilk 3 elemanın yedeğinin alınması lazım. oda _tempArray

            for (int i = 0; i <_tempArray.Length; i++)
            {
                _array[i] = _tempArray[i]; //Burada _array i _tempArray e eşiyledik ki ilk 3 elemanı geri getirmek için
            }
            _array[_array.Length - 1]=item;
        }
        private int _count;

        public int Count
        {
            get { return _array.Length; }   //Ben MyList'ten Count Çağırırsam yukarıda tanımladığım Array 'in eleman sayısını verecek.
            
        }

    }
}

