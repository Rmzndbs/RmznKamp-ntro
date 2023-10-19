using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferanceTypes
{
    public class MainClass
    {
        static void Main(string[] args)
        {
            //int sayi1 = 10;       //Değer tipleri ve Referans tiplerini anlatıyor.
            //int sayi2 = 20;    //int , decimal, fload,enum,blooean  value types'dır yani değer tip.(sadece stack bellekte tutulur)

            //sayi1 = sayi2;
            //sayi2 = 100;

            //Console.WriteLine(sayi1); //  ?? cevap 20 çünkü değer tip.

            //int[] sayilar1 = new int[] {1,2,3 };     //arrays , class , interface...referance types -referans tip dir.(stack bellek +heap bellek)
            //int[] sayilar2 = new int[] {10,20,30 };  // heap adresi biz new lediğimiz zaman oluşuyor.

            //sayilar1 = sayilar2;

            //sayilar2[0] = 1000;
            //Console.WriteLine(sayilar1[0]);  //sayilar1 in 0(ilk elamanı)kaçtır?? cevap 1000

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirsName = "Engin";
            person2 = person1;    // adresleri referans tipleri eşitlenmiş oldu. person1 in referance numarasını person2 ye aktarmış olduk.
            person1.FirsName = "Derin"; //dediğimiz zaman person1  de person 2 de artık derin olarak değişti nedeni ise Referance Types olması
                                        // adresleri eşitlendi referance tip olduu için
                                        //Console.WriteLine(person2.FirsName);                         


            Customer customer = new Customer();
            customer.FirsName = "Salih";
            customer.CreditCardNumber = "254125";
            Employee employee = new Employee();

            //customer= employee //Böyle diyemiyoruz çünkü farklı tür ama bir alta bak oradan person = customer demişiz neden ?
            //Çünkü Types oluştururken Customer:Person dedik      ama Employe:Customer demedik. 
            Person person3 = customer;// burada kızmadı çünkü   //person3. yaptığında CreditCardNumber çıkmadı diper Id, FirstName vs var 
            Console.WriteLine(person3.FirsName);  //person3 her ne kadar customer olsada CreditCardNumberı göremiyoruz.
                                                  //person classı üzerinden gittiğimiz için göremiyoruz. person customerin alt kümesi gibi düşün.)
                                                  //Console.WriteLine(((Customer)person3).CreditCardNumber);////person3 e Customer Classı baksın demek. bakacağı classı parantez içine yazdık.
                                                  //parantez içine atanabilir class yazdık tabi. alttaki" :" ile belirlediklerimizden. 
                                                  //cw de yukarıda tanımladığımız kart numarası çıktı çünkü adresleri aynı. 
                                                  //Customer :Person geçişi yaptık. bunu Employee : Person olarakta yapabiliriz.

            ////yukarıda neden person olarak yazmaya çalıştık direkt customer yazsaydık diyebilirsin. sebebi ise diyelim ki yeni bir class yazdın
            //ancak hemcustomer hem Employee hem Person tutmak istiyorsun.parametreye Person türü olarak belirlersen 3 classı da kullanabilir olacaksın.

            PersonManager personManager = new PersonManager();
            personManager.Add(person3);// ben metotda parametre olarak person yazmış olsam da Employee yada Customer göndersemde kızmıyor.
                                       //bize bunu sağlamış oldu. o yüzden person yazmaya çalışıyoruz. 
                                       ////Console.WriteLine(((Customer)person3).CreditCardNumber);
            personManager.Add(customer);//kızmadı.
            personManager.Add(employee);//Kızmadı.     //Aynı kodu farklı nesleler,türler için çalıştırmama imkan sağlamış oldu.

        }

    }
    class Person // Kişi demek
    {
        public int Id { get; set; }
        public string FirsName { get; set; }
        public int LastName { get; set; }


    }
    class Customer : Person  //Müşteri demek(Customer) Customer:Person dediğimiz zaman customerın içinde persondakilere (Id,FirstName,LastName) ek
    {                      //ek olarak CreditCardNumber  var demek.
        public string CreditCardNumber { get; set; }

    }
    class Employee : Person       // çalışan(Employee)  Employee:Person dedik yani Employee de Person dakilere ek olarak EmployerNumber var
    {
        public int EmployeeNumber { get; set; }

    }
    //Base classımız Person oluyor çünkü o temel alınmış hep :Person yapmışız.
    class PersonManager
    {
        public void Add(Person person)
        {

            //yukarıda neden person olarak yazmaya çalıştık direkt customer yazsaydık diyebilirsin. sebebi ise diyelim ki yeni bir class yazdın
            //ancak hemcustomer hem Employee hem Person tutmak istiyorsun.parametreye Person türü olarak belirlersen 3 classı da kullanabilir olacaksın.

            Console.WriteLine(person.FirsName);

        }
    }
}

