using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Login_System
{
    public partial class Form1 : Form
    {
        private Form2 RegisterForm;

        MySqlConnection connection =
            new MySqlConnection
            ("datasource=127.0.0.1;port=3306;username=root;password=");
        MySqlCommand command;
        MySqlDataReader mdr;
        public Form1()
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
                string selectQuery = "SELECT * FROM unitrack.users WHERE Username = '" + textBox1.Text + "' AND Password = '" + textBox2.Text + "';";
                command = new MySqlCommand(selectQuery, connection);
                mdr = command.ExecuteReader();
                if (mdr.Read())
                {
                    string MyConnection2 = "datasource=127.0.0.1;port=3306;username=root;password=";
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                    MyConn2.Close();

                    MessageBox.Show("Login Successful!");
                    this.Hide();
                    Form2 mainPage = new Form2();
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


        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opening page to Create Account", "Welcome!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Hide();
            RegisterForm = new Form2();
            RegisterForm.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void NavigateBetweenForms()
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();

            if (form2.DialogResult == DialogResult.OK) // Assuming OK is the result when you want to go to Form4
            {
                Form4 form4 = new Form4();
                form4.ShowDataFromForm2(form2.Form2Data);
                form4.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();

            // Show Form5
            form5.Show();

            // Close the current form (Form1)
            this.Hide(); // Use Hide() instead of Close() if you want to hide Form1 instead of closing it
        }

    }
}