using System;
using System.Collections.Generic;
namespace Padel
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player("Player 1");
            Player p2 = new Player("Player 2");
            Game game = new Game(p1, p2);


            game.Point(p1);
            game.Point(p2);
            Console.WriteLine(p1.Score._Score);
            Console.WriteLine(p2.Score._Score);

            game.Point(p1);
            game.Point(p2);
            Console.WriteLine(p1.Score._Score);
            Console.WriteLine(p2.Score._Score);


            game.Point(p1);
           

            Set set1 = new Set();
            set1.Point(p2);
            set1.Point(p2);
            set1.Point(p2);
            set1.Point(p1);
            
            Console.WriteLine(set1._games.Count);



        }
    }
}
