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
            additionBtn = new Button();
            substractBtn = new Button();
            multiplyBtn = new Button();
            divideBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            labelNum1 = new Label();
            labelNum2 = new Label();
            labelResult = new Label();
            button5 = new Button();
            button1 = new Button();
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
            richTextBox3.Location = new Point(41, 302);
            richTextBox3.Margin = new Padding(3, 2, 3, 2);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(844, 129);
            richTextBox3.TabIndex = 2;
            richTextBox3.Text = "";
            richTextBox3.TextChanged += richTextBox3_TextChanged;
            // 
            // additionBtn
            // 
            additionBtn.FlatStyle = FlatStyle.Popup;
            additionBtn.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            additionBtn.Location = new Point(26, 487);
            additionBtn.Margin = new Padding(3, 2, 3, 2);
            additionBtn.Name = "additionBtn";
            additionBtn.Size = new Size(99, 91);
            additionBtn.TabIndex = 3;
            additionBtn.Text = "+";
            additionBtn.UseVisualStyleBackColor = true;
            additionBtn.Click += additionBtn_Click;
            // 
            // substractBtn
            // 
            substractBtn.FlatStyle = FlatStyle.Popup;
            substractBtn.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            substractBtn.Location = new Point(649, 487);
            substractBtn.Margin = new Padding(3, 2, 3, 2);
            substractBtn.Name = "substractBtn";
            substractBtn.Size = new Size(102, 91);
            substractBtn.TabIndex = 4;
            substractBtn.Text = "-";
            substractBtn.UseVisualStyleBackColor = true;
            substractBtn.Click += substractBtn_Click;
            // 
            // multiplyBtn
            // 
            multiplyBtn.FlatStyle = FlatStyle.Popup;
            multiplyBtn.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            multiplyBtn.Location = new Point(183, 487);
            multiplyBtn.Margin = new Padding(3, 2, 3, 2);
            multiplyBtn.Name = "multiplyBtn";
            multiplyBtn.Size = new Size(102, 91);
            multiplyBtn.TabIndex = 5;
            multiplyBtn.Text = "*";
            multiplyBtn.UseVisualStyleBackColor = true;
            multiplyBtn.Click += multiplyBtn_Click;
            // 
            // divideBtn
            // 
            divideBtn.FlatStyle = FlatStyle.Popup;
            divideBtn.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            divideBtn.Location = new Point(492, 487);
            divideBtn.Margin = new Padding(3, 2, 3, 2);
            divideBtn.Name = "divideBtn";
            divideBtn.Size = new Size(99, 91);
            divideBtn.TabIndex = 6;
            divideBtn.Text = "/";
            divideBtn.UseVisualStyleBackColor = true;
            divideBtn.Click += divideBtn_Click;
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
            label3.Location = new Point(404, 275);
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
            labelResult.Location = new Point(384, 433);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(150, 25);
            labelResult.TabIndex = 12;
            labelResult.Text = "Длина строки: 0";
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(334, 487);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(102, 91);
            button5.TabIndex = 13;
            button5.Text = "%";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(799, 487);
            button1.Name = "button1";
            button1.Size = new Size(102, 91);
            button1.TabIndex = 14;
            button1.Text = "^";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 600);
            Controls.Add(button1);
            Controls.Add(button5);
            Controls.Add(labelResult);
            Controls.Add(labelNum2);
            Controls.Add(labelNum1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(divideBtn);
            Controls.Add(multiplyBtn);
            Controls.Add(substractBtn);
            Controls.Add(additionBtn);
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
        private Button additionBtn;
        private Button substractBtn;
        private Button multiplyBtn;
        private Button divideBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label labelNum1;
        private Label labelNum2;
        private Label labelResult;
        private Button button5;
        private Button button1;
    }
}