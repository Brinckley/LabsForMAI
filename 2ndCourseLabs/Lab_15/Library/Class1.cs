using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{//Delegate Pattern
    public class Node
    {
        string name;
        int number;

        public Node(string name, int number)
        {
            this.name = name;
            this.number = number;
        }

        public string Name { get => name; }
        public int Number { get => number; }
    }

    public class NodeList
    {
        List<Node> nodes;

        public Node this[int index]
        {
            get
            {
                return nodes[index];
            }
            set
            {
                nodes[index] = value;
            }
        }

        public int Size() {
            if (nodes != null) {
                return nodes.Count;
            }
            return 0;
        }

        public void Add(Node node)
        {
            if (nodes != null)
            {
                nodes.Add(node);
                return;
            }
            nodes = new List<Node>();
            nodes.Add(node);
        }

        public void Remove(String delete)
        {
            if (nodes != null)
            {
                for (int i = 0; i < nodes.Count; ++i)
                {
                    if (nodes[i].Name == delete)
                    {
                        nodes.RemoveAt(i);
                        break;
                    }
                }
            }
        }

        public int IndexOf(string name)
        {
            if (nodes != null)
            {
                for (int i = 0; i < nodes.Count; ++i)
                {
                    if (nodes[i].Name == name)
                    {
                        return i;
                    }
                }
            }
            return 0;
        }

        public string findBiggestNumber()
        {
            if (nodes != null)
            {
                int max = nodes[0].Number;
                string smax = nodes[0].Name;
                for (int i = 0; i < nodes.Count; ++i)
                {
                    if (nodes[i].Number > max)
                    {
                        max = nodes[i].Number;
                        smax = nodes[i].Name;
                    }
                }
                return smax;
            }
            return "";
        }
    }
}
