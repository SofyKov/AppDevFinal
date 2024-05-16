using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskBand;

namespace PlantsPage
{
    public partial class PlantsPage : Form
    {
        int _RecordIndex = 0;
        DataTable _DT;
        string connextionStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\temp\PlantsPage\PlantsPage\MontreWildDB.mdf;Integrated Security=True;Connect Timeout=30;";

        public PlantsPage()
        {
            InitializeComponent();
            LoadDataFromDB();
        }

        private void LoadDataFromDB()
        {
            string selectQuery = "SELECT * FROM Plant WHERE Type = 'Flowering Plant' OR Type = 'Plant'";

            using (SqlConnection conn = new SqlConnection(connextionStr))
            {
                conn.Open();

                // Connect to the SQL database using the above query to get all the data from table.
                using (SqlDataAdapter dAdapter = new SqlDataAdapter(selectQuery, conn))
                {
                    // Create and fill a DataSet.
                    using (DataSet ds = new DataSet())
                    {
                        dAdapter.Fill(ds);
                        _DT = ds.Tables[0];
                    }
                }
            }
        }

        private void prev_btn_Click(object sender, EventArgs e)
        {
            // Move to the next plant
            makeIndexMinus();
            if (_RecordIndex < _DT.Rows.Count)
            {
                string currPlant = _DT.Rows[_RecordIndex].ItemArray[1].ToString();
                plantName_lbl.Text = currPlant;
                sciPlantName_lbl.Text = _DT.Rows[_RecordIndex].ItemArray[2].ToString();

                string description = GetPlantDescriptionFromDB(currPlant, "Description");
                description_richTBox.Text = description;

                string plantUse = GetPlantDescriptionFromDB(currPlant, "PlantUse");
                plantUse_richTBox.Text = description;

                plantsPictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject("plant" + (_RecordIndex + 1));
            }
            else 
            {
                //_RecordIndex = _RecordIndex.;
            }
        }

        private void makeIndexMinus()
        {
            _RecordIndex--;
            if (_RecordIndex < 0)
            {
                _RecordIndex = 0;
            }
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            if (_RecordIndex < _DT.Rows.Count)
            {
                //next_btn.Enabled = true;

                string currPlant = _DT.Rows[_RecordIndex].ItemArray[1].ToString();
                plantName_lbl.Text = currPlant;
                sciPlantName_lbl.Text = _DT.Rows[_RecordIndex].ItemArray[2].ToString();

                string description = GetPlantDescriptionFromDB(currPlant, "Description");
                description_richTBox.Text = description;

                string plantUse = GetPlantDescriptionFromDB(currPlant, "PlantUse");
                plantUse_richTBox.Text = description;

                plantsPictureBox.Image = (Image)(Properties.Resources.ResourceManager.GetObject("plant" + (_RecordIndex + 1)));

                // Move to the next plant
                _RecordIndex++;
            }
            else 
            {
                _RecordIndex = 0;
            }
        }

        private string GetPlantDescriptionFromDB(string plantName, string info)
        {
            string requestInfo = "";

            try
            {
                using (SqlConnection conn = new SqlConnection(connextionStr))
                {
                    conn.Open();
                    string query = "SELECT " + info + " FROM Plant WHERE PlantName = @plantName";

                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@plantName", plantName);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        requestInfo = reader[info].ToString();
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return requestInfo;
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FloraForm floraForm = new FloraForm();
            floraForm.ShowDialog();
            this.Close();
        }
    }
}