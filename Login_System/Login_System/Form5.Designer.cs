namespace Login_System
{
    partial class Form5
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            loginButton = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(214, 196);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 3;
            label1.Text = "Username: ";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.HighlightText;
            textBox1.Font = new Font("Segoe UI Historic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(286, 179);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(198, 39);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.HighlightText;
            textBox2.Font = new Font("Segoe UI Historic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(286, 254);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(198, 39);
            textBox2.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(217, 271);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 7;
            label2.Text = "Password: ";
            // 
            // loginButton
            // 
            loginButton.Location = new Point(323, 316);
            loginButton.Margin = new Padding(3, 2, 3, 2);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(118, 48);
            loginButton.TabIndex = 8;
            loginButton.Text = "Log-In";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(724, 426);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._23416619_white_and_red_diagonal_grunge_texture_background__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(loginButton);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form5";
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Button loginButton;
        private Button button1;
    }
}