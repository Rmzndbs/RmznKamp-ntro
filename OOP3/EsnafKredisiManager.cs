using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3    //Sonradan EsnafKredisiService i ekledik. Mevcut hiçbirşeyi bozmadık yeni class olarak ekledik ve implemente ettik. 
{
    internal class EsnafKredisiManager : IKrediManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Esnaf kredisi hesaplandı.");
        }
    }
}
