using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AI_TSP
{
    internal class Operator
    {
        public PointF Next;
        public Operator(PointF next)
        {
            Next = next;
        }
        public bool IsAplicable(State state)
        {
            return !state.Route.Contains(Next);
        }
        public State Apply(State state)
        {
            State newState = (State)state.Clone();
            newState.Route.Add(Next);
            return newState;
        }
    }
}
