using System;

namespace Padel
{

    public class Game
    {
        private Player _player1;
        private Player _player2;

        public Game(Player player1, Player player2)
        {
            _player1 = player1;
            _player2 = player2; //Change the variabel name 
        }

        public void Point(Player player)
        {
            for (int i = 0; i < 15; i++)
            {
                player.Point(); // change to only player
            }
            if (Score(player)._Score > 40)
            {
                Console.WriteLine(ScoreString());
                _player1.Score._Score = 0;
                _player2.Score._Score = 0;
            }

        }

        public Score Score(Player player) // change to Player player
        {
            return player.Score; // Chane to only player

        }

        public string ScoreString()
        {
            if (_player1.Score._Score > 40) //change to 40 insted of 4
            {
                return "Player 1 wins";
            }
            return "Player 2 wins";

        }
    }
}
