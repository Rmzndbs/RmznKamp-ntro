using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class GameManager : IGameService
    {
        public void Sale(Game game, Campaign campaign)
        {
            Console.WriteLine("Oyun satın alındı. İyi eğlenceler..");
        }
    }
}
