using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_System
{
    public partial class Form5 : Form
    {
        MySqlConnection connection =
    new MySqlConnection
    ("datasource=127.0.0.1;port=3306;username=root;password=");
        MySqlCommand command;
        MySqlDataReader mdr;
        public Form5()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) && string.IsNullOrEmpty(textBox2.Text))
            {
                //MessageBox.Show($"Please right your Username and Password");
                MessageBox.Show($"Please right your Username and Password", "No Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                connection.Open();
                string selectQuery = "SELECT * FROM unitrack.admin WHERE Username = '" + textBox1.Text + "' AND Password = '" + textBox2.Text + "';";
                command = new MySqlCommand(selectQuery, connection);
                mdr = command.ExecuteReader();
                if (mdr.Read())
                {
                    string MyConnection2 = "datasource=127.0.0.1;port=3306;username=root;password=";
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                    MyConn2.Close();

                    MessageBox.Show("Login Successful!");
                    this.Hide();
                    Form3 mainPage = new Form3();
                    mainPage.ShowDialog();

                }
                else
                {

                    MessageBox.Show("Incorrect Login Information! Try again.");
                }
                textBox1.Clear();
                textBox2.Clear();
                connection.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            // Show Form1
            form1.Show();

            // Close the current form (Form5)
            this.Hide(); // Use Hide() instead of Close() if you want to hide Form1 instead of closing it
        }
    }
}
