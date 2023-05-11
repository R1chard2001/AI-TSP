using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_TSP
{
    internal class ShortestRoute : ASolver
    {
        public override Operator SelectOperator()
        {
            int index = currentNode.OperatorIndex++;
            while (index < Operators.Count)
            {
                if (Operators[index].IsApplicable(currentNode.State))
                {
                    return Operators[index];
                }
                index = currentNode.OperatorIndex++;
            }
            return null;
        }
        List<Node> OpenNodes = new List<Node>();
        List<Node> CloseNodes = new List<Node>();
        Node currentNode;
        public override void Solve()
        {

            OpenNodes.Clear();
            CloseNodes.Clear();
            OpenNodes.Add(new Node(new State()));
            while (OpenNodes.Count > 0)
            {

                OpenNodes.Sort((x,y) => 
                x.State
                    .RouteLength()
                    .CompareTo(y.State.RouteLength()));


                currentNode = OpenNodes[0];
                OpenNodes.RemoveAt(0);
                CloseNodes.Add(currentNode);
                if (currentNode.IsTargetNode())
                {
                    break;
                }

                Operator o = SelectOperator();
                while (o != null)
                {
                    State newState = o.Apply(currentNode.State);
                    Node newNode = new Node(newState, currentNode);
                    if (!OpenNodes.Contains(newNode) &&
                        !CloseNodes.Contains(newNode))
                    {
                        OpenNodes.Add(newNode);
                    }
                    o = SelectOperator();
                }
                
            }
            if (currentNode.IsTargetNode())
            {
                Console.WriteLine("Solved");
                Console.WriteLine(currentNode);
            }
            else
            {
                Console.WriteLine("Cannot solve!");
            }
        }
    }
}
