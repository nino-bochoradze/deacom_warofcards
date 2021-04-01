using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarOfCards.Classes;

namespace WarOfCards
{
    class Program
    {
     
        static void Main(string[] args)
        {

            Game game = new Game("Tom", "Anna");
            while (!game.IsGameOver())
            {
                game.PlayTurn();
            }

            Console.Read();
        }
    }
}
    
    

