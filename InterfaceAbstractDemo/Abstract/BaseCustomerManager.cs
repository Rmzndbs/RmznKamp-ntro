using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//interface de sadece imza yazıp yani içi boş metot yazıp implemente edip dolduruyorsun. abstract sınıfta ise metodun içini dolduruyorsun.
//çünkü aynı kodları kullanacaksın. aynı işlemi yapacaksın. ortak operasyon 
namespace InterfaceAbstractDemo.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("save to db(data base)   :  " +customer.FirstName);
        }
    }
}
        