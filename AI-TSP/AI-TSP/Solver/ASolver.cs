using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AI_TSP
{
    internal abstract class ASolver
    {
        protected List<Operator> Operators = new List<Operator>();
        private void GenerateOperators()
        {
            foreach (PointF p in Settings.points)
            {
                Operators.Add(new Operator(p));
            }
        }
        public ASolver()
        {
            GenerateOperators();
        }
        public abstract Operator SelectOperator();
        public abstract void Solve();
    }
}
