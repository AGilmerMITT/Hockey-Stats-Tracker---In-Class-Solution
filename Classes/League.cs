using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hockey_Stats_Tracker___In_Class_Solution.Classes
{
    internal class League
    {
        // properties
        // Teams - collection - List<Team>
        // List<Player> - All the players in the league
        // GamesPlayed - int - calculated: sum(games played) across all teams / 2
        // string Name = "NHL"

        public string Name { get; }
        public List<Player> Players { get; private set; } = new();
        public List<Team> Teams { get; private set; } = new();

        public int GamesPlayed
        {
            get
            {
                int result = 0;
                foreach (Team t in Teams)
                {
                    result += t.GamesPlayed;
                }
                return result / 2;
            }
        }

        public League(string name)
        {
            Name = name;
        }

        public void AddTeam(Team team)
        {
            Teams.Add(team);
        }

        public void PopulateLeagueTeamsAndPlayers(int teamCount, int playerCount)
        {
            // clear out any past teams/players
            Teams = new();

            // outer loop: making individual teams
            for (int i = 1; i <= teamCount; i++)
            {
                Team team = new($"Team {i}");

                // inner loop: making individual players
                for (int j = 1; j <= playerCount; j++)
                {
                    Player player = new Player($"Player {i}-{j}");
                    team.AddPlayer(player);
                }

                // gotta make a goalie
                Goalie goalie = new($"Goalie {i}");
                team.AddPlayer(goalie);

                this.AddTeam(team);
            }
        }

        public void PlayLeague()
        {
            // play all the games
            // run through all of the Team v Team matches
            // for each - make a new game (Home, away)
            // game.Play()

            for (int i = 0; i < Teams.Count; i++)
            {
                for (int j = 0; j < Teams.Count; j++)
                {
                    if (i != j)
                    {
                        Console.WriteLine("Playing match");
                        Game game = new Game(Teams[i], Teams[j]);
                        game.Play();
                    }
                }
            }
        }
    }
}
