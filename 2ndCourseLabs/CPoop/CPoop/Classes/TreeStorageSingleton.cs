using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPoop.Classes
{
    class TreeStorageSingleton
    {
        private static TreeStorageSingleton instance;

        public string[] arrayText;

        private Node[] node;

        private TreeStorageSingleton()
        { }

        public static TreeStorageSingleton getInstance()
        {
            if (instance == null)
            {
                instance = new TreeStorageSingleton();

            }
            return instance;
        }

        public void setTree(string s) {
            if (instance != null) {
                arrayText = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }
        }

        public Node[] getNode() {
            return node;
        }

        public Node[] arrayLengthsReturner() {
            if (arrayText.Length == 0 || instance == null) { return new Node[0]; }
            node = new Node[arrayText.Length];

            for (int i = 0; i < node.Length; ++i)
            {
                node[i] = new Node();
                node[i].Number = arrayText[i].Length;
                node[i].Text = arrayText[i];
            }
            return node;
        }

        public List<int> arrayNumbers() {
            List<int> numbers = new List<int>();
            for (int i = 0; i < node.Length; ++i) {
                if (!numbers.Contains(node[i].Number)) {
                    numbers.Add(node[i].Number);
                }
            }
            return numbers;
        }
        
    }
}
