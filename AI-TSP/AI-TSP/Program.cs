using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_TSP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Settings.GeneratePoints(5, 0, 10);
            ASolver s = new HeuristicNN();
            s.Solve();
            s = new ShortestRoute();
            s.Solve();
            Console.ReadLine();
        }
    }
}
