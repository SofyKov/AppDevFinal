using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlantsPage
{
    public partial class FloraForm : Form
    {
        public FloraForm()
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en");
            InitializeComponent();
        }

        private void btn_Plants_Click(object sender, EventArgs e)
        {
            PlantsPage plPage = new PlantsPage();
            plPage.ShowDialog();
        }

        private void btn_Shrub_Click(object sender, EventArgs e)
        {
            ShrubsPage shPage = new ShrubsPage();
            shPage.ShowDialog();
        }

        private void btn_Tree_Click(object sender, EventArgs e)
        {
            TreePage treePage = new TreePage();   
            treePage.ShowDialog();
        }
    }
}
