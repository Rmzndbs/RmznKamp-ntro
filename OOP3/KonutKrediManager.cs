using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{//KrediManager de hesapla var. ben KonutKrediManagerde de Hesapla olmasını istiyorum. o yüzden ":" ile bağladım. ayrı ayrı yazmaya gerek yok.
 //şöyle düşün KonutKrediManager  KrediManager daki hesapla'ya sahip. Oradaki organizasyonlara sahip.
 //KrediManager bir interface olduğu için içerisindeki organizasyonları bütün krediler barındırmak zorunda bu yüzden 
 //KonutKrediManager:IkrediManager yazdığımızda çıkan ampulden ımplement interface (interface i uygula- şablonu uygula) dediğimizde
 //interface kendiliğinden gelir.   IKrediManager diye yazılmasının sebebi I başına geliyor ki interface olduğu belli olsun
 //ımplemente edildikten sonra her kredinin kendi durumuna göre kodlar yazılır.
    internal class KonutKrediManager : IKrediManager //KonutKrediManager aynı zamanda bir KrediManagerdır. KrediManager alt küme
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Konut kredisi ödeme planı hesaplandı.");
        }
    }
}
