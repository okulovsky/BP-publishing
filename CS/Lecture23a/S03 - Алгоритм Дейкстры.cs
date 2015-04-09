using System;
using System.Linq;
using System.Collections.Generic;

namespace Slide01
{
    class DijrstraData
    {
        public Node Previous { get; set; }
        public double PathLength { get; set; }
    }


    static class ArgMinExtension
    {
        public static Tuple<TData,TGoal> ArgMin<TData,TGoal>(this IEnumerable<TData> sequence, Func<TData,TGoal> selector)
            where TGoal : IComparable
        {
            TData argMin = default(TData);
            var min = default(TGoal);
            var firstTime = true;
            foreach (var data in sequence)
            {
                var goal = selector(data);
                if (firstTime || min.CompareTo(goal) > 0)
                {
                    argMin = data;
                    min = goal;
                    firstTime = false;
                }
            }
            if (firstTime) return null;
            return Tuple.Create(argMin, min);
        }

    }

    public class Program
    {

        static List<Node> DijkstraAlgorithm(Graph graph, Dictionary<Edge,double> weights, Node start, Node end)
        {
            var visited = new Dictionary<Node, DijrstraData>() 
            {
                { start, new DijrstraData { PathLength=0, Previous=null } }
            };

            while (true)
            {
                var nextNodeData = graph.Nodes
                    .Where(node => !visited.ContainsKey(node))
                    .SelectMany(node => node.IncidentEdges
                                            .Select(edge => new
                                                {
                                                    Node = node,
                                                    From = edge.OtherNode(node),
                                                    Weight = weights[edge]
                                                }))
                                            .Where(data=>visited.ContainsKey(data.From))
                    .ArgMin(data => visited[data.From].PathLength + data.Weight);

                if (nextNodeData == null) return null;

                visited[nextNodeData.Item1.Node] = new DijrstraData
                {
                    PathLength = nextNodeData.Item2,
                    Previous = nextNodeData.Item1.From
                };

                if (nextNodeData.Item1.Node == end) break;
            }

            var result = new List<Node>();
            while (end != null)
            {
                result.Add(end);
                end = visited[end].Previous;
            }
            result.Reverse();
            return result;
        }
    }
}

/*
using System;
using System.Collections.Generic;
using System.Linq;

class DijkstraData
{
	public Node Previous { get; set; }
	public double Price { get; set; }
}

public class Program
{

	public static List<Node> Dijkstra(Graph graph, Dictionary<Edge,double> weights, Node start, Node end)
	{
		var track = new Dictionary<Node, DijkstraData>();
		track[start] = new DijkstraData { Previous = null, Price = 0 };
		while(true)
		{
			var bestPrice = double.PositiveInfinity;
			Node bestNode = null;
			Node preBestNode = null;
			foreach (var n in track.Keys)
			{
				foreach(var edge in n.IncidentEdges)
				{
					if (track.ContainsKey(edge.OtherNode(n))) continue;
					var price = track[n].Price + weights[edge];
					if (price < bestPrice)
					{
						bestPrice = price;
						preBestNode = n;
						bestNode = edge.OtherNode(preBestNode);
					}
				}
			}

			if (bestNode == null) break;

			track[bestNode] = new DijkstraData
			{
				Previous = preBestNode,
				Price = bestPrice
			};

			if (bestNode == end) break;
		}

		var result = new List<Node>();
		while(end!=null)
		{
			result.Add(end);
			end = track[end].Previous;
		}
		result.Reverse();
		return result;
	}

	public static void Main()
	{
		var graph = Graph.MakeGraph(
			0, 1,
			0, 2,
			0, 3,
			1, 3,
			2, 3
			);
		var weights = new Dictionary<Edge, double>();
		weights[graph[0, 1]] = 1;
		weights[graph[0, 2]] = 2;
		weights[graph[0, 3]] = 6;
		weights[graph[1, 3]] = 4;
		weights[graph[2, 3]] = 2;

		var path = Dijkstra(graph, weights, graph[0], graph[3]);
		foreach (var node in path)
			Console.WriteLine(node.NodeNumber);

	}
}
*/