using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DersBesOdev
{
    internal class Customer
    { //Customer.FirstName="RAmazan" dediğinde bizim için proptaki set bloğu çalışır. eşitliğin olduğu yer olarakta düşünebilirsin.
      //ConsoleWriteLine(customer.FirtName);  buranın kelime anlamı ise customer2nin firtnameini al! burada ise get bloğu çalışır.

        private string _firtName; 
        public string FirtName 
        { 
          
            get {return "Mrs." + _firtName; }       //degerde ilerleyen zamanda değişiklik yapmak istersek get set üzerinden bu şekilde yapılır.
            set {_firtName =value;}              
        }
        public int  Id { get; set; }
        public string LastName { get; set; }     //property (özellik) tanımladık.
        public string City { get; set; }








        public int TcNo; // Bu şekilde tanımlamaya Field(alan) deniliyor. ama prop daha doğru. alan tanımlamak.
    }
}
