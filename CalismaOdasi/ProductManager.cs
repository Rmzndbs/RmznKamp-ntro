using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalismaOdasi
{
    internal class ProductManager
    {
        public void Add(Product product) 
        {
            Console.WriteLine("Eklendi "+product.Adı+product.Renk+product.Adet);


        }

    }
}
