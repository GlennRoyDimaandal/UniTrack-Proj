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

namespace Login_System
{
    public partial class Form3 : Form
    {
        private List<string> checkedItems;

        public Form3(List<string> checkedItems)
        {
            InitializeComponent();

            // Store the checked items in the Form5 instance
            this.checkedItems = checkedItems;

            // Display the checked items in TextBox controls or any other controls in Form5
            DisplayCheckedItems();
        }

        private void DisplayCheckedItems()
        {
            // Assuming textBox1, textBox2, etc., are TextBox controls in Form5
            foreach (string item in checkedItems)
            {
                // Append each item to the TextBox controls or any other controls
                textBox1.AppendText(item + Environment.NewLine);
            }
        }

        public Form3()
        {
            InitializeComponent();
        }


        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you done?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Close the form
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Assume "Forms2" is the name of the form where you want to display the message
            Form2 form2 = new Form2();


            // Show a message indicating that a stack has been added
            MessageBox.Show("Stock added on Forms2", "Information");



        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Assume "Form4" is the name of the form where you want to display the message
            Form4 form4 = new Form4();


            // Show a message indicating that the order is cancelled
            MessageBox.Show("Cancelled Orders on Forms4", "Information");
        }
    }
}
