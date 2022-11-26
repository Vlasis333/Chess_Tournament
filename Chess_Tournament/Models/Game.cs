using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Tournament.Models
{
    internal class Game
    {
        public int Timer { get; set; }
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }

        public Game(int timer, Player player1, Player player2)
        {
            Timer = timer;
            Player1 = player1;
            Player2 = player2;

            Random rand = new Random();

            for (int i = 0; i < Timer; i++)
            {

                if (rand.Next(0, 2) == 0)
                {
                    player1.Score += 3;
                }
                else
                {
                    player2.Score += 3;
                }
            }

            player1.GamesPlayed += 1;
            player2.GamesPlayed += 1;
        }
    }
}
