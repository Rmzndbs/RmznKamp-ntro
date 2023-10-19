using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class MainClass
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3];
            {
                new Customer { FirstName = "Engin" },new Student { FirstName = "Derin" },new Person { FirstName = "Salih" },
                
            };   //Buradaki hatanın sebebini bulamadım!!

            foreach (var person in persons)
            {
                Console.WriteLine( person.FirstName);
            }
            Console.ReadLine();
        }

    }
    class Person
    {
        public int  Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
    class Customer : Person     //customer aslıdna personden dünyaya gelmiş bir nesnedir , ebeveyni Persondır.
    {
        public string City { get; set; }

    }
    class Student : Person 
    {
        public string Department { get; set; }
    }
}
//Farkları(interface ile inheritance)
//interface den farklı başında class var ve kendi başına da anlam ifade ederler interfaceler kendi başına anlam ifade etmez.
//bir clasa birden fazla inheritance ekleyemezsin bir clasın bir babası olur gibi düşün. ama interfacelerde eklenebilir.
//eğer aynı anda kullanılacaksa inheritance önce yazılır daha sonra kaç tane interface varsa yazılır.
//Örn: Customer:Person,IKrediManager,I......

//eğer sen inhertance a ihtiyacın olduğuu düşünmüyorsan interfacelerden yürü diyor engin hoca! ama 
