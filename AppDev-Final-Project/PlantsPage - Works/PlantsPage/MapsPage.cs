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
    public partial class MapsPage : Form
    {
        int _RecordIndex = 0;
        DataTable _DT;
        string connextionStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\temp\PlantsPage\PlantsPage\MontreWildDB.mdf;Integrated Security=True;Connect Timeout=30;";

        public MapsPage()
        {
            InitializeComponent();
            motoLink_lbl.Links.Add(0, motoLink_lbl.Text.Length, "https://en.wikipedia.org/wiki/Coat_of_arms_of_Montreal#:~:text=The%20motto%20on%20the%20scroll,to%20better%20reflect%20Montreal's%20population.");
        }

        private void WestIsland_btn_Click(object sender, EventArgs e)
        {
            MapInfoForm mif = new MapInfoForm(1);
            mif.Show();
        }

        private void stLaurent_btn_Click(object sender, EventArgs e)
        {
            MapInfoForm mif = new MapInfoForm(5);
            mif.Show();
        }

        private void montRoyal_btn_Click(object sender, EventArgs e)
        {
            MapInfoForm mif = new MapInfoForm(3);
            mif.Show();
        }

        private void mtlnord_btn_Click(object sender, EventArgs e)
        {
            MapInfoForm mif = new MapInfoForm(4);
            mif.Show();
        }

        private void jeanDrapeau_btn_Click(object sender, EventArgs e)
        {
            MapInfoForm mif = new MapInfoForm(2);
            mif.Show();
        }

        private void motoLink_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FloraForm floraForm = new FloraForm();
            floraForm.ShowDialog();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
