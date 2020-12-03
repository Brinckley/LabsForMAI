namespace Lab_10
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioSum = new System.Windows.Forms.RadioButton();
            this.radioDif = new System.Windows.Forms.RadioButton();
            this.radioMul = new System.Windows.Forms.RadioButton();
            this.radioDiv = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(64, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(130, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(59, 22);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // radioSum
            // 
            this.radioSum.AutoSize = true;
            this.radioSum.Location = new System.Drawing.Point(85, 38);
            this.radioSum.Name = "radioSum";
            this.radioSum.Size = new System.Drawing.Size(37, 21);
            this.radioSum.TabIndex = 6;
            this.radioSum.TabStop = true;
            this.radioSum.Text = "+";
            this.radioSum.UseVisualStyleBackColor = true;
            // 
            // radioDif
            // 
            this.radioDif.AutoSize = true;
            this.radioDif.Location = new System.Drawing.Point(85, 59);
            this.radioDif.Name = "radioDif";
            this.radioDif.Size = new System.Drawing.Size(34, 21);
            this.radioDif.TabIndex = 7;
            this.radioDif.TabStop = true;
            this.radioDif.Text = "-";
            this.radioDif.UseVisualStyleBackColor = true;
            // 
            // radioMul
            // 
            this.radioMul.AutoSize = true;
            this.radioMul.Location = new System.Drawing.Point(85, 82);
            this.radioMul.Name = "radioMul";
            this.radioMul.Size = new System.Drawing.Size(34, 21);
            this.radioMul.TabIndex = 8;
            this.radioMul.TabStop = true;
            this.radioMul.Text = "*";
            this.radioMul.UseVisualStyleBackColor = true;
            // 
            // radioDiv
            // 
            this.radioDiv.AutoSize = true;
            this.radioDiv.Location = new System.Drawing.Point(85, 104);
            this.radioDiv.Name = "radioDiv";
            this.radioDiv.Size = new System.Drawing.Size(33, 21);
            this.radioDiv.TabIndex = 9;
            this.radioDiv.TabStop = true;
            this.radioDiv.Text = "/";
            this.radioDiv.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 308);
            this.Controls.Add(this.radioDiv);
            this.Controls.Add(this.radioMul);
            this.Controls.Add(this.radioDif);
            this.Controls.Add(this.radioSum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioSum;
        private System.Windows.Forms.RadioButton radioDif;
        private System.Windows.Forms.RadioButton radioMul;
        private System.Windows.Forms.RadioButton radioDiv;
    }
}

