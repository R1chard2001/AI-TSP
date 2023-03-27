using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AI_TSP
{
    internal static class Settings
    {
        public static List<PointF> points = new List<PointF>();
        public static void GeneratePoints(int n, int min, int max)
        {
            Random random = new Random(5);
            for (int i = 0; i < n; i++)
            {
                double x = random.NextDouble() * (max - min) + min;
                double y = random.NextDouble() * (max - min) + min;
                points.Add(new PointF((float) x, (float) y));
            }
        }
    }
}
