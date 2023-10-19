using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class MainClass
    {
        static void Main(string[] args)
        {
            // IPersonManager personManager = new IPersonManager(); //Bu mantıksız. interfaceler newlenmez neden? içi boş kod yok sadece imza var
            //o imza ise void add() o yüzden newlenmez.
            // IPersonManager customerManager = new CustomerManager();//interfaceler onu implemente eden classın referans nuamrasını tutabilirler.
            //customerManager.add();//customer daki add i çalıştıracağı için müşteri eklendi diyecek.

            IPersonManager employeeManager = new EmployeeManager();
            employeeManager.add();   //employee deki add i çalıştıracağı için personel eklendi diyecek

            CustomerManager customerManager = new CustomerManager();


            ProjectManager projectManager = new ProjectManager();  //ProjectManager daki Add in parametresi IPersonManager olduğu için ve
            //IPersonManager de bir interface olduğu için hem CustomManager in hemde EmployeeManager in referansını tutar. ikisinide versek kızmaz
            projectManager.Add(customerManager);
            projectManager.Add(employeeManager);




             

        }

    }

    //class Person 
    //{

    //}

    //class Customer:Person   //customer personun üyerlerini de kullanabilir demek bu.(inheritance) ama interfacelerde ise üyeler var ama içi boş.
    //{

    //}

    //class PersonManager 
    //{
    //    public void add()    //implemented operation içi doldurulmuş operasyon demek.tamamlanmış.
    //    {
    //        Console.WriteLine("Eklendi");
    //    }


    //}
    //class CustomerManager1:PersonManager //CustomerManagerin içerisinde kendi operasyonlarına ek olarak birde kalıtım aldığı sınıfın operasyonlarını
    //                                    //kullanabilir.
    //{

    //}





    interface IPersonManager
    {//interface implemented deiğil unimplemented operationdur. Yani içi doldurulmamış.ve interface üyeleri dışarıdan erişilebilir olması için
     // public yazamazsın. direkt void add() olarak yazdık. yukarıdaki classta içini doldurmuştuk burada ise içini doldurmuyoruz.
        void add();
    }
    class CustomerManager : IPersonManager
    {
        public void add()
        {
            //Müşteri ekleme kodları
            Console.WriteLine("Müşteri eklendi");
        }
    }
    class EmployeeManager : IPersonManager
    {
        public void add()
        {
            //Personel ekleme kodları.
            Console.WriteLine("Personel Eklendi.");
        }
    }
    //Önemli NOT:normal class içinde add tanımladığın zaman onu digerlerine kalıtım yaparsan o classın içinde olan içi doldurulmuş add i olduğu gibi kullanırsın.
    //Ancak interface de durum farklıdır. intercafe de add içi boş bırakılır çünkü birbirine bağlayacağın her bir class kendi içinde farklı kodları
    //taşır. sadece imza aynıdır.    ve classlarda inhertirs(inheritance) ancak interfacelerde İmplement edilir.
    //interface de bir imza var bağlantı kurulursa o imzayı taşımak zorunda ama içinde kendi kodunu yazabilir.
    //interface de daha sonra başka bir imza eklesek örn. void upgrade gibi o zaman ilişkili olan EmployeeManager veCustomManager i tekrardan implemente etmek gerekir. 
    //----Farklı bir çalışma-----------
    class ProjectManager
    {
        public void Add(IPersonManager personManager)  //bana CostomerManager ver sana sonuç vereyim demektense IPerson ver dersek hem Customer hemde Employee kapsar.
        {

            personManager.add();
        }

    }
}
