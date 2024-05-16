using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MontreWild
{
    public partial class AnimalMainForm : Form
    {
        public AnimalMainForm()
        {
            InitializeComponent();
        }

        private void mammalButton_Click(object sender, EventArgs e)
        {

            //Open Mammal Form
            MammalDisplay mammalDisplay = new MammalDisplay();
            this.Hide();
            mammalDisplay.Show();
          

        }

        private void birdButton_Click(object sender, EventArgs e)
        {
            //Open Bird Form
            Birds birdDisplay = new Birds();
            this.Hide();
            birdDisplay.Show();
        }

        private void otherButton_Click(object sender, EventArgs e)
        {
            //Open Other Form
            OtherAnimal otherDisplay = new OtherAnimal();
            this.Hide();
            otherDisplay.Show();
        }
    }
}
