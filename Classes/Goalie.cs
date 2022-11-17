using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hockey_Stats_Tracker___In_Class_Solution.Classes
{
    internal class Goalie : Player
    {
        // properties:
        // Saves - integer that increments every time the goalie saves a shot
        // Shots against
        // Save Percentage - float - calculated: 
        public float Saves { get; private set; }
        public float ShotsAgainst { get; private set; }
        public float SavePercentage
        {
            get
            {
                return Saves / ShotsAgainst * 100;
            }
        }

        // constructors
        // empty constructor
        // one with name
        // one with everything

        public Goalie() : base() { }

        public Goalie(string name) : base(name) { }

        public Goalie(string name, float shots, float goals, 
            int assists, float saves, float shotsAgainst) 
            : base(name, shots, goals, assists)
        {
            Saves = saves;
            ShotsAgainst = shotsAgainst;
        }
    }
}
