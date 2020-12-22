using Lab_15.Classes;
using System;
using Library;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_15
{
    public partial class Form1 : Form
    {
        public static NodeList nodeList;
        Facade facade;

        public Form1()
        {
            InitializeComponent();
            nodeTreeView.ExpandAll();
            nodeList = new NodeList();
            facade = new Facade(new NameWorker(), new NumberWorker());
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") {
                if (nodeTreeView.Nodes.Count == 0) {
                    try {
                        nodeTreeView.Nodes.Add(textBox1.Text);
                        ListViewItem listViewItem = new ListViewItem(new string[] { textBox1.Text, nodeTreeView.GetNodeCount(true).ToString(), "Add"});
                        listView1.Items.Add(listViewItem);
                        nodeList.Add(new Node(textBox1.Text, nodeTreeView.GetNodeCount(true)));
                    } catch (FormatException) { }
                } else {
                    if (nodeTreeView.SelectedNode != null) {
                        try {
                            nodeTreeView.SelectedNode.Nodes.Add(textBox1.Text);
                            nodeTreeView.SelectedNode.ExpandAll();
                            ListViewItem listViewItem = new ListViewItem(new string[] { textBox1.Text, nodeTreeView.GetNodeCount(true).ToString(), "Add"});
                            listView1.Items.Add(listViewItem);
                            nodeList.Add(new Node(textBox1.Text, nodeTreeView.GetNodeCount(true)));
                        } catch (FormatException) { }
                    }
                    else {
                        try {
                            nodeTreeView.Nodes.Add(textBox1.Text);
                            ListViewItem listViewItem = new ListViewItem(new string[] { textBox1.Text, nodeTreeView.GetNodeCount(true).ToString(), "Add"});
                            listView1.Items.Add(listViewItem);
                            nodeList.Add(new Node(textBox1.Text, nodeTreeView.GetNodeCount(true)));
                        } catch (FormatException) { }
                    }
                }
            }
            textBox1.Clear();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (nodeTreeView.Nodes.Count != 0) {
                if (nodeTreeView.SelectedNode != null) {
                    ListViewItem listViewItem = new ListViewItem(new string[] { nodeTreeView.SelectedNode.Text, (nodeTreeView.GetNodeCount(true) - 1).ToString(), "Delete" });
                    listView1.Items.Add(listViewItem);
                    nodeList.Remove(nodeTreeView.SelectedNode.Text);
                    nodeTreeView.SelectedNode.Remove();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nodeTreeView.Nodes.Count > 0)
            {
                MessageBox.Show(nodeList.findBiggestNumber());
            }
            else {
                MessageBox.Show("No value yet!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {
            if (nodeTreeView.Nodes.Count > 0)
            {
                if (NameCheckBox.Checked)
                {
                    if (NumberCheckBox.Checked)
                    {
                        facade.randomObject();
                    }
                    else
                    {
                        facade.randomName();
                    }
                }
                else
                {
                    if (NumberCheckBox.Checked)
                    {
                        facade.randomNumber();
                    }
                    else
                    {
                        MessageBox.Show("No value yet!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else {
                MessageBox.Show("No value yet!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }
    }
}
