namespace LAB_6
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            outputBox = new RichTextBox();
            panel3 = new Panel();
            panel4 = new Panel();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(215, 14);
            label1.Name = "label1";
            label1.Size = new Size(360, 29);
            label1.TabIndex = 0;
            label1.Text = "Identity Daya Retrieval System";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 185);
            label2.Name = "label2";
            label2.Size = new Size(176, 18);
            label2.TabIndex = 1;
            label2.Text = "Eneter your NIC Number";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(19, 206);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(244, 18);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(56, 301);
            button1.Name = "button1";
            button1.Size = new Size(121, 36);
            button1.TabIndex = 3;
            button1.Text = "Generate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.MouseEnter += button1_MouseEnter;
            button1.MouseLeave += button1_MouseLeave;
            button1.MouseHover += button1_MouseHover;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(-1, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 1);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(276, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(1, 380);
            panel2.TabIndex = 5;
            // 
            // outputBox
            // 
            outputBox.BorderStyle = BorderStyle.None;
            outputBox.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            outputBox.Location = new Point(335, 114);
            outputBox.Name = "outputBox";
            outputBox.Size = new Size(386, 307);
            outputBox.TabIndex = 6;
            outputBox.Text = "";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(17, 225);
            panel3.Name = "panel3";
            panel3.Size = new Size(226, 1);
            panel3.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DodgerBlue;
            panel4.Controls.Add(label1);
            panel4.Location = new Point(12, 7);
            panel4.Name = "panel4";
            panel4.Size = new Size(768, 58);
            panel4.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(792, 450);
            Controls.Add(panel3);
            Controls.Add(outputBox);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(panel4);
            Name = "Form1";
            Text = "Form1";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private Panel panel1;
        private Panel panel2;
        private RichTextBox outputBox;
        private Panel panel3;
        private Panel panel4;
    }
}
