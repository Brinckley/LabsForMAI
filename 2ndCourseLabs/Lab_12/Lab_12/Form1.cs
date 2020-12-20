using Lab_12.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_12
{
    public partial class Form1 : Form
    {
        StatusLabelInfo statusInfo;
        Timer timer;
        bool check;

        public Form1()
        {
            InitializeComponent();
            statusInfo = new StatusLabelInfo(new statusFactory());
            
            timer = new Timer() { Interval = 1000 };
            timer.Tick += timer_Tick;
            timer.Start();
            dateStatusStrip.Items.Add(statusInfo.getDate());
            dateStatusStrip.Items.Add(statusInfo.getTime());
        }

        private void dialogButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK && check == true)
            {
                maleCheckBox.Enabled = false;
                femaleCheckBox.Enabled = false;
            }
            else if (check == false) {
                MessageBox.Show("Nothing was selected");
            }
            else if(result == DialogResult.None){
                MessageBox.Show("Error!");
            }
        }

        void timer_Tick(object sender, EventArgs e)
        {
            statusInfo.updateDate();
        }

        private void messageButton_Click(object sender, EventArgs e)
        {
            if (!maleCheckBox.Enabled) {
                string res = "";
                if (maleCheckBox.Checked) {
                    res = "Male";
                }
                else { res = "female"; }
                MessageBox.Show(res, "Information");
                return;
            }
            MessageBox.Show("No information yet!");
        }

        private void maleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (maleCheckBox.Checked == true) {
                femaleCheckBox.Checked = false;
                checkUpdate();
            } 
        }

        private void femaleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (femaleCheckBox.Checked == true)
            {
                maleCheckBox.Checked = false;
                checkUpdate();
            }
        }

        private void checkUpdate() {
            if (maleCheckBox.Checked || femaleCheckBox.Checked)
            {
                check = true;
                return;
            }
            check = false;
        }

        private void buttonPictureDialog_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                try {
                    Bitmap image = new Bitmap(openFileDialog.FileName);
                    this.pictureBox1.Size = image.Size;
                    pictureBox1.Image = image;
                    pictureBox1.Invalidate();
                }
                catch {
                    DialogResult rezult = MessageBox.Show("Can't open this file(", "Error");
                }
            }
        }
    }
}
