using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AI_TSP
{
    internal class State : ICloneable
    {
        public List<PointF> Route;
        public State()
        {
            Route = new List<PointF>();
        }
        public float RouteLength()
        {
            float len = 0;
            for (int i = 0; i < Route.Count - 1; i++)
            {
                len += (float)Math.Sqrt(
                        (Route[i].X - Route[i + 1].X)
                         * 
                        (Route[i].X - Route[i + 1].X)
                         +
                        (Route[i].Y - Route[i + 1].Y)
                         *
                        (Route[i].Y - Route[i + 1].Y)
                    );
            }
            return len;
        }

        public bool IsTargetState()
        {
            return Route.Count == Settings.points.Count;
        }

        public object Clone()
        {
            State state = new State();
            state.Route = new List<PointF>(Route);
            return state;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < Route.Count - 1; i++)
            {
                sb.Append("(" + Route[i].X + ", " + Route[i].Y + ")->");
            }
            if (Route.Count > 0)
            {
                sb.AppendLine("(" + Route.Last().X + ", "
                    + Route.Last().Y + ")");
            }
            sb.AppendLine("Route length: " + RouteLength());
            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            State other = obj as State;
            if (other.Route.Count != Route.Count)
            {
                return false;
            }
            for (int i = 0; i < Route.Count; i++)
            {
                if (!other.Route[i].Equals(Route[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
