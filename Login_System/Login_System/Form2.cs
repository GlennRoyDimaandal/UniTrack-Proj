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
using static System.Net.Mime.MediaTypeNames;

namespace Login_System
{
    public partial class Form2 : Form
    {
        MySqlConnection registerAccount = new MySqlConnection
        ("datasource=127.0.0.1;port=3306;username=root;password=");
        public Form2()
        {
            InitializeComponent();
        }
        // Public property to store information
        public string Form2Data { get; set; }
        private List<string> checkedItems = new List<string>();

        private void loginButton_Click(object sender, EventArgs e)
        {
            // Check which checkboxes are checked and prompt for quantity and size or type
            foreach (CheckBox checkbox in Controls.OfType<CheckBox>())
            {
                if (checkbox.Checked)
                {
                    // Ask for quantity
                    int quantity;
                    if (TryGetQuantity(checkbox.Text, out quantity))
                    {
                        // Ask for size if the checkbox is 1, 2, 3, or 4
                        string additionalInfo = string.Empty;
                        if (checkbox.Name == "checkBox1" || checkbox.Name == "checkBox2" || checkbox.Name == "checkBox3" || checkbox.Name == "checkBox4")
                        {
                            additionalInfo = Microsoft.VisualBasic.Interaction.InputBox($"Enter size for {checkbox.Text}:", "Size", "Medium");
                        }
                        else if (checkbox.Name == "checkBox5")
                        {
                            // Directly choose between "ID lace" and "Tumbler set"
                            string[] options = { "ID Lace", "Mug/Tumbler" };
                            string promptMessage = $"Select the type for {checkbox.Text}:\n";
                            foreach (string option in options)
                            {
                                promptMessage += $"- {option}\n";
                            }

                            additionalInfo = Microsoft.VisualBasic.Interaction.InputBox(promptMessage, "Type Selection", options[0]);

                            // Validate the input
                            if (!options.Contains(additionalInfo))
                            {
                                MessageBox.Show("Invalid selection. Please choose a valid type.", "Invalid Type");
                                return;
                            }
                        }

                        // Quantity and size or type obtained, add to the list
                        checkedItems.Add($"{checkbox.Text} (Quantity: {quantity}, Type: {additionalInfo})");
                    }
                    else
                    {
                        // Quantity not provided, skip this item
                        MessageBox.Show($"Please enter a valid quantity for {checkbox.Text}.", "Invalid Quantity");
                        return; // Stop further processing
                    }
                }
            }

            // Close Form2
            this.Close();

            // Open Form4 and pass the checked items
            Form4 form4 = new Form4(checkedItems);
            form4.ShowDialog();
        }



        private bool TryGetQuantity(string itemName, out int quantity)
        {
            // Prompt for quantity
            string input = Microsoft.VisualBasic.Interaction.InputBox($"Enter quantity for {itemName}:", "Quantity", "1");

            // Try parsing the input
            return int.TryParse(input, out quantity);
        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Save data when CheckBox1 is checked
            if (checkBox1.Checked)
            {
                Form2Data = "Data to be saved";
            }
            else
            {
                Form2Data = null;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            // Save data when CheckBox1 is checked
            if (checkBox1.Checked)
            {
                Form2Data = "Data to be saved";
            }
            else
            {
                Form2Data = null;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            // Save data when CheckBox1 is checked
            if (checkBox1.Checked)
            {
                Form2Data = "Data to be saved";
            }
            else
            {
                Form2Data = null;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            // Save data when CheckBox1 is checked
            if (checkBox1.Checked)
            {
                Form2Data = "Data to be saved";
            }
            else
            {
                Form2Data = null;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            // Save data when CheckBox1 is checked
            if (checkBox1.Checked)
            {
                Form2Data = "Data to be saved";
            }
            else
            {
                Form2Data = null;
            }
        }
    }
}
