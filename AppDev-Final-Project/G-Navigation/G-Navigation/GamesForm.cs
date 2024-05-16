using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Navigation;

namespace G_Navigation
{
    public partial class GamesForm : Form
    {
        private Panel wonGame;
        public Button matchingLabel;
        public Button guessingLabel;

        //Game 1 = Matching game
        private PictureBox pictureSelected;
        private Button labelSelected;
        private int score;

        //Game 2 = Guessing game
        private string guessingGamePictureBoxTag;
        // Initialize counter for picture box images
        int counter = 1;


        public GamesForm()
        {
            InitializeComponent();
            this.Shown += GamesForm_Shown;

            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            matchingLabel = matchingGame;
            guessingLabel = guessingGame;

            defaultDisplay();

            score = 0;

        }

        private void GamesForm_Shown(object sender, EventArgs e)
        {
            // Update the previously visible form to be this form
            FormManager.UpdatePreviousForm(this);
        }

        private void defaultDisplay()
        {
            matchingGame.Text = "Catch the Animals!";
            guessingGame.Text = "Who's That Animal?";
        }

        private void animalGames_Click(object sender, EventArgs e)
        {
            defaultDisplay();
            guessingGame.Visible = true;

        }

        private void matchingGame_Click(object sender, EventArgs e)
        {
            mainMenuGamePanel.Visible = false;

            matchingGameMainPanel.Visible = true;

            // Array of animals
            string[] animals = { "North American Beaver", "River Otter", "Canada Goose", "Groundhog", "Raccoon", "Red Fox", "Blue-Spotted Salamander", "Pigeon" };

                    game1Label.Text = "Catch the Animals!";

                    // Shuffle the array randomly
                    shuffle(animals);

                    //Iterate through the labels to randomly assign them animal names
                    for (int i = 0; i < 8; i++)
                    {
                        // Construct the name of the label dynamically
                        string labelName = "matchLabel" + (i + 1);

                        //Control.FindControl method to find the label by name
                        Button label = this.Controls.Find(labelName, true).FirstOrDefault() as Button;

                        if (label != null)
                        {
                            //Add animal name as label Text
                            label.Text = animals[i];
                            label.ForeColor = Color.White;
                        }

                string pictureName = "matchImage" + (i + 1);

                Label pictureBox = this.Controls.Find(pictureName, true).FirstOrDefault() as Label;

                    if (pictureBox != null)
                    {
                        pictureBox.Enabled = true;
                        //Add animal name as label Text
                        label.Text = animals[i];
                    }

            }

            //Add the GamePanel to the Control
            this.Controls.Add(matchingGameMainPanel);

            //Check if you have won
            youWin(8);

        }

        // Function to shuffle array elements randomly
        static void shuffle(string[] array)
        {
            Random rand = new Random();

            int n = array.Length;
            while (n > 1)
            {
                int k = rand.Next(n--);
                string temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }
        }


        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = sender as PictureBox;

            //Check if PictureBox.Tag is equal to the Button.Text
            if (clickedPictureBox != null)
            {
                pictureSelected = clickedPictureBox;

                //If a Label has already been selected, check if they match
                if (labelSelected != null)
                {
                    //If match is true, add grey paneling to the image
                    if (checkIfMatch())
                    {
                        clickedPictureBox.Enabled = false;
                        clickedPictureBox.BorderStyle = BorderStyle.FixedSingle;
       

                        youWin(8);

                    }
                }
            }
        }

        private void label_Click(object sender, EventArgs e)
        {
            Button clickedLabel = sender as Button;


            //Check if Label.Text is equal to the PictureBox.Tag
            if (clickedLabel != null)
            {
                labelSelected = clickedLabel;

                //If a PictureBox has already been selected, check if they match
                if (pictureSelected != null)
                {
                    //If match is true, add grey paneling to the image
                    if (checkIfMatch())
                    {
                        labelSelected.ForeColor = Color.Black;
                        youWin(8);
                    }
                }

            }
        }

        private Boolean checkIfMatch()
        {
            if (pictureSelected.Tag.ToString() == labelSelected.Text)
            {
                youWin(8);

                //Increment score
                score++;

                //Display updated score
                matchGameScoreLabel.Text = score + "";

                return true;
            }
            return false;
        }

        private void MouseEnterObject(object sender, EventArgs e)
        {
            if (sender is PictureBox)
            {
                PictureBox pictureBox = sender as PictureBox;
                pictureBox.BorderStyle = BorderStyle.FixedSingle;
            }
            else if (sender is Label)
            {
                Label label = sender as Label;
                label.BorderStyle = BorderStyle.FixedSingle;
            }

            // Change cursor to Hand when mouse enters control area
            Cursor = Cursors.Hand;
        }

