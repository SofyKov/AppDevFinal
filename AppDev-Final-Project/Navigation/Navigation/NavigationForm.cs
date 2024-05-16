using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navigation
{
    public partial class NavigationForm : Form
    {
        public event EventHandler<string> NavigationItemSelected;

        public NavigationForm()
        {
            InitializeComponent();
        }



        private void animalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnNavigationItemSelected("Animals");

        }
        private void OnNavigationItemSelected(string destination)
        {
            NavigationItemSelected?.Invoke(this, destination);
        }

        private void plantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnNavigationItemSelected("Plants");

        }

        private void encyclopediaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnNavigationItemSelected("Encyclopedia");

        }

        private void gamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnNavigationItemSelected("Games");

        }

        private void navHomeLabel_Click(object sender, EventArgs e)
        {
            OnNavigationItemSelected("Home");
        }

        private void aboutUsLabel_Click(object sender, EventArgs e)
        {
            OnNavigationItemSelected("About Us");

        }
    }
}
