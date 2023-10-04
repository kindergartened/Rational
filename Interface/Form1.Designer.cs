namespace Interface
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            labelNum1 = new Label();
            labelNum2 = new Label();
            labelResult = new Label();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(41, 57);
            richTextBox1.Margin = new Padding(3, 2, 3, 2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(366, 167);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // richTextBox2
            // 
            richTextBox2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox2.Location = new Point(497, 56);
            richTextBox2.Margin = new Padding(3, 2, 3, 2);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(388, 168);
            richTextBox2.TabIndex = 1;
            richTextBox2.Text = "";
            richTextBox2.TextChanged += richTextBox2_TextChanged;
            // 
            // richTextBox3
            // 
            richTextBox3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox3.Location = new Point(41, 278);
            richTextBox3.Margin = new Padding(3, 2, 3, 2);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(844, 129);
            richTextBox3.TabIndex = 2;
            richTextBox3.Text = "";
            richTextBox3.TextChanged += richTextBox3_TextChanged;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(94, 438);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(99, 91);
            button1.TabIndex = 3;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(717, 438);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(102, 91);
            button2.TabIndex = 4;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(251, 438);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(102, 91);
            button3.TabIndex = 5;
            button3.Text = "*";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(560, 438);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(99, 91);
            button4.TabIndex = 6;
            button4.Text = "/";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(177, 30);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 7;
            label1.Text = "Число 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(642, 29);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 8;
            label2.Text = "Число 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(404, 251);
            label3.Name = "label3";
            label3.Size = new Size(100, 25);
            label3.TabIndex = 9;
            label3.Text = "Результат";
            // 
            // labelNum1
            // 
            labelNum1.AutoSize = true;
            labelNum1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelNum1.ForeColor = SystemColors.ControlDark;
            labelNum1.Location = new Point(147, 226);
            labelNum1.Name = "labelNum1";
            labelNum1.Size = new Size(150, 25);
            labelNum1.TabIndex = 10;
            labelNum1.Text = "Длина строки: 0";
            // 
            // labelNum2
            // 
            labelNum2.AutoSize = true;
            labelNum2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelNum2.ForeColor = SystemColors.ControlDark;
            labelNum2.Location = new Point(626, 226);
            labelNum2.Name = "labelNum2";
            labelNum2.Size = new Size(150, 25);
            labelNum2.TabIndex = 11;
            labelNum2.Text = "Длина строки: 0";
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelResult.ForeColor = SystemColors.ControlDark;
            labelResult.Location = new Point(384, 409);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(150, 25);
            labelResult.TabIndex = 12;
            labelResult.Text = "Длина строки: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 552);
            Controls.Add(labelResult);
            Controls.Add(labelNum2);
            Controls.Add(labelNum1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBox3);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label labelNum1;
        private Label labelNum2;
        private Label labelResult;
    }
}