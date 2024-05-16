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
    public partial class MammalDisplay : Form
    {
        //Counter
        int counter = -1;
        //Create an array for all animal names
        string[] mammalNames = { "Raccoon", "Red Fox", "River Otter", "White-Tailed Deer", "North American Beaver" };

        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\MontreWildDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";
        public MammalDisplay()
        {
            InitializeComponent();
            animalsPictureBox.Image = (Image)(Properties.Resources.ResourceManager.GetObject("mammals"));
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            // Move to the next mammal
            counter++;
            if (counter < mammalNames.Length)
            {
                mammalLabel.Text = mammalNames[counter];
                DisplayMammalDescription();
                lastButton.Enabled = true;
                animalsPictureBox.Image = (Image)(Properties.Resources.ResourceManager.GetObject("mammal" + (counter+1)));
            }

        }

        private void lastButton_Click(object sender, EventArgs e)
        {
            // Move to the last mammal
            counter--;
            if (counter >= 0)
            {
                mammalLabel.Text = mammalNames[counter];
                DisplayMammalDescription();
                nextButton.Enabled = true; // if the button was disabled enable it
                animalsPictureBox.Image = (Image)(Properties.Resources.ResourceManager.GetObject("mammal" + (counter + 1)));

            }
        }

        private void DisplayMammalDescription()
        {
            string currentMammal = mammalNames[counter];
            string description = GetMammalDescriptionFromDatabase(currentMammal);
            descriptionTextBox.Text = description;

            // Disable the "Next" button when reaching the last mammal
            if (counter == mammalNames.Length - 1)
            {
                nextButton.Enabled = false;
            }

            if(counter == 0)
            {
               lastButton.Enabled = false;
            }
        }

        private string GetMammalDescriptionFromDatabase(string mammalName)
        {
            string description = "";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Description FROM Animal WHERE AnimalName = @MammalName";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MammalName", mammalName);
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
