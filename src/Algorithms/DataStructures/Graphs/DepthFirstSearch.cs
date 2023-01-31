using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DataStructures.Graphs
{
    internal class DepthFirstSearch
    {
        public class Node
        {
            public string name;
            public List<Node> children = new List<Node>();

            public Node(string name)
            {
                this.name = name;
            }

            public List<string> DepthFirstSearch(List<string> array)
            {
                return Recursion(this, array);
            }

            public List<string> Recursion(Node node, List<string> array)
            {
                array.Add(node.name);

                for (var i = 0; i < node.children.Count; i++)
                {
                    Recursion(node.children[i], array);
                }

                return array;
            }

            public Node AddChild(string name)
            {
                Node child = new Node(name);
                children.Add(child);
                return this;
            }
        }
    }
}
