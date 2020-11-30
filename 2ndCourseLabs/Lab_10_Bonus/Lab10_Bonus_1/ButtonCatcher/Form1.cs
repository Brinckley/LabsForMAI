using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonCatcher
{
    public partial class Form1 : Form
    {
        Random random;
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "You've clicked the button!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "WOW!";
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            random = new Random();

            int x = button2.Location.X;
            int y = button2.Location.Y;

            int rx = random.Next(-10, 10);
            int ry = random.Next(-10, 10);

            bool flag = false;
            do
            {
                if (x + rx > 0 && x + rx < this.ClientSize.Width - button2.Width/2 && y + ry < this.ClientSize.Height - button2.Height / 2 && y + ry > 0)
                {
                    button2.Location = new Point(x + rx, y + ry);
                    flag = true;
                }
                else {
                    rx = random.Next(-10, 10);
                    ry = random.Next(-10, 10);
                }
            } while (flag == false);
        }
    }
}
