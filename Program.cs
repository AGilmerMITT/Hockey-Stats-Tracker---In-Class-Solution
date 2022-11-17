
using Hockey_Stats_Tracker___In_Class_Solution.Classes;
using System.Runtime.InteropServices;

namespace Hockey_Stats_Tracker___In_Class_Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // data
            // 4 teams
            // teams need 4 regular players
            // teams need 1 goalie (which is also a player)
            // We need to have a league

            League nhl = new("NHL");

            nhl.PopulateLeagueTeamsAndPlayers(4, 4);
            nhl.PlayLeague();
            //nhl.PrintResults();
        }

    }
}