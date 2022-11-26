using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Tournament.Models
{
    internal class Tournament
    {
        public List<Player> Players { get; set; }
        public List<Game> Games { get; set; } = new List<Game>();

        public Tournament(List<Player> players)
        {
            Players = players;
            CreateGames();
        }

        public List<Game> CreateGames()
        {
            if (Players.Count >= 4)
            {
                List<Player> a = new List<Player>(Players);
                List<Player> ab = new List<Player>(Players);
                foreach (Player x in a)
                {
                    int counter = 0;
                    foreach (Player y in ab)
                    {
                        if (y != x)
                        {
                            //game(x,y)
                            Games.Add(new Game(30, x, y));
                            Console.WriteLine($"Game: {x.Name} {y.Name}");
                            counter++;
                            if (counter == 3)
                            {
                                break;
                            }
                        }
                    }
                    ab.Remove(x);
                }
                return null;
            }

            else
            {
                throw new Exception("Not enough Players for the Tournament");
                return null;
            }
        }

    }
}
