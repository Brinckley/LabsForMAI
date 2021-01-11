using CPoop.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPoop
{
    public partial class GraphSeeker : Form
    {
        TreeStorageSingleton tree;
        Node root;
        bool painter;

        List<int> oX;
        List<int> oY;
        List<int> oN;

        public GraphSeeker()
        {
            InitializeComponent();
            tree = TreeStorageSingleton.getInstance();
            treeCreater();
            oX = new List<int>();
            oY = new List<int>();
            oN = new List<int>();

            treeRunner(root);
            painter = true;
        }

        private void numberSymbolsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            try {
                MessageBox.Show(root.Seeker(Convert.ToInt32(numberSymbolsTextBox.Text)), "Your answer!");
            } catch(FormatException) { }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (painter)
            {
                for (int i = 0; i < oX.Count; ++i) {
                    e.Graphics.DrawString(oN[i].ToString(), new Font("Lato", 15, FontStyle.Regular), Brushes.Red,
                        oX[i], oY[i]);
                }
            }
        }

        private void treeCreater() {
            Node[] nodes = tree.arrayLengthsReturner();
            root = nodes[0];
            for (int i = 1; i < nodes.Length; ++i) {
                root.Add(nodes[i], 10, 0);
            }
        }

        private void treeRunner(Node node) {
            if (node == null) { return; }
                oX.Add(pictureBox1.Width / 2 + node.Position*2);
                oY.Add(pictureBox1.Height / 5 + 3 + node.Level*2);
                oN.Add(node.Number);
            treeRunner(node.Left);
            treeRunner(node.Right);
        }

        
    }
}
