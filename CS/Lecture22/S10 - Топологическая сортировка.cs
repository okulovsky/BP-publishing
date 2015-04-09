using System;
using System.Collections.Generic;
using System.Linq;
using Slide06;

namespace Slide10
{
    class Program
    {



        public static List<Node> KahnAlgorithm(Graph graph)
        {
            var topSort = new List<Node>();
            var nodes = graph.Nodes.ToList();
            while (nodes.Count!=0)
            {
                var nodeToDelete = nodes
                    .Where(node => !node.IncidentEdges.Any(edge => edge.To == node))
                    .FirstOrDefault();

                if (nodeToDelete == null) return null;
                nodes.Remove(nodeToDelete);
                topSort.Add(nodeToDelete);
                foreach (var edge in nodeToDelete.IncidentEdges.ToList())
                    graph.Delete(edge);
            }
            return topSort;
        }







        public enum State
        {
            White,
            Gray,
            Black
        }

        public static List<Node> TarjanAlgorithm(Graph graph)
        {
            var topSort = new List<Node>();
            var states = graph.Nodes.ToDictionary(node => node, node => State.White);
            while (true)
            {
                var nodeToSearch = states
                    .Where(z => z.Value == State.White)
                    .Select(z => z.Key)
                    .FirstOrDefault();
                if (nodeToSearch == null) break;

                if (!TarjanDepthSearch(nodeToSearch, states, topSort))
                    return null;
            }
            topSort.Reverse();
            return topSort;
        }

        public static bool TarjanDepthSearch(Node node, Dictionary<Node, State> states, List<Node> topSort)
        {
            if (states[node] == State.Gray) return false;
            if (states[node] == State.Black) return true;
            states[node] = State.Gray;
            
            var outgoingNodes = node.IncidentEdges
                .Where(edge => edge.From == node)
                .Select(edge => edge.To);
            foreach (var nextNode in outgoingNodes)
                if (!TarjanDepthSearch(nextNode, states, topSort)) return false;

            states[node] = State.Black;
            topSort.Add(node);
            return true;
        }

        public static Graph MakeSortableGraph()
        {
            return Graph.MakeGraph(
                0,1,
                0,2,
                1,2,
                1,3,
                2,3,
                2,4,
                3,4);

        }

        public static Graph MakeNonSortableGraph()
        {
            return Graph.MakeGraph(
                0, 1,
                1, 2,
                2, 3,
                3, 1,
                2, 3,
                3, 4);
        }

        public static void PrintResult(List<Node> nodes)
        {
            if (nodes == null) 
                Console.WriteLine("Graph is not sortable");
            else
                Console.WriteLine(nodes
                                    .Select(z => z.NodeNumber.ToString())
                                    .Aggregate((a, b) => a + " " + b));
        }

        public static void MainX()
        {
            PrintResult(KahnAlgorithm(MakeSortableGraph()));
            PrintResult(KahnAlgorithm(MakeNonSortableGraph()));

            PrintResult(TarjanAlgorithm(MakeSortableGraph()));
            PrintResult(TarjanAlgorithm(MakeNonSortableGraph()));
        }
    }
}