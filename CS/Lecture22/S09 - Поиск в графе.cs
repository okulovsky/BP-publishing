using System;
using System.Collections.Generic;
using System.Linq;

using Slide06;

namespace Slide09
{
    public static class NodeExtensions
    {
        public static IEnumerable<Node> DepthSearch(this Node startNode)
        {
            var visited = new HashSet<Node>();
            var stack = new Stack<Node>();
            stack.Push(startNode);
            while (stack.Count != 0)
            {
                var node = stack.Pop();
                if (visited.Contains(node)) continue;
                visited.Add(node);
                yield return node;
                foreach (var incidentNode in node.IncidentNodes)
                    stack.Push(incidentNode);
            }
        }

        public static IEnumerable<Node> BreadthSearch(this Node startNode)
        {
            var visited = new HashSet<Node>();
            var stack = new Queue<Node>();
            stack.Enqueue(startNode);
            while (stack.Count != 0)
            {
                var node = stack.Dequeue();
                if (visited.Contains(node)) continue;
                visited.Add(node);
                yield return node;
                foreach (var incidentNode in node.IncidentNodes)
                    stack.Enqueue(incidentNode);
            }
        }
    }

    class Program
    {
        public static void MainX()
        {
            var graph = Graph.MakeGraph(
                0, 1,
                0, 2,
                1, 3,
                1, 4,
                2, 3,
                3, 4);


            Console.WriteLine(graph[0]
                .DepthSearch()
                .Select(z => z.NodeNumber.ToString())
                .Aggregate((a, b) => a + " " + b));

            Console.WriteLine(graph[0]
                .BreadthSearch()
                .Select(z => z.NodeNumber.ToString())
                .Aggregate((a, b) => a + " " + b));

        }
    }
}