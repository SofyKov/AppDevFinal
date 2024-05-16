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

namespace PlantsPage
{
    public partial class MapInfoForm : Form
    {
        int _RecordIndex = 0;
        DataTable _DT;
        string connextionStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\temp\PlantsPage\PlantsPage\MontreWildDB.mdf;Integrated Security=True;Connect Timeout=30;";
        string selectQuery = "";
        int _Place = 0;

        public MapInfoForm(int placeID)
        {
            InitializeComponent();
            _Place = placeID;
            displayOnLoadAnimal();
            displayOnLoadPlant();
        }

        private void LoadDataFromDB(string selectQuery)
        {
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

        public void displayOnLoadAnimal() 
        {
            selectQuery = "SELECT * FROM Animal WHERE Place = " + _Place;
            LoadDataFromDB(selectQuery);

            if (_DT != null && _DT.Rows.Count > 0 && _DT.Rows[_RecordIndex].ItemArray[_RecordIndex] != null)
            {
                foreach (DataRow row in _DT.Rows)
                {
                    animalsRichTextBox.Text += "Name: " + row.ItemArray[1].ToString() + "\n";
                    animalsRichTextBox.Text += "Type: " + row.ItemArray[2].ToString() + "\n\n";
                }
            }
            else
            {
                animalsRichTextBox.Text = "There are no observable animals in this region :(";
            }
            animal_lbl.Focus();
        }


        public void displayOnLoadPlant()
        {
            selectQuery = "SELECT * FROM Plant WHERE Place = " + _Place;
            LoadDataFromDB(selectQuery);

            if (_DT != null && _DT.Rows.Count > 0 && _DT.Rows[_RecordIndex].ItemArray[_RecordIndex] != null)
            {
                foreach (DataRow row in _DT.Rows)
                {
                    plantsRichTextBox.Text += "Name: " +row.ItemArray[1].ToString() + "\n";
                    plantsRichTextBox.Text += "Scientific Name: " + row.ItemArray[2].ToString() + "\n";
                    plantsRichTextBox.Text += "Type: " + row.ItemArray[5].ToString() + "\n\n";
                }
            }
            else
            {
                plantsRichTextBox.Text = "There are no observable plants in this region :(";
            }
            animal_lbl.Focus();
        }
    }
}
