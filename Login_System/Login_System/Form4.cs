using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Login_System
{
    public partial class Form4 : Form
    {
        MySqlConnection InsertEntry =
    new MySqlConnection
    ("datasource=127.0.0.1;port=3306;username=root;password=");
        public Form4()
        {
            InitializeComponent();
        }

        private List<string> checkedItems;

        // Constructor that takes a List<string> as a parameter
        public Form4(List<string> checkedItems)
        {
            InitializeComponent();

            // Store the checked items in the Form4 instance
            this.checkedItems = checkedItems;

            // Display the checked items in TextBox controls
            DisplayCheckedItems();
        }

        private void DisplayCheckedItems()
        {
            // Assuming textBox1, textBox2, etc., are TextBox controls in Form4
            foreach (string item in checkedItems)
            {
                // Append each item to the TextBox controls
                textBox1.AppendText(item + Environment.NewLine);
            }
        }


        private void Form4_Load(object sender, EventArgs e)
        {

        }
        // Public method to show data
        public void ShowDataFromForm2(string data)
        {
            // Display the data in Form4 controls
            // For example, if you have a TextBox named textBox1:
            textBox1.Text = data;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Ask for confirmation
            DialogResult result = MessageBox.Show("Are you done?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's response
            if (result == DialogResult.Yes)
            {
                // Close the current form (Form4)
                this.Close();
            }
            else if (result == DialogResult.No)
            {
                // Hide the current form (Form4)
                this.Hide();

                // Show Form2
                Form2 form2 = new Form2();
                form2.Show();
            }
        }
    }
}
