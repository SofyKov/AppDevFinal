using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G_Navigation
{
    public partial class AboutUsForm : Form
    {


        public AboutUsForm()
        {
            InitializeComponent();
            this.TopLevel = false;


        }

        private void aboutUs_ExitButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            // Access the previously visible form
            Form previousForm = FormManager.PreviousForm;

            Panel homeForm = FormManager.HomePanel;


            // Do something with the previously visible form
            if (previousForm != null)
            {

                previousForm.Show(); // Hide the previously visible form

            }
            
                homeForm.Show();
            

     


        }
    }
}
