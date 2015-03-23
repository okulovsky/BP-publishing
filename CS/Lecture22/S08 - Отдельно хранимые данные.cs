using System;
using System.Collections.Generic;
using System.Linq;

using Slide06;

namespace Slide08
{
  

    public class Program
    {
        public static void MainX()
        {
            var graph = new Graph(10);
            var captions = new string[graph.Length];
            captions[0] = "A";

            var captions1 = new Dictionary<Node, string>();
            captions1[graph[0]] = "A";
        }
    }
}