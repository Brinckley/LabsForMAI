namespace Lab_14
{
    partial class Lab_14
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
            this.paintPictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brushToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pixelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorButton = new System.Windows.Forms.Button();
            this.DragDropButton = new System.Windows.Forms.Button();
            this.buttonOn = new System.Windows.Forms.Button();
            this.buttonOff = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonCurve = new System.Windows.Forms.Button();
            this.buttonBezier = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panelDragNDrop = new System.Windows.Forms.Panel();
            this.panelBig = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.paintPictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panelDragNDrop.SuspendLayout();
            this.panelBig.SuspendLayout();
            this.SuspendLayout();
            // 
            // paintPictureBox
            // 
            this.paintPictureBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.paintPictureBox.Location = new System.Drawing.Point(262, 40);
            this.paintPictureBox.Name = "paintPictureBox";
            this.paintPictureBox.Size = new System.Drawing.Size(309, 299);
            this.paintPictureBox.TabIndex = 0;
            this.paintPictureBox.TabStop = false;
            this.paintPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.paintPictureBox_Paint);
            this.paintPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paintPictureBox_MouseDown);
            this.paintPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.paintPictureBox_MouseMove);
            this.paintPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.paintPictureBox_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.brushToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(600, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsToolStripMenuItem,
            this.importToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.undoToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.saveAsToolStripMenuItem.Text = "Save as";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // brushToolStripMenuItem
            // 
            this.brushToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lineToolStripMenuItem,
            this.pixelToolStripMenuItem});
            this.brushToolStripMenuItem.Name = "brushToolStripMenuItem";
            this.brushToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.brushToolStripMenuItem.Text = "Brush";
            // 
            // lineToolStripMenuItem
            // 
            this.lineToolStripMenuItem.Name = "lineToolStripMenuItem";
            this.lineToolStripMenuItem.Size = new System.Drawing.Size(115, 26);
            this.lineToolStripMenuItem.Text = "Line";
            this.lineToolStripMenuItem.Click += new System.EventHandler(this.lineToolStripMenuItem_Click);
            // 
            // pixelToolStripMenuItem
            // 
            this.pixelToolStripMenuItem.Checked = true;
            this.pixelToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pixelToolStripMenuItem.Name = "pixelToolStripMenuItem";
            this.pixelToolStripMenuItem.Size = new System.Drawing.Size(115, 26);
            this.pixelToolStripMenuItem.Text = "Pixel";
            this.pixelToolStripMenuItem.Click += new System.EventHandler(this.pixelToolStripMenuItem_Click);
            // 
            // colorButton
            // 
            this.colorButton.Location = new System.Drawing.Point(35, 69);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(168, 41);
            this.colorButton.TabIndex = 2;
            this.colorButton.Text = "Change color";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // DragDropButton
            // 
            this.DragDropButton.Location = new System.Drawing.Point(45, 32);
            this.DragDropButton.Name = "DragDropButton";
            this.DragDropButton.Size = new System.Drawing.Size(103, 35);
            this.DragDropButton.TabIndex = 3;
            this.DragDropButton.Text = "Drag\'n\'drop";
            this.DragDropButton.UseVisualStyleBackColor = true;
            this.DragDropButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragDropButton_MouseDown);
            // 
            // buttonOn
            // 
            this.buttonOn.Location = new System.Drawing.Point(262, 345);
            this.buttonOn.Name = "buttonOn";
            this.buttonOn.Size = new System.Drawing.Size(45, 36);
            this.buttonOn.TabIndex = 4;
            this.buttonOn.Text = "On";
            this.buttonOn.UseVisualStyleBackColor = true;
            this.buttonOn.Click += new System.EventHandler(this.buttonOn_Click);
            // 
            // buttonOff
            // 
            this.buttonOff.Location = new System.Drawing.Point(526, 345);
            this.buttonOff.Name = "buttonOff";
            this.buttonOff.Size = new System.Drawing.Size(45, 36);
            this.buttonOff.TabIndex = 5;
            this.buttonOff.Text = "Off";
            this.buttonOff.UseVisualStyleBackColor = true;
            this.buttonOff.Click += new System.EventHandler(this.buttonOff_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(431, 345);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(53, 36);
            this.buttonNext.TabIndex = 6;
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(366, 345);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(53, 36);
            this.buttonPrev.TabIndex = 7;
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonCurve
            // 
            this.buttonCurve.Location = new System.Drawing.Point(35, 139);
            this.buttonCurve.Name = "buttonCurve";
            this.buttonCurve.Size = new System.Drawing.Size(168, 41);
            this.buttonCurve.TabIndex = 8;
            this.buttonCurve.Text = "Random curve";
            this.buttonCurve.UseVisualStyleBackColor = true;
            this.buttonCurve.Click += new System.EventHandler(this.buttonCurve_Click);
            // 
            // buttonBezier
            // 
            this.buttonBezier.Location = new System.Drawing.Point(35, 207);
            this.buttonBezier.Name = "buttonBezier";
            this.buttonBezier.Size = new System.Drawing.Size(168, 41);
            this.buttonBezier.TabIndex = 9;
            this.buttonBezier.Text = "Bezier curve";
            this.buttonBezier.UseVisualStyleBackColor = true;
            this.buttonBezier.Click += new System.EventHandler(this.buttonBezier_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(210, 217);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(36, 24);
            this.comboBox1.TabIndex = 10;
            // 
            // panelDragNDrop
            // 
            this.panelDragNDrop.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelDragNDrop.Controls.Add(this.DragDropButton);
            this.panelDragNDrop.Location = new System.Drawing.Point(13, 27);
            this.panelDragNDrop.Name = "panelDragNDrop";
            this.panelDragNDrop.Size = new System.Drawing.Size(200, 100);
            this.panelDragNDrop.TabIndex = 11;
            this.panelDragNDrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelDragNDrop_DragDrop);
            this.panelDragNDrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelDragNDrop_DragEnter);
            // 
            // panelBig
            // 
            this.panelBig.Controls.Add(this.panelDragNDrop);
            this.panelBig.Location = new System.Drawing.Point(12, 254);
            this.panelBig.Name = "panelBig";
            this.panelBig.Size = new System.Drawing.Size(226, 135);
            this.panelBig.TabIndex = 12;
            // 
            // Lab_14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 393);
            this.Controls.Add(this.panelBig);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonBezier);
            this.Controls.Add(this.buttonCurve);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonOff);
            this.Controls.Add(this.buttonOn);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.paintPictureBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Lab_14";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.paintPictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelDragNDrop.ResumeLayout(false);
            this.panelBig.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox paintPictureBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.Button DragDropButton;
        private System.Windows.Forms.ToolStripMenuItem brushToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pixelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.Button buttonOn;
        private System.Windows.Forms.Button buttonOff;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonCurve;
        private System.Windows.Forms.Button buttonBezier;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panelDragNDrop;
        private System.Windows.Forms.Panel panelBig;
    }
}

