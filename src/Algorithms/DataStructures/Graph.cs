using Algorithms.DataStructures.Graphs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DataStructures.Graph
{
    internal class Graph
    {
        public static void Green()
        {
            Console.WriteLine("Depth-FirstSearch");
            DepthFirstSearch.Node graph = new DepthFirstSearch.Node("A");
            graph.AddChild("B").AddChild("C").AddChild("D");
            graph.children[0].AddChild("E").AddChild("F");
            graph.children[2].AddChild("G").AddChild("H");
            graph.children[0].children[1].AddChild("I").AddChild("J");
            graph.children[2].children[0].AddChild("K");


            var result = graph.DepthFirstSearch(new List<string>());
            var i = 0;
        }
    }
}
