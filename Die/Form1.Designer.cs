namespace Die
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
            button1 = new Button();
            diebox1 = new RichTextBox();
            diebox3 = new RichTextBox();
            label1 = new Label();
            button2 = new Button();
            label2 = new Label();
            diebox2 = new RichTextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(30, 140);
            button1.Name = "button1";
            button1.Size = new Size(229, 24);
            button1.TabIndex = 0;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // diebox1
            // 
            diebox1.BackColor = Color.FromArgb(39, 39, 39);
            diebox1.BorderStyle = BorderStyle.None;
            diebox1.ForeColor = Color.White;
            diebox1.Location = new Point(30, 27);
            diebox1.Name = "diebox1";
            diebox1.Size = new Size(229, 24);
            diebox1.TabIndex = 1;
            diebox1.Text = "username";
            // 
            // diebox3
            // 
            diebox3.BackColor = Color.FromArgb(39, 39, 39);
            diebox3.BorderStyle = BorderStyle.None;
            diebox3.ForeColor = Color.White;
            diebox3.Location = new Point(30, 88);
            diebox3.Name = "diebox3";
            diebox3.Size = new Size(229, 22);
            diebox3.TabIndex = 3;
            diebox3.Text = "                               key";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.ForeColor = Color.White;
            label1.Location = new Point(115, 7);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 4;
            label1.Text = "Die V4 ";
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(30, 170);
            button2.Name = "button2";
            button2.Size = new Size(229, 24);
            button2.TabIndex = 5;
            button2.Text = "Buy A Account";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.ForeColor = Color.White;
            label2.Location = new Point(100, 210);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 6;
            label2.Text = "made by 4bx9";
            // 
            // diebox2
            // 
            diebox2.BackColor = Color.FromArgb(39, 39, 39);
            diebox2.BorderStyle = BorderStyle.None;
            diebox2.ForeColor = Color.White;
            diebox2.Location = new Point(30, 57);
            diebox2.Name = "diebox2";
            diebox2.Size = new Size(229, 24);
            diebox2.TabIndex = 7;
            diebox2.Text = "password";
            diebox2.Click += diebox2_Click;
            diebox2.TextChanged += diebox2_TextChanged_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 29, 29);
            ClientSize = new Size(290, 236);
            Controls.Add(diebox2);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(diebox3);
            Controls.Add(diebox1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Die V4 Login";
            Load += Form1_Load;
            MouseDown += Form1_MouseDown_1;
            MouseMove += Form1_MouseMove_1;
            MouseUp += Form1_MouseUp_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private RichTextBox diebox1;
        private RichTextBox diebox3;
        private Label label1;
        private Button button2;
        private Label label2;
        private RichTextBox diebox2;
    }
}
