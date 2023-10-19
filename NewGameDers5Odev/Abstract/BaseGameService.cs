using NewGameDers5Odev.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewGameDers5Odev.Abstract
{
    public abstract class BaseGameService : IGameManager
    {
        public virtual void Delete(Gamer  gamer)
        {
            Console.WriteLine("Bilgiler kontrol edilerek. Silme işlemi gerçekleşti   :  "+ gamer.FirstName);
        }

        public virtual void load(Gamer gamer)
        {
            Console.WriteLine("Bilgiler kontrol edilerek güncelleme işlemi gerçekleşti.  :" + gamer.FirstName);
        }

        public virtual void Save(Gamer gamer )
        {
            Console.WriteLine("Bilgiler kontrol edilerek kaydetme işlemi gerçekleşti. " + gamer.FirstName);
        }
    }
}
