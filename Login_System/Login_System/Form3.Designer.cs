namespace Login_System
{
    partial class Form3
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
            button1 = new Button();
            panel1 = new Panel();
            textBox1 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(345, 308);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(143, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(478, 213);
            panel1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(0, 0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(478, 213);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(658, 12);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Add stock";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(44, 14);
            button3.Name = "button3";
            button3.Size = new Size(82, 21);
            button3.TabIndex = 3;
            button3.Text = "Cancel order";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._23416619_white_and_red_diagonal_grunge_texture_background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 403);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Name = "Form3";
            Text = "Order Preview";
            Load += Form3_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private TextBox textBox1;
        private Button button2;
        private Button button3;
    }
}