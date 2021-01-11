using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPoop.Classes
{
    class Node
    {
        int number;
        string text;
        bool thisN;
        int level;
        int position;
        Node left;
        Node right;
        
        public Node() {
            number = 0;
            Level = 0;
            thisN = false;
            Position = 0;
            text = "";
            left = null;
            right = null;
        }

        public Node(int number, string text) {
            this.Number = number;
            this.Text = text;
        }

        public string Text { get => text;
            set {
                try { text = value; }
                catch(FormatException) { }
            } }

        public int Number { get => number;
            set {
                try { number = value; }
                catch (FormatException) { }
            }
        }

        public void Add(Node node, int level, int position) {
            if (node == null) { return; }
            if (number > node.number)
            {
                if (left == null)
                {
                    node.Level = level + 10;
                    node.Position = position - level;
                    left = node;
                }
                else
                {
                    left.Add(node, level + 10, position - 5);
                }
            }
            if(number < node.number) {
                if (right == null)
                {
                    node.Level = level + 10;
                    node.Position = position + level ;
                    right = node;
                }
                else
                {
                    right.Add(node, level + 10, position + 5);
                    
                }
            }
        }

        public string Seeker(int num)
        {
            if (num > number)
            {
                if (right == null) { return "No such value!"; }
                return right.Seeker(num);
            }
            if (num < number) {
                if (left == null) { return "No such value!"; }
                return left.Seeker(num);
            }
            if (num == number) {
                return text;
            }
            return "No such value!";
        }

        internal Node Right { get => right; set => right = value; }
        internal Node Left { get => left; set => left = value; }
        public int Position { get => position; set => position = value; }
        public int Level { get => level; set => level = value; }
    }
}

