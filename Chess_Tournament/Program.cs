using Chess_Tournament.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Tournament
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // We need to create a Chess tournament
            // This chess tournament has the following rules
            // (V) 1. we dont know how many players we apply to the tournament
            // () 2. each player needs to play 3 games
            // 3. the games last for 3 minutes
            // the application needs to randomly create games for each player with a diffrent opponent 
            // every time 
            // each player plays a move (we dont care about the specifics of the move)
            // when the 3 minutes time frame expires the game must declare a winner (Player 1 or Player 2) Randomly
            // when all the games are finished we need to show the winners
            // each winner gets 3 points for each win

            // we need also to create a Children chess tournament that is the same as above (rules) exept 
            // that the games the child needs to play is only 1

            // Tournament - list of player(must be above= 4), list of game (minimum 3), 
            // Player - name, (int) score, gamesPlayed
            // Game - timer, Player1, Player2

            IEnumerable<Player> players = new List<Player>()
            {
                new Player("John"),
                new Player("Ann"),
                new Player("Tom"),
                new Player("Mparmpamprilios"),
                new Player("1"),
                new Player("2"),
                new Player("3"),
                new Player("4")
            };

            List<Player> listOfPlayers = players.ToList();
            Tournament tournament = new Tournament(listOfPlayers);

            Player winner = null;
            foreach (Player player in listOfPlayers)
            {
                int max = 0;
                if (max < player.Score)
                {
                    winner = player;
                    max = player.Score;
                }
            }

            Console.WriteLine($"Winner: {winner.Name}");
        }
    }
}
