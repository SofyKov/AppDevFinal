namespace EarthPage
{
    partial class EarthForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EarthForm));
            this.generalButton = new System.Windows.Forms.Button();
            this.issuesButton = new System.Windows.Forms.Button();
            this.solutionButton = new System.Windows.Forms.Button();
            this.languageLabel = new System.Windows.Forms.Label();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.generalPanel = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.generalInfoLabel = new System.Windows.Forms.Label();
            this.generalInfoTextBox = new System.Windows.Forms.RichTextBox();
            this.generalPictureBox = new System.Windows.Forms.PictureBox();
            this.issuesPanel = new System.Windows.Forms.Panel();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.infoRichTextBox = new System.Windows.Forms.RichTextBox();
            this.getInfoButton = new System.Windows.Forms.Button();
            this.issuesRichTextxBox = new System.Windows.Forms.RichTextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.issueTextBox = new System.Windows.Forms.TextBox();
            this.backButton2 = new System.Windows.Forms.Button();
            this.issuesPictureBox = new System.Windows.Forms.PictureBox();
            this.solutionsPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pollutionTextBox = new System.Windows.Forms.RichTextBox();
            this.defoTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.watertextBox = new System.Windows.Forms.RichTextBox();
            this.bioTextBox = new System.Windows.Forms.RichTextBox();
            this.climateChangeTextBox = new System.Windows.Forms.RichTextBox();
            this.backButton3 = new System.Windows.Forms.Button();
            this.earthPictureBox = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.generalPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generalPictureBox)).BeginInit();
            this.issuesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.issuesPictureBox)).BeginInit();
            this.solutionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.earthPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // generalButton
            // 
            resources.ApplyResources(this.generalButton, "generalButton");
            this.generalButton.Name = "generalButton";
            this.generalButton.UseVisualStyleBackColor = true;
            this.generalButton.Click += new System.EventHandler(this.generalButton_Click);
            // 
            // issuesButton
            // 
            resources.ApplyResources(this.issuesButton, "issuesButton");
            this.issuesButton.Name = "issuesButton";
            this.issuesButton.UseVisualStyleBackColor = true;
            this.issuesButton.Click += new System.EventHandler(this.issuesButton_Click);
            // 
            // solutionButton
            // 
            resources.ApplyResources(this.solutionButton, "solutionButton");
            this.solutionButton.Name = "solutionButton";
            this.solutionButton.UseVisualStyleBackColor = true;
            this.solutionButton.Click += new System.EventHandler(this.solutionButton_Click);
            // 
            // languageLabel
            // 
            resources.ApplyResources(this.languageLabel, "languageLabel");
            this.languageLabel.Name = "languageLabel";
            // 
            // languageComboBox
            // 
            resources.ApplyResources(this.languageComboBox, "languageComboBox");
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Items.AddRange(new object[] {
            resources.GetString("languageComboBox.Items"),
            resources.GetString("languageComboBox.Items1"),
            resources.GetString("languageComboBox.Items2"),
            resources.GetString("languageComboBox.Items3")});
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.SelectedIndexChanged += new System.EventHandler(this.languageComboBox_SelectedIndexChanged);
            // 
            // generalPanel
            // 
            resources.ApplyResources(this.generalPanel, "generalPanel");
            this.generalPanel.Controls.Add(this.backButton);
            this.generalPanel.Controls.Add(this.generalInfoLabel);
            this.generalPanel.Controls.Add(this.generalInfoTextBox);
            this.generalPanel.Controls.Add(this.generalPictureBox);
            this.generalPanel.Name = "generalPanel";
            // 
            // backButton
            // 
            resources.ApplyResources(this.backButton, "backButton");
            this.backButton.Name = "backButton";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // generalInfoLabel
            // 
            resources.ApplyResources(this.generalInfoLabel, "generalInfoLabel");
            this.generalInfoLabel.Name = "generalInfoLabel";
            // 
            // generalInfoTextBox
            // 
            resources.ApplyResources(this.generalInfoTextBox, "generalInfoTextBox");
            this.generalInfoTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.generalInfoTextBox.Name = "generalInfoTextBox";
            // 
            // generalPictureBox
            // 
            resources.ApplyResources(this.generalPictureBox, "generalPictureBox");
            this.generalPictureBox.Image = global::EarthPage.Properties.Resources.earth2;
            this.generalPictureBox.Name = "generalPictureBox";
            this.generalPictureBox.TabStop = false;
            // 
            // issuesPanel
            // 
            resources.ApplyResources(this.issuesPanel, "issuesPanel");
            this.issuesPanel.Controls.Add(this.instructionLabel);
            this.issuesPanel.Controls.Add(this.infoRichTextBox);
            this.issuesPanel.Controls.Add(this.getInfoButton);
            this.issuesPanel.Controls.Add(this.issuesRichTextxBox);
            this.issuesPanel.Controls.Add(this.searchLabel);
            this.issuesPanel.Controls.Add(this.issueTextBox);
            this.issuesPanel.Controls.Add(this.backButton2);
            this.issuesPanel.Controls.Add(this.issuesPictureBox);
            this.issuesPanel.Name = "issuesPanel";
            // 
            // instructionLabel
            // 
            resources.ApplyResources(this.instructionLabel, "instructionLabel");
            this.instructionLabel.Name = "instructionLabel";
            // 
            // infoRichTextBox
            // 
            resources.ApplyResources(this.infoRichTextBox, "infoRichTextBox");
            this.infoRichTextBox.Name = "infoRichTextBox";
            // 
            // getInfoButton
            // 
            resources.ApplyResources(this.getInfoButton, "getInfoButton");
            this.getInfoButton.Name = "getInfoButton";
            this.getInfoButton.UseVisualStyleBackColor = true;
            this.getInfoButton.Click += new System.EventHandler(this.getInfoButton_Click);
            // 
            // issuesRichTextxBox
            // 
            resources.ApplyResources(this.issuesRichTextxBox, "issuesRichTextxBox");
            this.issuesRichTextxBox.Name = "issuesRichTextxBox";
            // 
            // searchLabel
            // 
            resources.ApplyResources(this.searchLabel, "searchLabel");
            this.searchLabel.Name = "searchLabel";
            // 
            // issueTextBox
            // 
            resources.ApplyResources(this.issueTextBox, "issueTextBox");
            this.issueTextBox.Name = "issueTextBox";
            // 
            // backButton2
            // 
            resources.ApplyResources(this.backButton2, "backButton2");
            this.backButton2.Name = "backButton2";
            this.backButton2.UseVisualStyleBackColor = true;
            this.backButton2.Click += new System.EventHandler(this.backButton2_Click);
            // 
            // issuesPictureBox
            // 
            resources.ApplyResources(this.issuesPictureBox, "issuesPictureBox");
            this.issuesPictureBox.Image = global::EarthPage.Properties.Resources.earth3;
            this.issuesPictureBox.Name = "issuesPictureBox";
            this.issuesPictureBox.TabStop = false;
            // 
            // solutionsPanel
            // 
            resources.ApplyResources(this.solutionsPanel, "solutionsPanel");
            this.solutionsPanel.Controls.Add(this.label5);
            this.solutionsPanel.Controls.Add(this.label4);
            this.solutionsPanel.Controls.Add(this.label3);
            this.solutionsPanel.Controls.Add(this.label2);
            this.solutionsPanel.Controls.Add(this.pollutionTextBox);
            this.solutionsPanel.Controls.Add(this.defoTextBox);
            this.solutionsPanel.Controls.Add(this.label1);
            this.solutionsPanel.Controls.Add(this.watertextBox);
            this.solutionsPanel.Controls.Add(this.bioTextBox);
            this.solutionsPanel.Controls.Add(this.climateChangeTextBox);
            this.solutionsPanel.Controls.Add(this.backButton3);
            this.solutionsPanel.Name = "solutionsPanel";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // pollutionTextBox
            // 
            resources.ApplyResources(this.pollutionTextBox, "pollutionTextBox");
            this.pollutionTextBox.Name = "pollutionTextBox";
            // 
            // defoTextBox
            // 
            resources.ApplyResources(this.defoTextBox, "defoTextBox");
            this.defoTextBox.Name = "defoTextBox";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // watertextBox
            // 
            resources.ApplyResources(this.watertextBox, "watertextBox");
            this.watertextBox.Name = "watertextBox";
            // 
            // bioTextBox
            // 
            resources.ApplyResources(this.bioTextBox, "bioTextBox");
            this.bioTextBox.Name = "bioTextBox";
            // 
            // climateChangeTextBox
            // 
            resources.ApplyResources(this.climateChangeTextBox, "climateChangeTextBox");
            this.climateChangeTextBox.Name = "climateChangeTextBox";
            // 
            // backButton3
            // 
            resources.ApplyResources(this.backButton3, "backButton3");
            this.backButton3.Name = "backButton3";
            this.backButton3.UseVisualStyleBackColor = true;
            this.backButton3.Click += new System.EventHandler(this.backButton3_Click);
            // 
            // earthPictureBox
            // 
            resources.ApplyResources(this.earthPictureBox, "earthPictureBox");
            this.earthPictureBox.Image = global::EarthPage.Properties.Resources.earth;
            this.earthPictureBox.Name = "earthPictureBox";
            this.earthPictureBox.TabStop = false;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // EarthForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.solutionsPanel);
            this.Controls.Add(this.issuesPanel);
            this.Controls.Add(this.generalPanel);
            this.Controls.Add(this.languageComboBox);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.earthPictureBox);
            this.Controls.Add(this.solutionButton);
            this.Controls.Add(this.issuesButton);
            this.Controls.Add(this.generalButton);
            this.Controls.Add(this.label6);
            this.Name = "EarthForm";
            this.generalPanel.ResumeLayout(false);
            this.generalPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generalPictureBox)).EndInit();
            this.issuesPanel.ResumeLayout(false);
            this.issuesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.issuesPictureBox)).EndInit();
            this.solutionsPanel.ResumeLayout(false);
            this.solutionsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.earthPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button generalButton;
        private System.Windows.Forms.Button issuesButton;
        private System.Windows.Forms.Button solutionButton;
        private System.Windows.Forms.PictureBox earthPictureBox;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.ComboBox languageComboBox;
        private System.Windows.Forms.Panel generalPanel;
        private System.Windows.Forms.RichTextBox generalInfoTextBox;
        private System.Windows.Forms.PictureBox generalPictureBox;
        private System.Windows.Forms.Label generalInfoLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Panel issuesPanel;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.RichTextBox infoRichTextBox;
        private System.Windows.Forms.Button getInfoButton;
        private System.Windows.Forms.RichTextBox issuesRichTextxBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox issueTextBox;
        private System.Windows.Forms.Button backButton2;
        private System.Windows.Forms.PictureBox issuesPictureBox;
        private System.Windows.Forms.Panel solutionsPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox pollutionTextBox;
        private System.Windows.Forms.RichTextBox defoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox watertextBox;
        private System.Windows.Forms.RichTextBox bioTextBox;
        private System.Windows.Forms.RichTextBox climateChangeTextBox;
        private System.Windows.Forms.Button backButton3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}

