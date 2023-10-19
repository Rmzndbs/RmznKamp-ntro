using NewGameDers5Odev.Abstract;
using NewGameDers5Odev.Adapters;
using NewGameDers5Odev.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewGameDers5Odev.Concrete
{
    public class GameManager:BaseGameService
    {
        IGamerCheckService _gamerCheckService;

        public GameManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public override void Save(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealPerson( gamer))
            {
                base.Save(gamer);
            }
            else
            {
                throw new Exception("Geçerli bir kişi değil");
            }

            
            
        }
        public override void Delete(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealPerson(gamer))
            {
              base.Delete(gamer);
            }
            else
            {
                throw new Exception("Geçerli kişi değil.");
            }
           

        }
        public override void load(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealPerson(gamer))
            {base.load(gamer);

            }
            else
            {
                throw new Exception("Geçerli kişi değil.");
            }
            
        }
    }
}
