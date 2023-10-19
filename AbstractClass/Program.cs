using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracktClass // Soyut sınıf      // aklında kalıtım olmalı diyor.
{
    public class MainClass
    {
        static void Main(string[] args)   //static void Main(string[] args) imzası bu kısım gövdesi ise {} kısmıdır.
        {
           // Ornek ornek= new Ornek();// olmuyor.olmazda
            Ornek ornek =new Calisma();
            

        
        }
        //bu sınıf içerisinde abstracjt ile işaretlenen metot veya propertyler bu sınıfdan kalıtım alan her sınıfta 
        //   yazılmak yani uygulanmak yani implement edilmek zorunda. abstrackt görünce aklına kalıtım gelcek.
        //2.  abract metot yada propertylerin gövdeleri tanımlandıkları class içinde yazılmazlar sadece imza dediğimiz
        //geri dönüş tipleri , isimleri ve erişim blirliyicileri tanımlana bilir gövdeleri kalıtım alan sınıfta override edilerek yazılır.
        //abstrackt olan classın içinde abstrackt olmayan yapılar da bulunabilir
        //**abstrackt classlardan nesne oluşturulmaz.*** Referans noktası alınabilir.
        //interface den farklı hem implemente edilecek hemde edilmeyecek şeyleri içinde barındırıyor olmasıdır.
        abstract class Ornek      
        {
            //public abstract void X();  //gövde yok sadece imza
            //abstract public int MyProperty { get; set; }//sadece imza 

            //public int MyProperty1 { get; set; }//abstrackt olmayan ya();
            

            abstract public void X();
            public abstract int Y { get; set; }
            abstract public bool Z();

            public void W() { }   //burada sıkıntı yok abstractk değil çnkü başka bir yere implemente de olmuyor bu


        }
        class Calisma : Ornek
        {
            public override int Y { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public override void X()
            {
                throw new NotImplementedException();
            }

            public override bool Z()
            {
                throw new NotImplementedException();
            }
        }

     

    }
}

