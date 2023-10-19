using NewGameDers5Odev.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewGameDers5Odev.Abstract
{
    public interface IGameManager
    {
        void Save(Gamer gamer );
        void load(Gamer gamer);
        void Delete(Gamer gamer );

        

    }
}
