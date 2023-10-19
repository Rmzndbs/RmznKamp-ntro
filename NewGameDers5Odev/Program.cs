using NewGameDers5Odev.Abstract;
using NewGameDers5Odev.Adapters;
using NewGameDers5Odev.Concrete;
using NewGameDers5Odev.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewGameDers5Odev
{
    public class MainClass
    {


        static void Main(string[] args)
        {

            Gamer gamer1 = new Gamer();
            gamer1.NationalityId = "14411997590";
            gamer1.FirstName = "Ramazan";
            gamer1.LastName = "Odabaş";
            gamer1.DateOfBirth = new DateTime(1993, 4, 10);
            BaseGameService baseGameService = new GameManager(new MernisServiceAdapter());
            //baseGameService.Save(gamer1);
            //baseGameService.load(gamer1);
            //baseGameService.Delete(gamer1);

            //GameService gameService = new GameService();
            //Game game1 = new Game();
            //game1.GameName = "Kod Savaşları";
            //game1.GamePrice = 250;
            //game1.GameId = 12;
            //gameService.Save(game1);
            


 

            Console.ReadLine();
            


        }









    }

    
}


