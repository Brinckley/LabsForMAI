using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DriveTreeInit();
        }

        string fullPath;
        private void DriveTreeInit()
        {
            string[] drivesArray = Directory.GetLogicalDrives();
            treeView1.BeginUpdate();
            treeView1.Nodes.Clear();

            foreach (string s in drivesArray) {
                TreeNode drive = new TreeNode(s, 0, 0);
                treeView1.Nodes.Add(drive);
                getDirs(drive);
            }

            treeView1.EndUpdate();
        }

        public void getDirs(TreeNode node)
        {
            DirectoryInfo[] diArray; 
            node.Nodes.Clear(); 
            string fullPath = node.FullPath;

            // 
            DirectoryInfo di = new DirectoryInfo(fullPath);

            try
            {
                diArray = di.GetDirectories();
            }
            catch { return; }

            string str = "";
            
            foreach (DirectoryInfo dirinfo in diArray)
            {
                TreeNode dir = new TreeNode(dirinfo.Name, 0, 0);
                node.Nodes.Add(dir);
                str = richTextBox1.Text;
                str += dirinfo.Name + "\n";
                richTextBox1.Text = str;
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            treeView1.BeginUpdate();

            foreach (TreeNode node in e.Node.Nodes) {
                getDirs(node);
            }
            treeView1.EndUpdate();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode currentNode = e.Node;
            fullPath = currentNode.FullPath;

            DirectoryInfo directoryInfo = new DirectoryInfo(fullPath);
            FileInfo[] fileArray;
            DirectoryInfo[] dirArray;

            try
            {
                fileArray = directoryInfo.GetFiles();
                dirArray = directoryInfo.GetDirectories();
            }
            catch { return; }

            listView1.Items.Clear();

            foreach(DirectoryInfo directory in dirArray) {
                ListViewItem lvi = new ListViewItem(directoryInfo.Name);
                lvi.SubItems.Add("0");
                lvi.SubItems.Add(directoryInfo.LastWriteTime.ToString());

                listView1.Items.Add(lvi);
            }

            foreach (FileInfo fileInfo in fileArray) {
                ListViewItem lvi = new ListViewItem(fileInfo.Name);

                lvi.SubItems.Add(fileInfo.Length.ToString());
                lvi.SubItems.Add(fileInfo.LastWriteTime.ToString());
                listView1.Items.Add(lvi);
            }
        }

        private void ListView1_OnItemActivate(object sender, EventArgs e)
        {

            foreach (ListViewItem lvi in listView1.SelectedItems)
            {
                string ext = Path.GetExtension(lvi.Text).ToLower();
                if (ext == ".txt" || ext == ".htm" || ext == ".htm1")
                {
                    try
                    {
                        richTextBox1.LoadFile(Path.Combine(fullPath, lvi.Text),
                            RichTextBoxStreamType.PlainText);

                    } catch { return; }

                }
                else if (ext == ".rtf")
                {
                    try
                    {
                        richTextBox1.LoadFile(Path.Combine(fullPath, lvi.Text),
                            RichTextBoxStreamType.RichText);
                    } catch { return; }
                }

            }

        }

    }
}
