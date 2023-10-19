 using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo
{
    public class MainClass
    {//   //---SENARYO--
        //kahve dükkanları içinmüşteri yönetimi yapan bir sistem yazmak istiyoruz. starbucks ve nero firması için çalışıyoruz. 
        //iki firma da müşterilerini aynı veri tabanına kaydetmek istiyor.starbucks müşterileri kaydederken , mutlaka merniz doğrulama istiyor.(tc, ad soyad , doğum tarihi)
        //nero müşterileri kaydederken böyle birşey istemiyor.starbucks müşteriler için kahve alımında yıldız kazandırmak istiyor.
        static void Main(string[] args)
        {
            BaseCustomerManager baseCustomerManager = new SturbucsCustomerManager(new MernisServiceAdapter() );
            baseCustomerManager.Save(new Customer { DateOfBirth = new DateTime(1992,4,10), FirstName = "Ramazan", LastName = "Odabaş", NationalityId = "14411997590" });
            Console.ReadLine ();
           
        }

    }
}
