using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Tournament.Models
{
    internal class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public int GamesPlayed { get; set; }

        public Player(string name)
        {
            Name = name;
        }
    }
}
