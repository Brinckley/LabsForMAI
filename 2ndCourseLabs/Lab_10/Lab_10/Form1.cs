using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_10
{ //Mvc
    public partial class Form1 : Form //View
    {
        Controller controller;
        public Form1()
        {
            InitializeComponent();
            label3.Text = "";
            controller = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                controller = new Controller(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                label3.Text = controller.operation().ToString();
            }
            catch (FormatException) {
                MessageBox.Show("ERROR!");
            }
        }
    }

    public class Controller //Controller
    {
        public int x { get; private set; }
        public int y { get; private set; }

        public Controller() {
            x = 0;
            y = 0;
        }

        public Controller(int x, int y) {
            this.x = x;
            this.y = y;
        }

        public int operation() {
            return Model.sum(x, y);
        }
    }

    public class Model //Model
    {
        public static int sum(int x, int y) {
            return x + y;
        }
    }
}
