using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordShower
{
    public partial class Form1 : Form
    {
        string input;

        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
            input = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 1 && textBox1.Text != "*")
            {
                input += textBox1.Text;
                label1.Text = input;
                textBox1.Text = "*";
            }
            else if (textBox1.Text.Length == 2) {
                input += textBox1.Text[0];
                label1.Text = input;
                textBox1.Text = "*";
            }
        }
    }
}
