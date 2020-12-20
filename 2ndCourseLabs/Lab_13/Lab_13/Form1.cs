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

namespace Lab_13
{
    public partial class Form1 : Form
    {
        SaveFileDialog saveFileDialog;
        OpenFileDialog openFileDialog;

        Form2 trackForm;

        FontRTB font;
        TextChangeHandler boldChangeHandler;
        TextChangeHandler italicsChangeHandler;
        TextChangeHandler underlineChangeHandler;

        public Form1()
        {
            InitializeComponent();
            SaveStripButton.Image = Properties.Resources.SaveAs_16x_24;
            ImportStripButton.Image = Properties.Resources.Import_grey_16x_24;
            UpToolStripButton.Image = Properties.Resources.IncreaseFontSize_16x;
            DownToolStripButton.Image = Properties.Resources.DecreaseFontSize_16x;
            ClearToolStripButton.Image = Properties.Resources.ClearWindowContent_16x;
            BoldToolStripButton.Image = Properties.Resources.Bold_16xMD;
            ItalicToolStripButton.Image = Properties.Resources.Italic_16xMD;
            UnderlineToolStripButton.Image = Properties.Resources.Underline_16xMD;
            chainInit();
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            font.tFont = new Font("Lato", 9, FontStyle.Regular);
            richTextBox1.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBox1.Font = font.tFont;
        }

        private void chainInit()
        {
            font = new FontRTB(true, false, false);
            boldChangeHandler = new BoldChangeHandler();
            italicsChangeHandler = new ItalicsChangeHandler();
            underlineChangeHandler = new UnderlineChangeHandler();
            boldChangeHandler.Successor = italicsChangeHandler;
            italicsChangeHandler.Successor = underlineChangeHandler;
        }

        private void SaveStripButton_Click(object sender, EventArgs e)
        {
            if(saveFileDialog.ShowDialog() == DialogResult.OK){
                string filename = saveFileDialog.FileName;
                File.WriteAllText(filename, richTextBox1.Text);
            }
        }

        private void ImportStripButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog.FileName;
                try {
                    richTextBox1.Text = File.ReadAllText(filename);
                } catch (FormatException) { }
            }
        }

        private void UpToolStripButton_Click(object sender, EventArgs e)
        {
            float size = richTextBox1.Font.Size;
            if (size < 35) {
                size++;
                font.tFont = new Font(font.tFont.FontFamily, size, font.tFont.Style);
                updateRichTextBox();
            }
        }

        private void DownToolStripButton_Click(object sender, EventArgs e)
        {
            float size = richTextBox1.Font.Size;
            if (size > 7) {
                size--;
                font.tFont = new Font(font.tFont.FontFamily, size, font.tFont.Style);
                updateRichTextBox();
            }
        }

        private void PasteButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Clipboard.GetText();
        }

        private void ClearToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void BoldToolStripButton_Click(object sender, EventArgs e)
        {
            handleWorker(true, false, false);
            updateRichTextBox();
        }

        private void ItalicToolStripButton_Click(object sender, EventArgs e)
        {
            handleWorker(false,  true, false);
            updateRichTextBox();
        }

        private void UnderlineToolStripButton_Click(object sender, EventArgs e)
        {
            handleWorker(false, false, true);
            updateRichTextBox();
        }

        public void handleWorker(bool bc, bool ic, bool uc) {
            font = new FontRTB(bc, ic, uc);
            boldChangeHandler.Handle(font);
        }

        public void updateRichTextBox() {
            int currentState = richTextBox1.TextLength;
            string text = richTextBox1.Text;
            richTextBox1.Font = font.tFont;
            richTextBox1.Clear();
            richTextBox1.Text += text;
            richTextBox1.SelectionStart = currentState;
        }

        private void trackOpenButton_Click(object sender, EventArgs e)
        {
            trackForm = new Form2();
            trackForm.ShowDialog();
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, Form2.size, richTextBox1.Font.Style);
        }
    }
}
