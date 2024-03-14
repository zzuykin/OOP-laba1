using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    public class Node
    {
        public List<Node> Child { get; set; }
        public string Value { get; set; }
        public Node(string value) { 
            this.Value = value;
            Child = new List<Node>();
        }
        public void NewChild(Node node)
        {
            Child.Add(node);
        }
        public void RemoveChild(Node node)
        {
            Child.Remove(node);
        }
        public void ShowTree()
        {
            if(Child.Count > 0)
            {
                Console.WriteLine($"Потомки узла {Value} :");
                for (int i = 0; i < Child.Count; i++)
                {
                    Console.WriteLine(Child[i].Value);
                }
                for (int i = 0; i < Child.Count; i++)
                {
                    Child[i].ShowTree();
                }
            }
        }
    }
}
