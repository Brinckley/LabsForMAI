namespace Lab_12
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.maleCheckBox = new System.Windows.Forms.CheckBox();
            this.femaleCheckBox = new System.Windows.Forms.CheckBox();
            this.dialogButton = new System.Windows.Forms.Button();
            this.dateStatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.messageButton = new System.Windows.Forms.Button();
            this.buttonPictureDialog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.dateStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightYellow;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(418, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(442, 345);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // maleCheckBox
            // 
            this.maleCheckBox.AutoSize = true;
            this.maleCheckBox.Location = new System.Drawing.Point(74, 133);
            this.maleCheckBox.Name = "maleCheckBox";
            this.maleCheckBox.Size = new System.Drawing.Size(60, 21);
            this.maleCheckBox.TabIndex = 1;
            this.maleCheckBox.Text = "Male";
            this.maleCheckBox.UseVisualStyleBackColor = true;
            this.maleCheckBox.CheckedChanged += new System.EventHandler(this.maleCheckBox_CheckedChanged);
            // 
            // femaleCheckBox
            // 
            this.femaleCheckBox.AutoSize = true;
            this.femaleCheckBox.Location = new System.Drawing.Point(214, 133);
            this.femaleCheckBox.Name = "femaleCheckBox";
            this.femaleCheckBox.Size = new System.Drawing.Size(76, 21);
            this.femaleCheckBox.TabIndex = 2;
            this.femaleCheckBox.Text = "Female";
            this.femaleCheckBox.UseVisualStyleBackColor = true;
            this.femaleCheckBox.CheckedChanged += new System.EventHandler(this.femaleCheckBox_CheckedChanged);
            // 
            // dialogButton
            // 
            this.dialogButton.Location = new System.Drawing.Point(74, 184);
            this.dialogButton.Name = "dialogButton";
            this.dialogButton.Size = new System.Drawing.Size(216, 35);
            this.dialogButton.TabIndex = 3;
            this.dialogButton.Text = "Confirme your choice";
            this.dialogButton.UseVisualStyleBackColor = true;
            this.dialogButton.Click += new System.EventHandler(this.dialogButton_Click);
            // 
            // dateStatusStrip
            // 
            this.dateStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.dateStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.dateStatusStrip.Location = new System.Drawing.Point(0, 399);
            this.dateStatusStrip.Name = "dateStatusStrip";
            this.dateStatusStrip.Size = new System.Drawing.Size(894, 25);
            this.dateStatusStrip.TabIndex = 4;
            this.dateStatusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(41, 20);
            this.toolStripStatusLabel1.Text = "Date";
            // 
            // messageButton
            // 
            this.messageButton.Location = new System.Drawing.Point(74, 247);
            this.messageButton.Name = "messageButton";
            this.messageButton.Size = new System.Drawing.Size(216, 35);
            this.messageButton.TabIndex = 5;
            this.messageButton.Text = "Show info";
            this.messageButton.UseVisualStyleBackColor = true;
            this.messageButton.Click += new System.EventHandler(this.messageButton_Click);
            // 
            // buttonPictureDialog
            // 
            this.buttonPictureDialog.Location = new System.Drawing.Point(554, 8);
            this.buttonPictureDialog.Name = "buttonPictureDialog";
            this.buttonPictureDialog.Size = new System.Drawing.Size(175, 26);
            this.buttonPictureDialog.TabIndex = 6;
            this.buttonPictureDialog.Text = "Select picture";
            this.buttonPictureDialog.UseVisualStyleBackColor = true;
            this.buttonPictureDialog.Click += new System.EventHandler(this.buttonPictureDialog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 424);
            this.Controls.Add(this.buttonPictureDialog);
            this.Controls.Add(this.messageButton);
            this.Controls.Add(this.dateStatusStrip);
            this.Controls.Add(this.dialogButton);
            this.Controls.Add(this.femaleCheckBox);
            this.Controls.Add(this.maleCheckBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.dateStatusStrip.ResumeLayout(false);
            this.dateStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox maleCheckBox;
        private System.Windows.Forms.CheckBox femaleCheckBox;
        private System.Windows.Forms.Button dialogButton;
        private System.Windows.Forms.StatusStrip dateStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button messageButton;
        private System.Windows.Forms.Button buttonPictureDialog;
    }
}

