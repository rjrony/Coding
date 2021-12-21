using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.October
{
	public class _133_CloneGraph
	{

        // Definition for a Node.
        public class Node
        {
            public int val;
            public IList<Node> neighbors;

            public Node()
            {
                val = 0;
                neighbors = new List<Node>();
            }

            public Node(int _val)
            {
                val = _val;
                neighbors = new List<Node>();
            }

            public Node(int _val, List<Node> _neighbors)
            {
                val = _val;
                neighbors = _neighbors;
            }
        }

        public Node CloneGraph(Node node)
		{
            return Clone(node, new Dictionary<int, Node>());
		}

        private Node Clone(Node node, Dictionary<int, Node> nodeMap)
        {
            if (node == null) return node;
            //Node node1;
            if (nodeMap.TryGetValue(node.val, out var node1)) return node1;

            node1 = new Node(node.val);
            nodeMap.Add(node1.val, node1);

            foreach (var item in node.neighbors)
            {
                node1.neighbors.Add(Clone(item, nodeMap));
            }
            return node1;
        }

        public void Test()
        {
            var nodeList = new List<Node>
            {
                new Node(2, new List<Node>{ new Node(3)}),
                new Node(4)
            };        
            
            Node node = new Node(1, nodeList);

            var copyNode = CloneGraph(node);
            //Console.WriteLine();

        }
    }
}
