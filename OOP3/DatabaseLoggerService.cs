using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{//Veri tabanına loglama yapacak servis
 //database : veri tabanı  -  Logger:Loglayıcı
    internal class DatabaseLoggerService : ILoggerService     //veri tabanına yazmak istiyoruz.
    {
        public void Log()
        {
            Console.WriteLine("Veri tabanına Loglandı");
        }
    }
}




