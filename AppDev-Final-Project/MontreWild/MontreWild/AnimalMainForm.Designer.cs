namespace MontreWild
{
    partial class AnimalMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimalMainForm));
            this.mammalButton = new System.Windows.Forms.Button();
            this.birdButton = new System.Windows.Forms.Button();
            this.otherButton = new System.Windows.Forms.Button();
            this.animalsLabel = new System.Windows.Forms.Label();
            this.languageLabel = new System.Windows.Forms.Label();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mammalButton
            // 
            resources.ApplyResources(this.mammalButton, "mammalButton");
            this.mammalButton.Name = "mammalButton";
            this.mammalButton.UseVisualStyleBackColor = true;
            this.mammalButton.Click += new System.EventHandler(this.mammalButton_Click);
            // 
            // birdButton
            // 
            resources.ApplyResources(this.birdButton, "birdButton");
            this.birdButton.Name = "birdButton";
            this.birdButton.UseVisualStyleBackColor = true;
            this.birdButton.Click += new System.EventHandler(this.birdButton_Click);
            // 
            // otherButton
            // 
            resources.ApplyResources(this.otherButton, "otherButton");
            this.otherButton.Name = "otherButton";
            this.otherButton.UseVisualStyleBackColor = true;
            this.otherButton.Click += new System.EventHandler(this.otherButton_Click);
            // 
            // animalsLabel
            // 
            resources.ApplyResources(this.animalsLabel, "animalsLabel");
            this.animalsLabel.Name = "animalsLabel";
            // 
            // languageLabel
            // 
            resources.ApplyResources(this.languageLabel, "languageLabel");
            this.languageLabel.Name = "languageLabel";
            // 
            // languageComboBox
            // 
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Items.AddRange(new object[] {
            resources.GetString("languageComboBox.Items"),
            resources.GetString("languageComboBox.Items1"),
            resources.GetString("languageComboBox.Items2"),
            resources.GetString("languageComboBox.Items3")});
            resources.ApplyResources(this.languageComboBox, "languageComboBox");
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.SelectedIndexChanged += new System.EventHandler(this.languageComboBox_SelectedIndexChanged);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.languageComboBox);
            this.mainPanel.Controls.Add(this.mammalButton);
            this.mainPanel.Controls.Add(this.languageLabel);
            this.mainPanel.Controls.Add(this.birdButton);
            this.mainPanel.Controls.Add(this.animalsLabel);
            this.mainPanel.Controls.Add(this.otherButton);
            resources.ApplyResources(this.mainPanel, "mainPanel");
            this.mainPanel.Name = "mainPanel";
            // 
            // AnimalMainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.mainPanel);
            this.Name = "AnimalMainForm";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mammalButton;
        private System.Windows.Forms.Button birdButton;
        private System.Windows.Forms.Button otherButton;
        private System.Windows.Forms.Label animalsLabel;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.ComboBox languageComboBox;
        private System.Windows.Forms.Panel mainPanel;
    }
}

