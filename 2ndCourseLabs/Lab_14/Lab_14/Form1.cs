using Lab_14.Classes;
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
    enum types { line, pixel}

    public partial class Lab_14 : Form
    {
        public static bool screenWorking;
        
        bool lineChoice;
        bool pixelChoice;

        Pen penPaint;
        Color currentColor;
        bool clickedPaint;
        int mouse_paint_x;
        int mouse_paint_y;
        int mouse_delta_x;
        int mouse_delta_y;
        
        List<TwoPoints> listPoints;
        List<Pixel> listPointsPixel;

        Point[] curveRandom;
        Point[] curveBezier;

        List<types> history;

        Timer timerLoading;
        int tick;
        bool loadingScreen;

        float angle;
        int deep = 0;

        Switcher switcher;
        ScreenSwitcher screenSwitcher;

        public Lab_14()
        {
            InitializeComponent();
            currentColor = Color.Black;
            penPaint = new Pen(currentColor, 5);
            clickedPaint = false;
            lineChoice = false;
            pixelChoice = true;
            paintPictureBox.BorderStyle = BorderStyle.FixedSingle;
            listPoints = new List<TwoPoints>();
            listPointsPixel = new List<Pixel>();
            curveRandom = new Point[0];
            curveBezier = new Point[4];
            screenWorking = false;
            loadingScreen = false;
            angle = 30;
            panelDragNDrop.AllowDrop = true;
            deep = 0;
            history = new List<types>();

            screenSwitcher = new ScreenSwitcher(); //command realisation
            switcher = new Switcher(new ScreenCommand(screenSwitcher));


        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            penPaint.Color = colorDialog.Color;
        }
       
        private void paintPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if(screenWorking && !loadingScreen) {
                clickedPaint = true;
                if (lineChoice) {
                    mouse_paint_x = e.X;
                    mouse_paint_y = e.Y;
                } else if (pixelChoice) {
                    listPointsPixel.Add(new Pixel(new Point(e.X, e.Y), penPaint.Color));
                    history.Add(types.pixel);
                    deep++;
                }
            }
            
        }

        private void paintPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (screenWorking && !loadingScreen) {
                if (clickedPaint) {
                    if (lineChoice) {
                        mouse_delta_x = e.X;
                        mouse_delta_y = e.Y;
                    } else if (pixelChoice) {
                        listPointsPixel.Add(new Pixel(new Point(e.X, e.Y), penPaint.Color));
                        history.Add(types.pixel);
                        deep++;
                    }
                }
            }
            
            paintPictureBox.Invalidate();
        }

        private void paintPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (screenWorking && !loadingScreen) {
                clickedPaint = false;
                if (lineChoice == true) {
                    TwoPoints two = new TwoPoints(new Point(mouse_paint_x, mouse_paint_y), new Point(mouse_delta_x, mouse_delta_y), penPaint.Color);
                    listPoints.Add(two);
                    history.Add(types.line);
                } else if (pixelChoice) {
                    listPointsPixel.Add(new Pixel(new Point(e.X, e.Y), penPaint.Color));
                    history.Add(types.pixel);
                    deep++;
                }
            }
        }

        private void paintPictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (screenWorking)
            {
                if (lineChoice) {
                    TwoPoints two = new TwoPoints(new Point(mouse_paint_x, mouse_paint_y), new Point(mouse_delta_x, mouse_delta_y), penPaint.Color);

                    e.Graphics.DrawLine(penPaint, two.First, two.Second);
                }
                foreach (TwoPoints point in listPoints) {
                    if (point.Seen) {
                        e.Graphics.DrawLine(new Pen(point.Color, penPaint.Width), point.First, point.Second);
                    }
                }
                foreach (Pixel point in listPointsPixel) {
                    if (point.Seen) {
                        e.Graphics.DrawEllipse(new Pen(point.Color, penPaint.Width), point.Point.X, point.Point.Y, 2, 2);
                    }
                }
                if (curveRandom.Length > 0) {
                    e.Graphics.DrawCurve(penPaint, curveRandom);
                }
                if (curveBezier.Length > 0) {
                    e.Graphics.DrawBeziers(penPaint, curveBezier);
                }
                
            } else {
                if (paintPictureBox.BackColor == Color.White && loadingScreen == true) {
                    e.Graphics.DrawString("Loading...", new Font("Arial", 14, FontStyle.Bold), Brushes.Aqua, paintPictureBox.Width / 3, paintPictureBox.Height / 3);
                    e.Graphics.TranslateTransform(paintPictureBox.Width / 2, paintPictureBox.Height / 2);
                    e.Graphics.RotateTransform(angle);
                    e.Graphics.DrawEllipse(new Pen(Color.Red, 50), 15, 15, 30, 30);
                }
            }
        }

        private void lineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lineToolStripMenuItem.Checked = true;
            pixelToolStripMenuItem.Checked = false;
            lineChoice = true;
            pixelChoice = false;
        }

        private void pixelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lineToolStripMenuItem.Checked = false;
            pixelToolStripMenuItem.Checked = true;
            lineChoice = false;
            pixelChoice = true;
        }

        private void buttonOn_Click(object sender, EventArgs e)
        {
            tick = 0;
            paintPictureBox.BackColor = Color.White;
            timerLoading = new Timer() { Interval = 100 };
            timerLoading.Tick += timer_Tick;
            timerLoading.Start();
            loadingScreen = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (tick < 25) {
                tick++;
                angle += 0.5f;
                paintPictureBox.Invalidate();
            } else {
                timerLoading.Stop();
                switcher.buttonOn();
                loadingScreen = false;

                paintPictureBox.Invalidate();
            }
        }

        private void buttonOff_Click(object sender, EventArgs e)
        {
            paintPictureBox.BackColor = Color.Black;
            switcher.buttonOff();
            paintPictureBox.Invalidate();
        }

        private void buttonCurve_Click(object sender, EventArgs e)
        {
            if (!loadingScreen && screenWorking) {
                Random rnd = new Random();
                curveRandom = randomCurveFill(rnd.Next(3, 10));
                paintPictureBox.Invalidate();
            }
        }

        private void buttonBezier_Click(object sender, EventArgs e)
        {
            if (!loadingScreen && screenWorking) {
                curveBezier = randomCurveFill(4);
                paintPictureBox.Invalidate();
            }
        }

        private Point[] randomCurveFill(int length) {
            Random rnd = new Random();

            Point[] tmpCurve = new Point[length];
            for (int i = 0; i < tmpCurve.Length; ++i)
            {
                int x = rnd.Next(i * paintPictureBox.Width / length, (i + 1) * paintPictureBox.Width / length - 1);
                int y = rnd.Next(3, paintPictureBox.Height);
                tmpCurve[i] = new Point(x, y);
            }
            return tmpCurve;
        }

        private void DragDropButton_MouseDown(object sender, MouseEventArgs e)
        {
            DragDropButton.DoDragDrop(DragDropButton, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void panelDragNDrop_DragDrop(object sender, DragEventArgs e)
        {
            DragDropButton.Parent = (Panel)sender;
            DragDropButton.Location = new Point(
                 e.X - Location.X - panelBig.Location.X - ((Panel)sender).Location.X - 10 - DragDropButton.Size.Width / 2,
                 e.Y - Location.Y - panelBig.Location.Y - ((Panel)sender).Location.Y - 30 - DragDropButton.Size.Height / 2);
        }

        private void panelDragNDrop_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void clipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClipForm form = new ClipForm();
            form.Show();
        }
    }
}
