using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hockey_Stats_Tracker___In_Class_Solution.Classes
{
    internal class Game
    {
        // properties
        // Teams - List<Team> - HomeTeam AwayTeam
        // Score - int - keep track of the scores of the two teams
        //       - Dictionary<Team, int>
        //       - Two different integers - T1Points, T2Points - HomePoints AwayPoints

        public int HomeScore { get; private set; }
        public int AwayScore { get; private set; }
        public Team Home { get; }
        public Team Away { get; }

        public Game(Team home, Team away)
        {
            Home = home;
            Away = away;
        }

        public void Play()
        {
            // needs amount of shots taken - total
            // divide evenly between teams
            // gonna need some randomness - Helper.GetRandomNumber, and Helper.GetRandomPercent() to the rescue

            int totalShots = Helper.GetRandomPercent() / 2;

            // need to create a loop - runs totalShots times
            // randomly determine if they score
            // need a bool - did the shot score? true/false - determined by rng

        }
    }
}
