using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_TSP
{
    internal class HeuristicNN : ASolver
    {
        public override Operator SelectOperator()
        {
            Operator best = null;
            float len = 0;
            for (int i = 0; i < Operators.Count; i++)
            {
                if (best == null && Operators[i].IsApplicable(currentState))
                {
                    best = Operators[i];
                    len = Operators[i].Apply(currentState).RouteLength(); 
                }
                else if (best != null && Operators[i].IsApplicable(currentState))
                {
                    State s = Operators[i].Apply(currentState);
                    if (s.RouteLength() < len)
                    {
                        best = Operators[i];
                        len = s.RouteLength();
                    }
                }
            }
            return best;
        }
        State currentState;
        public override void Solve()
        {
            currentState = new State();
            while (!currentState.IsTargetState())
            {
                Operator o = SelectOperator();
                Console.WriteLine(currentState);
                currentState = o.Apply(currentState);
            }
            Console.WriteLine(currentState);
        }
    }
}
