using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_13
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            ScrollLabel.Text = textSizeTrackBar.Value.ToString();
        }

        public static int size;

        private void textSizeTrackBar_Scroll(object sender, EventArgs e)
        {
            ScrollLabel.Text = textSizeTrackBar.Value.ToString();
            size = textSizeTrackBar.Value;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Form1.timer.Stop();
            this.Close();
        }

        private void textSizeTrackBar_CursorChanged(object sender, EventArgs e)
        {
            ScrollLabel.Text = textSizeTrackBar.Value.ToString();
            size = textSizeTrackBar.Value;
        }
    }
}
