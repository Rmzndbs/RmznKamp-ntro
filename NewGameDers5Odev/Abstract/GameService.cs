using NewGameDers5Odev.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewGameDers5Odev.Abstract
{
    public  class GameService 
    {
        public void Delete(Game game)
        {
            Console.WriteLine("silindi");
        }

        public void load(Game game)
        {
            Console.WriteLine("güncellendi");
        }

        public void Save(Game game)
        {
            Console.WriteLine("kaydedildi.    : "+game.GameName);
        }
    }
}
