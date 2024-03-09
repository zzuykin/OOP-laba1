using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    public class Node
    {
        public List<Node> child { get; set; }
        public string value { get; set; }
        public Node(string value) { 
            this.value = value;
            child = new List<Node>();
        }
        public void NewChild(Node node)
        {
            child.Add(node);
        }
        public void RemoveChild(Node node)
        {
            child.Remove(node);
        }
        public void ShowTree()
        {
            if(child.Count > 0)
            {
                Console.WriteLine($"Потомки узла {value} :");
                for (int i = 0; i < child.Count; i++)
                {
                    Console.WriteLine(child[i].value);
                }
                for (int i = 0; i < child.Count; i++)
                {
                    child[i].ShowTree();
                }
            }
        }
    }
}
