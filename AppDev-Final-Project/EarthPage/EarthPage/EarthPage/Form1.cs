using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EarthPage
{
    public partial class EarthForm : Form
    {
        public EarthForm()
        {
            InitializeComponent();
        }

        private void generalButton_Click(object sender, EventArgs e)
        {
            generalPanel.Visible = true;
        }


        private void issuesButton_Click(object sender, EventArgs e)
        {
            issuesPanel.Visible = true;
        }

        private void solutionButton_Click(object sender, EventArgs e)
        {
            solutionsPanel.Visible = true;
        }



        private void languageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var changeLanguage = new ChangeLanguages();

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

       
        private void getInfoButton_Click(object sender, EventArgs e)
        {
            var issue = issueTextBox.Text;
            switch (issue)
            {
                case "CLIMATE CHANGE":
                    infoRichTextBox.Text = "Climate change refers to the long-term alteration of temperature and typical weather patterns in a region, primarily caused by human activities such as burning fossil fuels, deforestation, and industrial processes. This results in rising global temperatures, leading to more frequent and severe extreme weather events like hurricanes, droughts, and heatwaves. Additionally, climate change causes disruptions to ecosystems and threatens biodiversity, agriculture, and human societies. Urgent action is required to mitigate greenhouse gas emissions, transition to renewable energy sources, and adapt to the impacts of climate change to safeguard the planet and future generations.";
                    break;
                case "BIODIVERSITY LOSS":
                    infoRichTextBox.Text = "Biodiversity loss refers to the rapid decline of species and ecosystems due to habitat destruction, pollution, overexploitation of natural resources, and climate change. This loss threatens the stability and resilience of ecosystems, the services they provide to humans (such as clean air and water, pollination, and climate regulation), and the survival of countless species. Conservation efforts, sustainable land management practices, protected areas, and international cooperation are essential to halt and reverse biodiversity loss and preserve Earth's natural heritage.";
                    break;
                case "WATER SCARCITY":
                    infoRichTextBox.Text = "Water scarcity occurs when the demand for freshwater exceeds the available supply in a region due to factors such as population growth, pollution, climate change, and unsustainable water management practices. This scarcity threatens freshwater ecosystems, agricultural production, and access to clean water for drinking, sanitation, and hygiene. Sustainable water management, water conservation measures, investment in water infrastructure, and equitable distribution of water resources are essential to address water scarcity and ensure water security for all.";
                    break;
                case "DEFORESTATION":
                    infoRichTextBox.Text = "Deforestation is the clearing of forests for agricultural expansion, logging, urbanization, and other purposes, leading to the loss of biodiversity, habitat destruction, soil erosion, and carbon emissions. Deforestation also reduces the capacity of forests to absorb carbon dioxide, exacerbating climate change. Sustainable forest management, reforestation efforts, protected areas, and policies to combat illegal logging are crucial to preserve forests, mitigate climate change, and maintain the ecological integrity of landscapes.";
                    break;
                case "POLLUTION":
                    infoRichTextBox.Text = "Pollution refers to the introduction of harmful substances or contaminants into the environment, including air, water, and soil, as a result of human activities such as industrial processes, transportation, agriculture, and waste disposal. Pollution harms ecosystems, wildlife, and human health, leading to respiratory diseases, waterborne illnesses, and ecological imbalances. Efforts to reduce pollution include implementing clean technologies, improving waste management practices, enforcing environmental regulations, and promoting sustainable consumption and production patterns to protect the environment and public health.\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
                    break;
            }
        }

       

        private void backButton_Click(object sender, EventArgs e)
        {
            generalPanel.Visible = false;
        }

        private void backButton2_Click(object sender, EventArgs e)
        {
            issuesPanel.Visible = false;
        }

        private void backButton3_Click(object sender, EventArgs e)
        {
            solutionsPanel.Visible = false;
        }
    }
}
