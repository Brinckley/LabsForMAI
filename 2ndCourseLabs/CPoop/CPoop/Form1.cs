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
using CPoop.Classes;

namespace CPoop
{
    public partial class Form1 : Form
    {
        SaveFileDialog saveFileDialog;
        OpenFileDialog openFileDialog;
        
        public static Timer timerStatus = new Timer();
        StatusLabelInfo statusInfo;
        int currentRunner;

        FontSingleton fontSingleton = FontSingleton.getInstance();
        FontRTB font;

        TextChangeHandler boldChangeHandler;
        TextChangeHandler italicsChangeHandler;
        TextChangeHandler underlineChangeHandler;
        
        public Form1()
        {
            InitializeComponent();
            chainInit();
            initPicture();
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            richTextBox1.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBox1.Font = fontSingleton.font;
            FontToolStripButton.Text = "Font";
            currentRunner = 0;
            statusInfo = new StatusLabelInfo(new statusFactory());

            timerStatus = new Timer() { Interval = 1000 };
            timerStatus.Tick += timerStatus_Tick;
            timerStatus.Start();
            dateStatusStrip.Items.Add(statusInfo.getDate());
            dateStatusStrip.Items.Add(statusInfo.getTime());
        }

        private void timerStatus_Tick(object sender, EventArgs e)
        {
            statusInfo.updateDate();
        }

        private void chainInit()
        {
            font = new FontRTB(true, false, false, fontSingleton.font);
            boldChangeHandler = new BoldChangeHandler();
            italicsChangeHandler = new ItalicsChangeHandler();
            underlineChangeHandler = new UnderlineChangeHandler();
            boldChangeHandler.Successor = italicsChangeHandler;
            italicsChangeHandler.Successor = underlineChangeHandler;
        }

        private void SaveStripButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog.FileName;
                File.WriteAllText(filename, richTextBox1.Text);
            }
        }

        private void ImportStripButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog.FileName;
                try
                {
                    richTextBox1.Text = File.ReadAllText(filename);
                }
                catch (FormatException) { }
            }
        }

        private void ClearToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void UpToolStripButton_Click(object sender, EventArgs e)
        {
            float size = richTextBox1.Font.Size;
            if (size < 35)
            {
                size++;
                font.tFont = new Font(font.tFont.FontFamily, size, font.tFont.Style);
                fontSingleton.font = new Font(font.tFont.FontFamily, size, font.tFont.Style);
                updateRichTextBox();
            }
        }

        private void DownToolStripButton_Click(object sender, EventArgs e)
        {
            float size = richTextBox1.Font.Size;
            if (size > 7)
            {
                size--;
                font.tFont = new Font(font.tFont.FontFamily, size, richTextBox1.Font.Style);
                fontSingleton.font = new Font(font.tFont.FontFamily, size, font.tFont.Style);
                updateRichTextBox();
            }
        }

        private void BoldToolStripButton_Click(object sender, EventArgs e)
        {
            handleWorker(true, false, false);
            updateRichTextBox();
        }

        private void ItalicToolStripButton_Click(object sender, EventArgs e)
        {
            handleWorker(false, true, false);
            updateRichTextBox();
        }

        private void UnderlineToolStripButton_Click(object sender, EventArgs e)
        {
            handleWorker(false, false, true);
            updateRichTextBox();
        }

        private void FontToolStripButton_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowDialog();
            font.tFont = new Font(fontDialog.Font.FontFamily, fontDialog.Font.Size, fontDialog.Font.Style);
            updateRichTextBox();
        }

        private void PasteButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Clipboard.GetText();
        }

        public void handleWorker(bool bc, bool ic, bool uc)
        {
            font = new FontRTB(bc, ic, uc, fontSingleton.font);
            boldChangeHandler.Handle(font);
        }

        public void updateRichTextBox()
        {
            int currentState = richTextBox1.TextLength;
            string text = richTextBox1.Text;
            richTextBox1.Font = font.tFont;
            richTextBox1.Clear();
            richTextBox1.Text += text;
            richTextBox1.SelectionStart = currentState;
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.Text);
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            currentRunner = 0;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (currentRunner != -1) {
                if (currentRunner == 0) {
                    currentRunner = richTextBox1.Find(findToolStripTextBox.Text, 0, RichTextBoxFinds.None);
                    if (currentRunner == -1) {
                        MessageBox.Show("No match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    currentRunner++;
                    return;
                }
                int t = currentRunner;
                currentRunner = richTextBox1.Find(findToolStripTextBox.Text, t, RichTextBoxFinds.None);
                currentRunner++;
            }
        }

        private void initPicture() {
            SaveStripButton.Image = Properties.Resources.SaveAs_16x_24;
            ImportStripButton.Image = Properties.Resources.Import_grey_16x_24;
            UpToolStripButton.Image = Properties.Resources.IncreaseFontSize_16x;
            DownToolStripButton.Image = Properties.Resources.DecreaseFontSize_16x;
            ClearToolStripButton.Image = Properties.Resources.ClearWindowContent_16x;
            BoldToolStripButton.Image = Properties.Resources.Bold_16xMD;
            ItalicToolStripButton.Image = Properties.Resources.Italic_16xMD;
            UnderlineToolStripButton.Image = Properties.Resources.Underline_16xMD;
            FIndButtonToolStrip.Image = Properties.Resources.FindNext_16x;
        }
    }
}
