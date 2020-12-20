namespace Lab_13
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textSizeTrackBar = new System.Windows.Forms.TrackBar();
            this.ScrollLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.textSizeTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // textSizeTrackBar
            // 
            this.textSizeTrackBar.Location = new System.Drawing.Point(12, 38);
            this.textSizeTrackBar.Maximum = 35;
            this.textSizeTrackBar.Minimum = 8;
            this.textSizeTrackBar.Name = "textSizeTrackBar";
            this.textSizeTrackBar.Size = new System.Drawing.Size(264, 56);
            this.textSizeTrackBar.TabIndex = 0;
            this.textSizeTrackBar.Value = 8;
            this.textSizeTrackBar.Scroll += new System.EventHandler(this.textSizeTrackBar_Scroll);
            // 
            // ScrollLabel
            // 
            this.ScrollLabel.AutoSize = true;
            this.ScrollLabel.Location = new System.Drawing.Point(121, 97);
            this.ScrollLabel.Name = "ScrollLabel";
            this.ScrollLabel.Size = new System.Drawing.Size(46, 17);
            this.ScrollLabel.TabIndex = 1;
            this.ScrollLabel.Text = "label1";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(105, 129);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(79, 32);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "Ok";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 173);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ScrollLabel);
            this.Controls.Add(this.textSizeTrackBar);
            this.Name = "Form2";
            this.Text = "Choose size";
            ((System.ComponentModel.ISupportInitialize)(this.textSizeTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar textSizeTrackBar;
        private System.Windows.Forms.Label ScrollLabel;
        private System.Windows.Forms.Button CloseButton;
    }
}