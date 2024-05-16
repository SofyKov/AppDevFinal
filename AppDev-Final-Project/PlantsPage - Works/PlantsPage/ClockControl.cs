using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlantsPage
{
    public partial class ClockControl : UserControl
    {
        public ClockControl()
        {
            InitializeComponent();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            time_lbl.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);
            time_lbl.ForeColor = Color.IndianRed;
            time_lbl.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
