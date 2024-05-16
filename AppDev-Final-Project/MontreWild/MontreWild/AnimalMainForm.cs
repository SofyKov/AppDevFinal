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
        MammalDisplay mammalDisplay = new MammalDisplay();
        Birds birdDisplay = new Birds();
        OtherAnimal otherDisplay = new OtherAnimal();



        public AnimalMainForm()
        {
            InitializeComponent();
            this.TopLevel = false;
        }

        private void mammalButton_Click(object sender, EventArgs e)
        {

            //Open Mammal Form
    
            mammalDisplay.Dock = DockStyle.Fill;

            this.Controls.Add(mammalDisplay);

            birdDisplay.Visible = false;
            otherDisplay.Visible = false;
            mainPanel.Visible = false;

            mammalDisplay.Show();

        }

        private void birdButton_Click(object sender, EventArgs e)
        {
            //Open Bird Form
            this.Hide();
            birdDisplay.Show();
        }

        private void otherButton_Click(object sender, EventArgs e)
        {
            //Open Other Form
            this.Hide();
            otherDisplay.Show();
        }


        private void languageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var changeLanguage = new ChangeLanguage();

            switch (languageComboBox.SelectedIndex)
            {
                case 0:
                    changeLanguage.UpdateConfig("language", "en");
                    Application.Restart();
                    break;

                case 1:
                    changeLanguage.UpdateConfig("language", "fr-CA");
                    Application.Restart();
                    break;
                case 2:
                    changeLanguage.UpdateConfig("language", "es-MX");
                    Application.Restart();
                    break;
                case 3:
                    changeLanguage.UpdateConfig("language", "pt-PT");
                    Application.Restart();
                    break;

            }
        }

       
    }
}
