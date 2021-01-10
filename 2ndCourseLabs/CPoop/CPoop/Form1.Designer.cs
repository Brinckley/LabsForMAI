namespace CPoop
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.SaveStripButton = new System.Windows.Forms.ToolStripButton();
            this.ImportStripButton = new System.Windows.Forms.ToolStripButton();
            this.ClearToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.UpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.DownToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BoldToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ItalicToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.UnderlineToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.FontToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.PasteButton = new System.Windows.Forms.Button();
            this.dateStatusStrip = new System.Windows.Forms.StatusStrip();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.findToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.FIndButtonToolStrip = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Lato", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 64);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(623, 265);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveStripButton,
            this.ImportStripButton,
            this.ClearToolStripButton,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.UpToolStripButton,
            this.DownToolStripButton,
            this.toolStripSeparator2,
            this.BoldToolStripButton,
            this.ItalicToolStripButton,
            this.UnderlineToolStripButton,
            this.toolStripSeparator3,
            this.FontToolStripButton,
            this.toolStripSeparator4,
            this.toolStripLabel2,
            this.findToolStripTextBox,
            this.FIndButtonToolStrip});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(647, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "Increase size";
            // 
            // SaveStripButton
            // 
            this.SaveStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveStripButton.Name = "SaveStripButton";
            this.SaveStripButton.Size = new System.Drawing.Size(23, 24);
            this.SaveStripButton.Text = "Save";
            this.SaveStripButton.Click += new System.EventHandler(this.SaveStripButton_Click);
            // 
            // ImportStripButton
            // 
            this.ImportStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ImportStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ImportStripButton.Name = "ImportStripButton";
            this.ImportStripButton.Size = new System.Drawing.Size(23, 24);
            this.ImportStripButton.Text = "Import";
            this.ImportStripButton.Click += new System.EventHandler(this.ImportStripButton_Click);
            // 
            // ClearToolStripButton
            // 
            this.ClearToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ClearToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClearToolStripButton.Name = "ClearToolStripButton";
            this.ClearToolStripButton.Size = new System.Drawing.Size(23, 24);
            this.ClearToolStripButton.Text = "ClearStripButton";
            this.ClearToolStripButton.Click += new System.EventHandler(this.ClearToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(67, 24);
            this.toolStripLabel1.Text = "Text Size";
            // 
            // UpToolStripButton
            // 
            this.UpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UpToolStripButton.Name = "UpToolStripButton";
            this.UpToolStripButton.Size = new System.Drawing.Size(23, 24);
            this.UpToolStripButton.Text = "Increase size";
            this.UpToolStripButton.Click += new System.EventHandler(this.UpToolStripButton_Click);
            // 
            // DownToolStripButton
            // 
            this.DownToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DownToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DownToolStripButton.Name = "DownToolStripButton";
            this.DownToolStripButton.Size = new System.Drawing.Size(23, 24);
            this.DownToolStripButton.Text = "Decrease size";
            this.DownToolStripButton.Click += new System.EventHandler(this.DownToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // BoldToolStripButton
            // 
            this.BoldToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BoldToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BoldToolStripButton.Name = "BoldToolStripButton";
            this.BoldToolStripButton.Size = new System.Drawing.Size(23, 24);
            this.BoldToolStripButton.Text = "Bold";
            this.BoldToolStripButton.Click += new System.EventHandler(this.BoldToolStripButton_Click);
            // 
            // ItalicToolStripButton
            // 
            this.ItalicToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ItalicToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ItalicToolStripButton.Name = "ItalicToolStripButton";
            this.ItalicToolStripButton.Size = new System.Drawing.Size(23, 24);
            this.ItalicToolStripButton.Text = "Italic";
            this.ItalicToolStripButton.Click += new System.EventHandler(this.ItalicToolStripButton_Click);
            // 
            // UnderlineToolStripButton
            // 
            this.UnderlineToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UnderlineToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UnderlineToolStripButton.Name = "UnderlineToolStripButton";
            this.UnderlineToolStripButton.Size = new System.Drawing.Size(23, 24);
            this.UnderlineToolStripButton.Text = "Underline";
            this.UnderlineToolStripButton.Click += new System.EventHandler(this.UnderlineToolStripButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // FontToolStripButton
            // 
            this.FontToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FontToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FontToolStripButton.Name = "FontToolStripButton";
            this.FontToolStripButton.Size = new System.Drawing.Size(123, 24);
            this.FontToolStripButton.Text = "toolStripButton1";
            this.FontToolStripButton.Click += new System.EventHandler(this.FontToolStripButton_Click);
            // 
            // PasteButton
            // 
            this.PasteButton.Location = new System.Drawing.Point(558, 332);
            this.PasteButton.Name = "PasteButton";
            this.PasteButton.Size = new System.Drawing.Size(77, 39);
            this.PasteButton.TabIndex = 2;
            this.PasteButton.Text = "Paste";
            this.PasteButton.UseVisualStyleBackColor = true;
            this.PasteButton.Click += new System.EventHandler(this.PasteButton_Click);
            // 
            // dateStatusStrip
            // 
            this.dateStatusStrip.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dateStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.dateStatusStrip.Location = new System.Drawing.Point(0, 377);
            this.dateStatusStrip.Name = "dateStatusStrip";
            this.dateStatusStrip.Size = new System.Drawing.Size(647, 22);
            this.dateStatusStrip.TabIndex = 4;
            this.dateStatusStrip.Text = "statusStrip1";
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(475, 332);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(77, 39);
            this.buttonCopy.TabIndex = 5;
            this.buttonCopy.Text = "Copy";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(37, 24);
            this.toolStripLabel2.Text = "Find";
            // 
            // findToolStripTextBox
            // 
            this.findToolStripTextBox.Name = "findToolStripTextBox";
            this.findToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            this.findToolStripTextBox.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // FIndButtonToolStrip
            // 
            this.FIndButtonToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FIndButtonToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("FIndButtonToolStrip.Image")));
            this.FIndButtonToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FIndButtonToolStrip.Name = "FIndButtonToolStrip";
            this.FIndButtonToolStrip.Size = new System.Drawing.Size(24, 24);
            this.FIndButtonToolStrip.Text = "toolStripButton1";
            this.FIndButtonToolStrip.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(647, 399);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.dateStatusStrip);
            this.Controls.Add(this.PasteButton);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Course project";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton SaveStripButton;
        private System.Windows.Forms.ToolStripButton ImportStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton UpToolStripButton;
        private System.Windows.Forms.ToolStripButton DownToolStripButton;
        private System.Windows.Forms.Button PasteButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton ClearToolStripButton;
        private System.Windows.Forms.ToolStripButton BoldToolStripButton;
        private System.Windows.Forms.ToolStripButton ItalicToolStripButton;
        private System.Windows.Forms.ToolStripButton UnderlineToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton FontToolStripButton;
        private System.Windows.Forms.StatusStrip dateStatusStrip;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox findToolStripTextBox;
        private System.Windows.Forms.ToolStripButton FIndButtonToolStrip;
    }
}

