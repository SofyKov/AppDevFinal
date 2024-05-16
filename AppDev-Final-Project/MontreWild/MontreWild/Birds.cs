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
    public partial class Birds : Form
    { 
        //Counter
        int counter = -1;
        //Create an array for all animal names
        string[] birdNames = { "Canada Goose", "Pigeon" };

        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\MontreWildDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";
        
        public Birds()
        {
            InitializeComponent();
            birdPictureBox.Image = (Image)(Properties.Resources.ResourceManager.GetObject("birds"));
        }

       
        private void nextButton_Click(object sender, EventArgs e)
        {
            // Move to the next bird
            counter++;
            if (counter < birdNames.Length)
            {
                birdLabel.Text = birdNames[counter];
                DisplayBirdDescription();
                lastButton.Enabled = true;
                birdPictureBox.Image = (Image)(Properties.Resources.ResourceManager.GetObject("bird" + (counter + 1)));
            }
        }

        private void lastButton_Click(object sender, EventArgs e)
        {
            // Move to the last mammal
            counter--;
            if (counter >= 0)
            {
                birdLabel.Text = birdNames[counter];
                DisplayBirdDescription();
                nextButton.Enabled = true; // if the button was disabled enable it
                birdPictureBox.Image = (Image)(Properties.Resources.ResourceManager.GetObject("bird" + (counter + 1)));

            }
        }

        private void DisplayBirdDescription()
        {
            string currentBird = birdNames[counter];
            string description = GetBirdDescriptionFromDatabase(currentBird);
            descriptionTextBox.Text = description;

            // Disable the "Next" button when reaching the last bird
            if (counter == birdNames.Length - 1)
            {
                nextButton.Enabled = false;
            }

            if (counter == 0)
            {
                lastButton.Enabled = false;
            }
        }

        private string GetBirdDescriptionFromDatabase(string birdName)
        {
            string description = "";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Description FROM Animal WHERE AnimalName = @BirdName";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@BirdName", birdName);
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
