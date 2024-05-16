using EarthPage;
using Navigation;
using PictureVideoPage;
using PlantsPage;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace G_Navigation
{
    public partial class HomeForm : NavigationForm
    {
        private GamesForm gamesForm = new GamesForm();
        private EncyclopediaForm encyclopediaForm = new EncyclopediaForm();
        private AboutUsForm aboutUsForm = new AboutUsForm();

        private PlantsPage.FloraForm floraForm = new PlantsPage.FloraForm();
        private PlantsPage.MapsPage mapsForm = new PlantsPage.MapsPage();

        private PictureVideoPage.PictureAndVideoForm PictureAndVideoForm = new PictureVideoPage.PictureAndVideoForm();
        private EarthPage.EarthForm EarthForm = new EarthPage.EarthForm();
        private MontreWild.AnimalMainForm animalForm = new MontreWild.AnimalMainForm();

        public HomeForm()
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en");
            InitializeComponent();
            NavigationItemSelected += NavigationForm_NavigationItemSelected;
            FormManager.RegisterHomeForm(this.HomeMainPanel);
        }

        public void showPanel()
        {
            HomeMainPanel.Visible = true;
            HomeMainPanel.Show();
        }
 
        private void HomeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'montreWildDBDataSet.CombinedData' table. You can move, or remove it, as needed.
            this.combinedDataTableAdapter.Fill(this.montreWildDBDataSet.CombinedData);
        }

        private void NavigationForm_NavigationItemSelected(object sender, string destination)
        {
            // Handle navigation based on the destination
            switch (destination)
            {
                case "Home":
                    //encyclopediaForm.Dock = DockStyle.Fill;

                    gamesForm.Visible = false;
                    //this.Controls.Add(encyclopediaForm);
                    HomeMainPanel.Visible = true;
                    //animalForm.Visible = false;
                    PictureAndVideoForm.Visible = false;
                    encyclopediaForm.Visible = false;
                    mapsForm.Visible = false;
                    floraForm.Visible = false;


                    //encyclopediaForm.Show();

                    break;
                case "Encyclopedia":
                    encyclopediaForm.Dock = DockStyle.Fill;
                    gamesForm.Visible = false;
                    aboutUsForm.Visible = false;

                    this.Controls.Add(encyclopediaForm);
                    HomeMainPanel.Visible = false;
                    floraForm.Visible = false;
                    //animalForm.Visible = false;
                    PictureAndVideoForm.Visible = false;
                    mapsForm.Visible = false;

                    encyclopediaForm.Show();

                    break;
                case "Games":
                    gamesForm.Dock = DockStyle.Fill;

                    gamesForm.Visible = true;

                    HomeMainPanel.Visible = false;
                    //animalForm.Visible = false;
                    PictureAndVideoForm.Visible = false;
                    encyclopediaForm.Visible = false;
                    mapsForm.Visible = false;
                    floraForm.Visible = false;

                    this.Controls.Add(gamesForm);
                    HomeMainPanel.Visible = false;

                    gamesForm.Show();
                    break;
                case "About Us":
                    aboutUsForm.Dock = DockStyle.Fill;

                    aboutUsForm.Visible = true;

                    HomeMainPanel.Visible = false;
                    //animalForm.Visible = false;
                    gamesForm.Visible = false;
                    PictureAndVideoForm.Visible = false;
                    encyclopediaForm.Visible = false;
                    mapsForm.Visible = false;
                    floraForm.Visible = false;

                    this.Controls.Add(aboutUsForm);

                    aboutUsForm.Show();
                    break;
                case "Plants":
                    floraForm.Dock = DockStyle.Fill;

                    floraForm.Visible = true;

                    HomeMainPanel.Visible = false;

                    //animalForm.Visible = false;
                    gamesForm.Visible = false;
                    PictureAndVideoForm.Visible = false;
                    encyclopediaForm.Visible = false;
                    mapsForm.Visible = false;
                    //floraForm.Visible = false;

                    this.Controls.Add(floraForm);

                    floraForm.Show();
                    break;
            }
        }

        private void gamesButton_Click(object sender, EventArgs e)
        {
            gamesForm.Dock = DockStyle.Fill; 
            this.Controls.Add(gamesForm);
            HomeMainPanel.Visible=false;

           //animalForm.Visible = false;
            gamesForm.Visible = false;
            encyclopediaForm.Visible = false;
            PictureAndVideoForm.Visible = false;
            mapsForm.Visible = false;
            floraForm.Visible = false;
            EarthForm.Visible = false;

            gamesForm.Show();
        }

        private void Gallery_btn_Click(object sender, EventArgs e)
        {
            PictureAndVideoForm.Dock = DockStyle.Fill;

            PictureAndVideoForm.TopLevel = false;
            this.Controls.Add(PictureAndVideoForm);
            HomeMainPanel.Visible = false;

            //animalForm.Visible = false;
            gamesForm.Visible = false;
            encyclopediaForm.Visible = false;
            mapsForm.Visible = false;
            floraForm.Visible = false;
            EarthForm.Visible = false;

            PictureAndVideoForm.Show();
        }

        private void Fauna_btn_Click(object sender, EventArgs e)
        {
            animalForm.Dock = DockStyle.Fill;

            this.Controls.Add(animalForm);
            HomeMainPanel.Visible = false;

            gamesForm.Visible = false;
            PictureAndVideoForm.Visible = false;
            encyclopediaForm.Visible = false;
            mapsForm.Visible = false;
            floraForm.Visible = false;
            EarthForm.Visible = false;

            animalForm.Show();
        }

        private void Encyclopedia_btn_Click(object sender, EventArgs e)
        {
            encyclopediaForm.Dock = DockStyle.Fill;

            this.Controls.Add(encyclopediaForm);
            HomeMainPanel.Visible = false;

           // animalForm.Visible = false;
            gamesForm.Visible = false;
            PictureAndVideoForm.Visible = false;
            mapsForm.Visible = false;
            floraForm.Visible = false;
            EarthForm.Visible = false;

            encyclopediaForm.Show();
        }

        private void Maps_btn_Click(object sender, EventArgs e)
        {
            mapsForm.Dock = DockStyle.None;
            mapsForm.TopLevel = false;
            this.Controls.Add(mapsForm);
            HomeMainPanel.Visible = false;

            //animalForm.Visible = false;
            gamesForm.Visible = false;
            PictureAndVideoForm.Visible = false;
            encyclopediaForm.Visible = false;
            floraForm.Visible = false;
            EarthForm.Visible = false;

            mapsForm.Show();
        }

        private void Flora_btn_Click(object sender, EventArgs e)
        {
            floraForm.Dock = DockStyle.None;
            floraForm.TopLevel = false;
            this.Controls.Add(floraForm);
            HomeMainPanel.Visible = false;

           // animalForm.Visible = false;
            gamesForm.Visible = false;
            PictureAndVideoForm.Visible = false;
            encyclopediaForm.Visible = false;
            mapsForm.Visible = false;
            EarthForm.Visible = false;

            floraForm.Show();
        }

        private void Earth_btn_Click(object sender, EventArgs e)
        {
            EarthForm.Dock = DockStyle.Fill;
            EarthForm.TopLevel = false;
            this.Controls.Add(EarthForm);
            HomeMainPanel.Visible = false;

            //animalForm.Visible = false;
            gamesForm.Visible = false;
            PictureAndVideoForm.Visible = false;
            encyclopediaForm.Visible = false;
            mapsForm.Visible = false;
            floraForm.Visible = false;

            EarthForm.Show();
        }

        private void languagesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            var changeLanguage = new ChangingLanguages();

            switch (languagesComboBox.SelectedIndex)
            {
                case 0:
                    changeLanguage.UpdateConfig("language", "fr-CA");
                    Application.Restart();
                    break;
                case 1:
                    changeLanguage.UpdateConfig("language", "en");
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
