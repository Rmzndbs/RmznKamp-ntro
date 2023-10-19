using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3    //Sonradan Sms Logger ekledik. mevcut hiçbirşeyi bozmadan yeni class açarak ekledik ve implemente ettik.
{
    internal class SmsLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Sms Yollandı");
        }
    }
}
