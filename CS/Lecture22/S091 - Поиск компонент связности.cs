using System;
using System.Collections.Generic;
using System.Linq;

using Slide06;
using Slide09;

namespace Slide92
{
    

    class Program
    {
        public static List<List<Node>> FindConnectedComponents(Graph graph)
        {
            var result = new List<List<Node>>();
            var markedNodes = new HashSet<Node>();
            while (true)
            {
                var nextNode = graph.Nodes.Where(node => !markedNodes.Contains(node)).FirstOrDefault();
                if (nextNode == null) break;
                var breadthSearch = nextNode.BreadthSearch().ToList(); ;
                result.Add(breadthSearch.ToList());
                foreach (var node in breadthSearch)
                    markedNodes.Add(node);
            }
            return result;
        }


        public static void MainX()
        {
            var graph = Graph.MakeGraph(
                1,2,
                3,4,
                4,5,
                5,3);

            var connected = FindConnectedComponents(graph);
            Console.WriteLine(
                connected
                    .Select(component => component.Select(node => node.NodeNumber.ToString()).Aggregate((a, b) => a + " " + b))
                    .Aggregate((a, b) => a + "\n" + b));
        }
    }
}