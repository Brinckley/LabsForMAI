using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_14
{
    public partial class ClipForm : Form
    {
        bool checkClip;
        ClipPoints[] clips;
        int counter;

        List<Point> points;
        bool clicked;

        public ClipForm()
        {
            InitializeComponent();
            pictureBox1.BackColor = Color.Violet;
            checkClip = false;

            clips = new ClipPoints[2];
            
            counter = 0;
            points = new List<Point>();
            clicked = false;
        }

        private void buttonClip_Click(object sender, EventArgs e)
        {
            checkClip = true;
            buttonCLip.Enabled = false;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (checkClip && counter < 2)
            {
                clips[counter] = new ClipPoints(e.X, e.Y);
                counter++;
                pictureBox1.Invalidate();
            }
            else {
                clicked = true;
                points.Add(new Point(e.X, e.Y));
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (clicked) {
                points.Add(new Point(e.X, e.Y));
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (clicked) {
                points.Add(new Point(e.X, e.Y));
                pictureBox1.Invalidate();
                clicked = false;
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (checkClip)
            {
                for (int i = 0; i < counter; ++i)
                {
                    e.Graphics.DrawEllipse(new Pen(Color.Red, 2), clips[i].X, clips[i].Y, 2, 2);
                }
                if (counter == 2)
                {
                    e.Graphics.SetClip(new Rectangle(clips[0].X, clips[0].Y, Math.Abs(clips[0].X - clips[1].X), Math.Abs(clips[0].Y - clips[1].Y)));
                    e.Graphics.DrawRectangle(new Pen(Color.Red, 2), clips[0].X, clips[0].Y, Math.Abs(clips[0].X - clips[1].X), Math.Abs(clips[0].Y - clips[1].Y));
                    e.Graphics.FillRectangle(Brushes.AliceBlue, clips[0].X, clips[0].Y, Math.Abs(clips[0].X - clips[1].X), Math.Abs(clips[0].Y - clips[1].Y));
                }
            }

            for (int i = 0; i < points.Count; ++i) {
                e.Graphics.DrawEllipse(new Pen(Color.Black, 3), points[i].X, points[i].Y, 2, 2);
            }

        }
    }

    class ClipPoints
    {
        int x;
        int y;

        public ClipPoints(int x, int y) { this.X = x; this.Y = y; }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
    }

}
