using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MontreWild
{
    public partial class OtherAnimal : Form
    {

        //Counter
        int counter = -1;
        //Create an array for all animal names
        string[] otherNames = { "Blue-Spotted Salamander", "Groundhogs", "The Greenland shark" };
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\MontreWildDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";

        public OtherAnimal()
        {
            this.TopLevel = false;

            InitializeComponent();
           otherPictureBox.Image = (Image)(Properties.Resources.ResourceManager.GetObject("other"));
        }

       
        private void nextButton_Click(object sender, EventArgs e)
        {
            // Move to the next bird
            counter++;
            if (counter < otherNames.Length)
            {
                otherLabel.Text = otherNames[counter];
                DisplayOtherDescription();
                lastButton.Enabled = true;
                otherPictureBox.Image = (Image)(Properties.Resources.ResourceManager.GetObject("other" + (counter + 1)));
            }
        }

        private void lastButton_Click(object sender, EventArgs e)
        {
            // Move to the last mammal
            counter--;
            if (counter >= 0)
            {
                otherLabel.Text = otherNames[counter];
                DisplayOtherDescription();
                nextButton.Enabled = true; // if the button was disabled enable it
                otherPictureBox.Image = (Image)(Properties.Resources.ResourceManager.GetObject("other" + (counter + 1)));

            }
        }

        private void DisplayOtherDescription()
        {
            string currentAnimal = otherNames[counter];
            string description = GetOtherDescriptionFromDatabase(currentAnimal);
            descriptionTextBox.Text = description;

            // Disable the "Next" button when reaching the last bird
            if (counter == otherNames.Length - 1)
            {
                nextButton.Enabled = false;
            }

            if (counter == 0)
            {
                lastButton.Enabled = false;
            }
        }

        private string GetOtherDescriptionFromDatabase(string otherName)
        {
            string description = "";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Description FROM Animal WHERE AnimalName = @OtherName";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@OtherName", otherName);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        description = reader["Description"].ToString();
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return description;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            AnimalMainForm main = new AnimalMainForm();
            main.Show();
            this.Hide();
        }
    }
}
