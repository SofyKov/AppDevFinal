using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureVideoPage
{
    public partial class PictureAndVideoForm : Form
    {
        public PictureAndVideoForm()
        {
            InitializeComponent();
        }


        // Helper method to hide all image controls
        private void HideAllImages()
        {
            pigeonPictureBox.Visible = false;
            deerPictureBox.Visible = false;
            mapleSilverPictureBox.Visible = false;
            groundHogPictureBox.Visible = false;
            salamaderPictureBox.Visible = false;
            raspberryPictureBox.Visible = false;
            hyssopsPictureBox.Visible = false;
            goosePictureBox.Visible = false;
        }

        private void pigeonImage_Click(object sender, EventArgs e)
        {
            // Hide all images
            HideAllImages();

            // Show the selected image
            biggerImagePanel.Visible = true;
            pigeonPictureBox.Visible = true;
            pigeonBackButton.Visible = true;
            this.AutoScroll = false;
        }


        private void bloodRoot_Click(object sender, EventArgs e)
        {
            // Hide all images
            HideAllImages();

            // Show the selected image
            biggerImagePanel.Visible = true;
            bloodrootPictureBox.Visible = true;
            bloodrootBackButton.Visible = true;
            this.AutoScroll = false;
        }

        private void deer_Click(object sender, EventArgs e)
        {
            // Hide all images
            HideAllImages();

            // Show the selected image
            biggerImagePanel.Visible = true;
            deerPictureBox.Visible = true;
            deerBackButton.Visible = true;
            this.AutoScroll = false;
        }

        private void silverMaple_Click(object sender, EventArgs e)
        {
            // Hide all images
            HideAllImages();

            // Show the selected image
            biggerImagePanel.Visible = true;
            mapleSilverPictureBox.Visible = true;
            silverMapleBackButton.Visible = true;
            this.AutoScroll = false;
        }

        private void groundHog_Click(object sender, EventArgs e)
        {
            // Hide all images
            HideAllImages();

            // Show the selected image
            biggerImagePanel.Visible = true;
            groundHogPictureBox.Visible = true;
            groundHogBackButton.Visible = true;
            this.AutoScroll = false;
        }

        private void salamander_Click(object sender, EventArgs e)
        {
            // Hide all images
            HideAllImages();

            // Show the selected image
            biggerImagePanel.Visible = true;
            salamaderPictureBox.Visible = true;
            salamanderbackButton.Visible = true;
            this.AutoScroll = false;
        }

        private void raspberry_Click(object sender, EventArgs e)
        {
            // Hide all images
            HideAllImages();

            // Show the selected image
            biggerImagePanel.Visible = true;
            raspberryPictureBox.Visible = true;
            raspberryBackButton.Visible = true;
            this.AutoScroll = false;
        }

        private void hyssops_Click(object sender, EventArgs e)
        {
            // Hide all images
            HideAllImages();

            // Show the selected image
            biggerImagePanel.Visible = true;
            hyssopsPictureBox.Visible = true;
            hyssopsBackButton.Visible = true;
            this.AutoScroll = false;
        }

        private void goose_Click(object sender, EventArgs e)
        {
            // Hide all images
            HideAllImages();

            // Show the selected image
            biggerImagePanel.Visible = true;
            goosePictureBox.Visible = true;
            gooseBackButton.Visible = true;
            this.AutoScroll = false;
        }

        private void gooseBackButton_Click(object sender, EventArgs e)
        {
            biggerImagePanel.Visible = false;
            goosePictureBox.Visible = false;
            gooseBackButton.Visible = false;
            this.AutoScroll = true;
        }

        private void raspberryBackButton_Click(object sender, EventArgs e)
        {
            biggerImagePanel.Visible = false;
            raspberryPictureBox.Visible = false;
            raspberryBackButton.Visible = false;
            this.AutoScroll = true;
        }

        private void salamanderbackButton_Click(object sender, EventArgs e)
        {
            biggerImagePanel.Visible = false;
            salamaderPictureBox.Visible = false;
            salamanderbackButton.Visible = false;
            this.AutoScroll = true;
        }

        private void groundHogBackButton_Click(object sender, EventArgs e)
        {
            biggerImagePanel.Visible = false;
            groundHogPictureBox.Visible = false;
            groundHogBackButton.Visible = false;
            this.AutoScroll = true;
        }

        private void silverMapleBackButton_Click(object sender, EventArgs e)
        {
            biggerImagePanel.Visible = false;
            mapleSilverPictureBox.Visible = false;
            silverMapleBackButton.Visible = false;
            this.AutoScroll = true;
        }

        private void deerBackButton_Click(object sender, EventArgs e)
        {
            biggerImagePanel.Visible = false;
            deerPictureBox.Visible = false;
            deerBackButton.Visible = false;
            this.AutoScroll = true;
        }

        private void bloodrootBackButton_Click(object sender, EventArgs e)
        {
            biggerImagePanel.Visible = false;
            bloodrootPictureBox.Visible = false;
            bloodrootBackButton.Visible = false;
            this.AutoScroll = true;
        }

        private void pigeonBackButton_Click(object sender, EventArgs e)
        {
            biggerImagePanel.Visible = false;
            pigeonPictureBox.Visible = false;
            pigeonBackButton.Visible = false;
            this.AutoScroll = true;
        }

        private void hyssopsBackButton_Click_1(object sender, EventArgs e)
        {
            biggerImagePanel.Visible = false;
            hyssopsPictureBox.Visible = false;
            hyssopsBackButton.Visible = false;
            this.AutoScroll = true;
        }


        private void top10LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            top10LinkLabel.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=zoY0NJRDqiw");
        }

        private void animalEncountersLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            animalEncountersLinkLabel.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=2S8jV0ifyu0");
        }

        private void parcOmegaLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            parcOmegaLinkLabel.LinkVisited= true;
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=Aauci0rCJWo");
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