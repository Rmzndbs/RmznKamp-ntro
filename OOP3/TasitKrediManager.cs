using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{//TasıtKrediManager, KredeManagerdeki Hesaplaya veya organizasyonlara sahip. KrediManager de hesapla yazdık tekrar yazmaya gerek yok.
 //KrediManager bir interface olduğu için içerisindeki organizasyonları bütün krediler barındırmak zorunda bu yüzden 
 //TasıtKrediManager:IkrediManager yazdığımızda çıkan ampulden ımplement interface (interface i uygula- şablonu uygula) dediğimizde
 //interface kendiliğinden gelir.   IKrediManager diye yazılmasının sebebi I başına geliyor ki interface olduğu belli olsun
 //ımplemente edildikten sonra her kredinin kendi durumuna göre kodlar yazılır.
    internal class TasitKrediManager : IKrediManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Taşıt kredisi ödeme planı hesaplandı.");
        }
    }
}
