using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G_Navigation
{
    public partial class EncyclopediaForm : Form
    {
        public EncyclopediaForm()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.Shown += EncyclopediaForm_Shown;

        }

        private void EncyclopediaForm_Shown(object sender, EventArgs e)
        {
            // Update the previously visible form to be this form
            FormManager.UpdatePreviousForm(this);
        }

        private void EncyclopediaForm_Load(object sender, EventArgs e)
        {
            this.combinedDataTableAdapter.Fill(this.montreWildDBDataSet.CombinedData);

            // Set the selected name as the title label
            encyTitleLabel.Text = "Bloodroot";

            // Query your database to fetch the description based on the selected name
            Dictionary<string, string> details = GetDetailsFromDatabase("Bloodroot");

            addTextToLabels(details);
        }



        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedName ="";

            // Check if any item is selected
            if (combinedDataListBox.SelectedItem != null)
            {
                // Get the selected DataRowView
                DataRowView selectedItem = (DataRowView)combinedDataListBox.SelectedItem;

                // Get the value of the name column
                selectedName = selectedItem["Name"].ToString();
            }
            if (encySearchedListBox.SelectedItem != null) {

               var item = encySearchedListBox.SelectedItem;

                // Get the value of the name column
                 selectedName = item.ToString();
                
            }

            // Set the selected name as the title label
            encyTitleLabel.Text = selectedName;

            // Query your database to fetch the description based on the selected name
            Dictionary<string, string> details = GetDetailsFromDatabase(selectedName);

            addTextToLabels(details);

        }

        private void addTextToLabels(Dictionary<string, string> details ) {
            // Update the labels with the retrieved details
            if (details["ScientificPlantName"] == "")
            {
                encySciLabel.Visible = false;
                encyDescriptionLabel.Location = new System.Drawing.Point(20, 105);
                encyUseLabel.Visible = false;

            }
            else
            {
                encySciLabel.Visible = true;
                encySciLabel.Text = "Scientific Name: " + details["ScientificPlantName"];
                encyDescriptionLabel.Location = new System.Drawing.Point(20, 155);
                encyUseLabel.Visible = true;


            }
            encyDescriptionLabel.Text = details["Description"];
            encyTypeLabel.Text = details["Type"];
            encyEntityTypeLabel.Text = "Entity Type: " + details["EntityType"];
            encyUseLabel.Text = details["PlantUse"];

        }

        private Dictionary<string, string> GetDetailsFromDatabase(string name)
        {
            Dictionary<string, string> details = new Dictionary<string, string>();

            // Connection string to your database
            string connectionString = Properties.Settings.Default.MontreWildDBConnectionString;

            // SQL query to retrieve details based on the provided name
            string query = @"
                SELECT 'Animal' AS EntityType, AnimalType AS Type, Description, NULL AS ScientificPlantName, NULL AS PlantUse
                FROM dbo.Animal
                WHERE AnimalName LIKE @Name
                UNION ALL
                SELECT 'Plant' AS EntityType, Type AS Type, Description, ScientificPlantName, PlantUse
                FROM dbo.Plant
                WHERE @Name NOT IN (SELECT AnimalName FROM dbo.Animal) AND PlantName LIKE @Name";

            // Create a SqlConnection and SqlCommand
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Add parameters to the command
                command.Parameters.AddWithValue("@Name", "%" + name + "%");

                try
                {
                    // Open the connection
                    connection.Open();

                    // Execute the command and retrieve the details
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Retrieve and store each detail in the dictionary
                            details["EntityType"] = reader["EntityType"].ToString();
                            details["Type"] = reader["Type"].ToString();
                            details["Description"] = reader["Description"].ToString();
                            details["ScientificPlantName"] = reader["ScientificPlantName"].ToString();
                            details["PlantUse"] = reader["PlantUse"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that occur during database access
                    Console.WriteLine("Error retrieving details from database: " + ex.Message);
                }
            }

            return details;
        }

        private void encySearchButton_Click(object sender, EventArgs e)
        {

           encySearchedListBox.Items.Clear();

            if (encyTextBox.Text == "")
            {
                encySearchedListBox.Items.Clear();
            }
            else
            {

                string toSearch = encyTextBox.Text.Trim();

                string connectionString = Properties.Settings.Default.MontreWildDBConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = @"
                SELECT 'Animal' AS EntityType, AnimalID, AnimalName AS Name, AnimalType, Description, Place, NULL AS ScientificPlantName, NULL AS PlantUse
                FROM dbo.Animal
                WHERE AnimalName LIKE @SearchText
                UNION ALL
                SELECT 'Plant' AS EntityType, PlantID, PlantName AS Name, Type, Description, Place, ScientificPlantName, PlantUse
                FROM dbo.Plant
                WHERE PlantName LIKE @SearchText
                AND NOT EXISTS (
                    SELECT 1 FROM dbo.Animal WHERE AnimalName LIKE @SearchText
                )";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@SearchText", "%" + toSearch + "%");
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string name = reader["Name"].ToString(); // Check the correct column name in your database
                                    combinedDataListBox.Visible = false;
                                    encySearchedListBox.Visible = true;
                                    encySearchedListBox.Items.Add(name);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void encyTextBox_TextChanged(object sender, EventArgs e)
        {
            // Check if the search textbox is empty
            if (string.IsNullOrEmpty(encyTextBox.Text.Trim()))
            {
                encySearchedListBox.Items.Clear();

                // If empty, display listbox
                encySearchedListBox.Visible = false;
                combinedDataListBox.Visible = true;         
            }
         

        }
    }
    }