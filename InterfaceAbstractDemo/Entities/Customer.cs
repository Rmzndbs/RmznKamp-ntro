using System;
using InterfaceAbstractDemo.Abstract;

namespace InterfaceAbstractDemo.Entities
{//entities klasörünü varlılarımız için oluşturduğumuz klasördür.
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }
        public string NationalityId { get; set; }


    }

}
