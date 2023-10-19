using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo.Concrete
{
    public class SturbucsCustomerManager : BaseCustomerManager
    {
          ICustomerCheckService _customerCheckService;

        public SturbucsCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
           if(_customerCheckService.CheckIfRealPerson(customer))//dönerse kaydet.
            {
                base.Save(customer);     //basecostumerda virtual dedikten sonra burada override save dediğinde bu kod geliyor.
            }
            else 
            { 
            throw new Exception("not a valid person"); //geçerli kişi değil. dönme  zse bu
            }
        }

       
    }
}
    