        private void MouseLeaveObject(object sender, EventArgs e)
        {
            if (sender is PictureBox)
            {
                PictureBox pictureBox = sender as PictureBox;
                pictureBox.BorderStyle = BorderStyle.None;
            }
            else if (sender is Label)
            {
                Label label = sender as Label;
                label.BorderStyle = BorderStyle.None;
            }

            // Change cursor back to Default when mouse leaves control area
            Cursor = Cursors.Default;
        }

        private void MouseClickObject(object sender, MouseEventArgs e)
        {
            if (sender is PictureBox)
            {
                PictureBox pictureBox = sender as PictureBox;
                pictureBox.BorderStyle = BorderStyle.FixedSingle;
            }
            else if (sender is Label)
            {
                Label label = sender as Label;
                label.BorderStyle = BorderStyle.FixedSingle;
            }

        }

        private void guessingGame_Click(object sender, EventArgs e)
        {
            //Displays the game and iterates through questions
            guessingGamePanel.Show();

            mainMenuGamePanel.Visible = false;

            //Initialize score
            score = 0;

            updateScore();
            //Update score label

            displayGuessingGame();

        }

        private void guessingGameSelectChoice(object sender, EventArgs e) {

            Label clickedLabel = sender as Label;

            // Assuming guessingGamePictureBoxTag contains the correct answer
            string correctAnswer = guessingGamePictureBoxTag;

            // Check if the player has won
            youWin(4);

            if (clickedLabel.Text == correctAnswer)
            {
                // If the selection is the correct answer
                score++; // Increment the score
                guessingGameScoreLabel.Text = score + ""; // Update the score label

                displayGuessingGame(); // Update the game display
            }

            // Check if the player has won
            youWin(4);
        }



        private void displayGuessingGame() {

            updateScore();

            // guessingGameScoreLabel.Text =  score + "";

            // Picture box
            PictureBox pictureBox = guessingGamePictureBox;

            // Array variable
            string[] categoryChoice = null;

            // Update Guessing Game header to the Game text
            guessingGameHeader.Text = guessingGame.Text;

                // Array for animal choices
                string[] animals = { "Red Fox", "River Otter", "Blue-Spotted Salamander", "Canada Goose" };

                // Array for animal choices
                string[] animalsTag = { "Red Fox", "River Otter", "Blue-Spotted Salamander", "Canada Goose" };

                // Set SizeMode property of PictureBox to StretchImage
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                // Add animals to categoryChoice array
                categoryChoice = animals;

                // Shuffle array
                shuffle(categoryChoice);

                // Display image on picture box
                if (pictureBox != null && counter <= 4) // counter starts at 1 because images start at 1
                {
                    // Add image to picture box
                    pictureBox.Image = Properties.Resources.ResourceManager.GetObject("wta" + counter) as Image;

                    // Set SizeMode property of PictureBox to StretchImage
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Tag = animalsTag[counter - 1];

                    guessingGamePictureBoxTag = pictureBox.Tag.ToString();
                }

                // Increment counter
                counter++;

            // Update label text
            for (int i = 0; i < 4; i++)
            {
                // Construct the name of the label dynamically
                string labelName = "guessingGameChoice" + (i + 1);

                // Control.FindControl method to find the label and picture box by name
                Label label = this.Controls.Find(labelName, true).FirstOrDefault() as Label;

                if (label != null && categoryChoice != null && i < categoryChoice.Length)
                {
                    // Add animal/plant name as label text
                    label.Text = categoryChoice[i];
                }
                else
                {
                    // Handle case where categoryChoice is null or not enough elements
                    label.Text = "";
                }
            }

        }


        private void gameExitClick(object sender, EventArgs e)
        {
            score = 0;

            updateScore();

            var currentVisiblePanel = GetCurrentPanel();

            currentVisiblePanel.Visible = false;

            mainMenuGamePanel.Show();

        }

        // Function to get the currently visible panel
        public Panel GetCurrentPanel()
        {
            // Iterate through all controls on the form
            foreach (Control control in this.Controls)
            {
                // Check if the control is a Panel and is currently visible
                if (control is Panel panel && panel.Visible)
                {
                    // Return the currently visible panel
                    return panel;
                }
            }

            // If no panel is found visible, return null
            return null;
        }

        public void youWin(int maxScore) {

            if (score == maxScore)
            {
                var currentVisiblePanel = GetCurrentPanel();

                // Hide the current visible panel
                currentVisiblePanel.Visible = false;

                // Store the current visible panel
                wonGame = currentVisiblePanel;

                // Show the win panel
                gameWinPanel.Visible = true;
                gameWinPanel.Show();

                // Reset counters and score for the next game
                counter = 0;
                score = 0;

            }

        }

        public void playAgainButton_Click(object sender, EventArgs e)
        {
            // Reset counters and score for the next game
            counter = 1;
            score = 0;

            updateScore();

            gameWinPanel.Visible = false;
            wonGame.Visible = true;
            wonGame.Show();
           
            
        }

        public void updateScore() {
            matchGameScoreLabel.Text = score + "";
            guessingGameScoreLabel.Text = score + "";
        }

       
    }
}
        
    







