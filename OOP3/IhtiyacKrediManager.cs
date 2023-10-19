using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{//İhtiyaçKrediManager , KrediManager daki organizasyonlara sahip. veya KrediManager , İhtiyaçKrediManagerin alt kümesidir.
 //KrediManager bir interface olduğu için içerisindeki organizasyonları bütün krediler barındırmak zorunda bu yüzden 
 //İhtiyacKrediManager:IkrediManager yazdığımızda çıkan ampulden ımplement interface (interface i uygula- şablonu uygula) dediğimizde
 //interface kendiliğinden gelir.  IKrediManager diye yazılmasının sebebi I başına geliyor ki interface olduğu belli olsun
 //ımplemente edildikten sonra her kredinin kendi durumuna göre kodlar yazılır.
    internal class IhtiyacKrediManager : IKrediManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı.");
        }
    }
}
