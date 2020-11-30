using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Singleton.getInstance((int)numericUpDown1.Value);
            MessageBox.Show("Hashcode: " + Singleton.getInstance(0).GetHashCode()
                + "\nValue: " + Singleton.value);
        }
    }

    class Singleton {
        private static Singleton instance;
        public static int value { get; private set; }

        private Singleton() { value = -1; }

        public static Singleton getInstance(int _value) {
            if (instance == null) {
                instance = new Singleton();
                value = _value;
            }
            return instance;
        }
    }
}
