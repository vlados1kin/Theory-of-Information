namespace lab2
{
    partial class Form1
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
            this.EndTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.keyLabel = new System.Windows.Forms.Label();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.writeButton = new System.Windows.Forms.Button();
            this.readButton = new System.Windows.Forms.Button();
            this.cipherButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StartTextBox = new System.Windows.Forms.TextBox();
            this.GenTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EndTextBox
            // 
            this.EndTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.EndTextBox.Location = new System.Drawing.Point(1284, 227);
            this.EndTextBox.Multiline = true;
            this.EndTextBox.Name = "EndTextBox";
            this.EndTextBox.ReadOnly = true;
            this.EndTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.EndTextBox.Size = new System.Drawing.Size(600, 777);
            this.EndTextBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Location = new System.Drawing.Point(803, 0);
            this.groupBox1.MaximumSize = new System.Drawing.Size(290, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 0);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // keyLabel
            // 
            this.keyLabel.Location = new System.Drawing.Point(13, 30);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(238, 23);
            this.keyLabel.TabIndex = 3;
            this.keyLabel.Text = "ключ(0 симв.)";
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(13, 56);
            this.keyTextBox.Multiline = true;
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(649, 94);
            this.keyTextBox.TabIndex = 2;
            this.keyTextBox.TextChanged += new System.EventHandler(this.keyTextBox_TextChanged);
            // 
            // writeButton
            // 
            this.writeButton.Location = new System.Drawing.Point(1473, 91);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(307, 74);
            this.writeButton.TabIndex = 6;
            this.writeButton.Text = "записать в файл";
            this.writeButton.UseVisualStyleBackColor = true;
            this.writeButton.Click += new System.EventHandler(this.writeButton_Click);
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(1473, 5);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(307, 74);
            this.readButton.TabIndex = 7;
            this.readButton.Text = "открыть файл";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // cipherButton
            // 
            this.cipherButton.Location = new System.Drawing.Point(1097, 5);
            this.cipherButton.Name = "cipherButton";
            this.cipherButton.Size = new System.Drawing.Size(307, 74);
            this.cipherButton.TabIndex = 8;
            this.cipherButton.Text = "зашифровать";
            this.cipherButton.UseVisualStyleBackColor = true;
            this.cipherButton.Click += new System.EventHandler(this.cipherButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.FileName = "cipherText.txt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Исходный файл";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(639, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Сгенерированный ключ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1279, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Зашифрованый файл";
            // 
            // StartTextBox
            // 
            this.StartTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.StartTextBox.Location = new System.Drawing.Point(13, 227);
            this.StartTextBox.Multiline = true;
            this.StartTextBox.Name = "StartTextBox";
            this.StartTextBox.ReadOnly = true;
            this.StartTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.StartTextBox.Size = new System.Drawing.Size(600, 777);
            this.StartTextBox.TabIndex = 13;
            // 
            // GenTextBox
            // 
            this.GenTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.GenTextBox.Location = new System.Drawing.Point(648, 227);
            this.GenTextBox.Multiline = true;
            this.GenTextBox.Name = "GenTextBox";
            this.GenTextBox.ReadOnly = true;
            this.GenTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GenTextBox.Size = new System.Drawing.Size(600, 777);
            this.GenTextBox.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1896, 1016);
            this.Controls.Add(this.GenTextBox);
            this.Controls.Add(this.StartTextBox);
            this.Controls.Add(this.keyLabel);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cipherButton);
            this.Controls.Add(this.readButton);
            this.Controls.Add(this.writeButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.EndTextBox);
            this.Location = new System.Drawing.Point(15, 15);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox StartTextBox;
        private System.Windows.Forms.TextBox GenTextBox;

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;

        private System.Windows.Forms.OpenFileDialog openFileDialog1;

        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.Button writeButton;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.Button cipherButton;

        private System.Windows.Forms.TextBox keyTextBox;

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.TextBox EndTextBox;

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}