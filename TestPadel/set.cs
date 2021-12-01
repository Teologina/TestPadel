using System;
using System.Collections.Generic;

namespace Padel
{
    public class Set
    {
        public List<Game> _games { get; } = new List<Game>(); //lagt till get


        public void Point(Player player)
        {
            var game = new Game(player, player);
            player.Score._Score -= 15;
            game.Point(player);
            _games.Add(game);            
            DetermineWinnerSet(player);
            

        }

        public void DetermineWinnerSet(Player player)
        {
            if (_games.Count == 4)
            {
                Console.WriteLine($"{player.Name} has won the set");
                _games.Clear();
               
            }
        }


    }
}
