using System;
using System.Collections.Generic;
using System.Linq;

namespace Slide05
{
    public class Node
    {
        private readonly List<Node> incidentNodes = new List<Node>(); 
        public readonly int NodeNumber;

        public Node(int number)
        {
            NodeNumber = number;
        }

        public IEnumerable<Node> IncidentNodes
        {
            get
            {
                foreach (var node in incidentNodes)
                    yield return node;
            }
        }

        public void Connect(Node node) 
        {
            incidentNodes.Add(node);
            node.incidentNodes.Add(this);
        }
    }

    public class Graph 
    {
        private Node[] nodes;
        public Graph(int nodesCount)
        {
            nodes = Enumerable.Range(0, nodesCount).Select(z => new Node(z)).ToArray();
        }

        public int Length { get { return nodes.Length; } }

        public Node this[int index] { get { return nodes[index]; } }

        public IEnumerable<Node> Nodes
        {
            get
            {
                foreach (var node in nodes) yield return node;
            }
        }
    }

    //Тут можно приконнектить к графу ноду, которая вне его
}