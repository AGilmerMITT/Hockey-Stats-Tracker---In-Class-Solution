using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hockey_Stats_Tracker___In_Class_Solution.Classes
{
    internal static class Helper
    {
        static private Random _rng = new();

        public static int GetRandomNumber()
        {
            return _rng.Next();
        }

        public static int GetRandomPercent()
        {
            return _rng.Next(1, 101);
        }
    }
}
