using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DersBesOdev
{
    public class MainClass
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.FirstName = "Engin";
            customer.LastName = "Demiroğ";               //property yani özellikleri böyle de verebilirsin. 
            customer.Id = 1;
            customer.City = "Diyarbakır";

            Customer customer2=new Customer {Id=2,City="Bayburt",FirstName="Ramazan",LastName="Odabaş" };  // özellikleri bu şekilde de tanımlayabilirsin. 

            Console.WriteLine(customer2.FirstName);
            //Customer.FirstName="RAmazan" dediğinde bizim için proptaki set bloğu çalışır. eşitliğin olduğu yer olarakta düşünebilirsin.
            //ConsoleWriteLine(customer.FirtName);  buranın kelime anlamı ise customer2nin firtnameini al! burada ise get bloğu çalışır.
        }

    }
}

