using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hockey_Stats_Tracker___In_Class_Solution.Classes
{
    internal class Player
    {
        // properties
        // Name - string
        // Number
        // Shots - int - A count of how many shots they've taken
        // Goals - int - A count of how many goals they've scored
        // Assists - int - A count of the player's assists
        // Points - int - calculated... 2 * goals + assists
        // Accuracy - float - calculated... goals / shots * 100
        public string Name { get; }
        public float Shots { get; private set; }
        public float Goals { get; private set; }
        public int Assists { get; private set; }
        public float Points
        {
            get
            {
                return Goals * 2 + Assists;
            }
        }
        public float Accuracy
        {
            get
            {
                return Goals / Shots * 100;
            }
        }

        // constructors:
        // one with everything
        // one empty
        // one with just a name

        public Player()
        {
            Name = "James Johnson the Third LOL";
        }

        public Player(string name)
        {
            Name = name;
        }

        public Player(string name, float shots, float goals, int assists) : this(name)
        {
            Shots = shots;
            Goals = goals;
            Assists = assists;
        }
    }
}
