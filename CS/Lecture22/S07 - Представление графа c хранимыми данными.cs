using System;
using System.Collections.Generic;
using System.Linq;

namespace Slide07
{
    public class Edge<TNodeData, TEdgeData>
    {
        public readonly Node<TNodeData,TEdgeData> From;
        public readonly Node<TNodeData,TEdgeData> To;

        TEdgeData Data { get; set; }

        public Edge(Node<TNodeData,TEdgeData> first, Node<TNodeData,TEdgeData> second)
        {
            this.From = first;
            this.To = second;
        }
        public bool IsIncident(Node<TNodeData,TEdgeData> node)
        {
            return From == node || To == node;
        }
        public Node<TNodeData,TEdgeData> OtherNode(Node<TNodeData,TEdgeData> node)
        {
            if (!IsIncident(node)) throw new ArgumentException();
            if (From == node) return To;
            return From;
        }
    }

    public class Node<TNodeData, TEdgeData>
    {
        readonly List<Edge<TNodeData, TEdgeData>> edges = new List<Edge<TNodeData, TEdgeData>>();
        public readonly int NodeNumber;

        public Node(int number)
        {
            NodeNumber = number;
        }

        public IEnumerable<Node<TNodeData, TEdgeData>> IncidentNodes
        {
            get
            {
                return edges.Select(z => z.OtherNode(this));
            }
        }
        public IEnumerable<Edge<TNodeData, TEdgeData>> IncidentEdges
        {
            get
            {
                foreach (var e in edges) yield return e;
            }
        }
        public static Edge<TNodeData, TEdgeData> Connect(Node<TNodeData, TEdgeData> node1, Node<TNodeData, TEdgeData> node2, Graph<TNodeData, TEdgeData> graph)
        {
            if (!graph.Nodes.Contains(node1) || !graph.Nodes.Contains(node2)) throw new ArgumentException();
            var edge = new Edge<TNodeData, TEdgeData>(node1, node2);
            node1.edges.Add(edge);
            node2.edges.Add(edge);
            return edge;
        }
    }

    public class Graph<TNodeData, TEdgeData> 
    {
        private Node<TNodeData, TEdgeData>[] nodes;
        public Graph(int nodesCount)
        {
            nodes = Enumerable.Range(0, nodesCount).Select(z => new Node<TNodeData,TEdgeData>(z)).ToArray();
        }

        public int Length { get { return nodes.Length; } }

        public Node<TNodeData, TEdgeData> this[int index] { get { return nodes[index]; } }


        public IEnumerable<Node<TNodeData, TEdgeData>> Nodes
        {
            get
            {
                foreach (var node in nodes) yield return node;
            }
        }

        public void Connect(int index1, int index2)
        {
            Node<TNodeData, TEdgeData>.Connect(nodes[index1], nodes[index2], this);
        }

        public IEnumerable<Edge<TNodeData, TEdgeData>> Edges
        {
            get
            {
                return nodes.SelectMany(z => z.IncidentEdges).Distinct();
            }
        }
    }
}