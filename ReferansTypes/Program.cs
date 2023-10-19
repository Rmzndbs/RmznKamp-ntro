using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constroctors  //constroctur bir classı  newlediğimiz zaman çalışan blocktur aslında. türkçesi yapıcı demek yapıcı block.
{                       //classı ilk kez yapılandırdığımız zaman çalıştırdığımız blocktur. ilk kes oluşturuldu sonrasında hep o kullanıldı. 
                        //Constrocturlar Methods gibidir.
    public class MainClass
    {
        static void Main(string[] args)   

        {

           
            Customer customer = new Customer();  // new yaptığın zaman arka planda public Customer(){      } blogu kendiliğinden çalışır. 


         
            Customer customer1 = new Customer { Id = 2, FirstName = "Ramazan", LastName = "Odabaş", City = "Bayburt" };
            //parametresi olmayan constroctura yani default controcturda bu şekilde {} içinde parametleri yazabilirim. bu aşağıdakiyle aynı mantık.
            //ancak eğer parametresi belirtilmişse böyle yazamazsın bu hatayı ortadan kaldırmak içinde hem parametreli hemde parametresiz iki 
            //Constructor yazarsın methot gibi düşün.
            Customer customer2 = new Customer();
            customer2.Id = 12;
            customer2.FirstName = "Celil";
            customer2.LastName = "maytak";    // yukarıdaki ikisi aynı 
            customer2.City = "Trabzon";


            Customer customer3 = new Customer(2,"Mehmet","çakır","Gümüşhane");  // aşağıda costomer parametresini tanımladığımız için bu şekilde 
                                                                                //yazmama izin veriyor. parametreli olarak yazmasak kızardı.

            Console.WriteLine(customer3.FirstName);// costructors un içinde eşitlediğimiz için direkt yazarak çalıştırabiliyoruz.



        }


                        

    }
    class Customer       // müşteri demek
    {
        public Customer() // sen Custımer ı newlediğin anda burada belirttiğimiz gibi sanki bir metod varmış gibi çalışır ama içi boş
        {                 // bu blogu yazıp yazmaman önemli değil varsa çalışır yoksa arka planda varmış gibi çalışır. 
                          //Bu bloga default Constroctor deniyor.   parametresi olmayan constructor a denir. 
        
        
        }
        public Customer(int id,string firstName,string lastName,string city) // methods gibi Customerın parametrelerini verdik. 
        {                                                                    //parametreler küçük harfle yazılır.  constroctors =ctor
            Id = id;
            FirstName = firstName;
            LastName=lastName;               // parametreleri classta tanımladığımız türlere eşitledik ki bize sonuç versin. 
            City = city;
            

        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }

    


   
}

