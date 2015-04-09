using System;
using System.Collections.Generic;

namespace Slide04
{
    public class Node
    {
        public readonly List<Node> IncidentNodes = new List<Node>();
    }

    public class Graph
    {
        public readonly List<Node> Nodes = new List<Node>();
    }

}