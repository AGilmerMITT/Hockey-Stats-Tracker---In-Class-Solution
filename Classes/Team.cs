using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hockey_Stats_Tracker___In_Class_Solution.Classes
{
    internal class Team
    {
        // dictionary<int, string or string,int> players
        // maybe a list<Player> for players
        // Wins - int
        // Losses - int
        // Ties - int
        // GamesPlayed - int / List<Game>
        // LeaguePoints - int or float - calculate: 2 * Wins + Ties
        // Name - string
        // GoalsFor - int
        // GoalsAgainst - int

        public string Name { get; }
        public int Wins { get; private set; }
        public int Losses { get; private set; }
        public int Ties { get; private set; }
        public int LeaguePoints
        {
            get
            {
                return Wins * 2 + Ties;
            }
        }
        public int GoalsFor { get; private set; }
        public int GoalsAgainst { get; private set; }
        public int GamesPlayed
        {
            get
            {
                return Wins + Losses + Ties;
            }
        }

        public List<Player> Players { get; private set; } = new();

        // constructors
        public Team(string name)
        {
            Name = name;
        }

        public void AddPlayer(Player player)
        {
            Players.Add(player);
        }
    }
}
