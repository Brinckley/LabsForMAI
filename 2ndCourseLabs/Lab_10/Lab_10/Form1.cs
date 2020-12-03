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
                controller = new Controller(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
                if (radioSum.Checked) { label3.Text = controller.operationSum().ToString(); }
                if (radioDif.Checked) { label3.Text = controller.operationDif().ToString(); }
                if (radioMul.Checked) { label3.Text = controller.operationMul().ToString(); }
                if (radioDiv.Checked) { label3.Text = controller.operationDiv().ToString(); }
                if (label3.Text == "") { MessageBox.Show("No operation!!"); }
            }
            catch (FormatException) {
                MessageBox.Show("ERROR!");
            }
        }
    }

    public class Controller //Controller
    {
        public double x { get; private set; }
        public double y { get; private set; }

        public Controller() {
            x = 0;
            y = 0;
        }

        public Controller(double x, double y) {
            this.x = x;
            this.y = y;
        }

        public double operationSum() {
            return Model.sum(x, y);
        }

        public double operationDif()
        {
            return Model.dif(x, y);
        }

        public double operationMul()
        {
            return Model.mul(x, y);
        }

        public double operationDiv()
        {
            return Model.div(x, y);
        }
    }

    public class Model //Model
    {
        public static double sum(double x, double y) {
            return x + y;
        }

        public static double dif(double x, double y)
        {
            return x - y;
        }

        public static double mul(double x, double y)
        {
            return x * y;
        }

        public static double div(double x, double y)
        {
            if (y == 0)
            {
                throw new Exception("Error division by zero!!!");
            }
            else {
                return x / y;
            }
        }
    }
}
