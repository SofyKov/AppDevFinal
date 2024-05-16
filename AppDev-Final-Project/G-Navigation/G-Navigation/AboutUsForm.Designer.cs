namespace G_Navigation
{
    partial class AboutUsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutUsForm));
            this.aboutUsMainPanel = new System.Windows.Forms.Panel();
            this.aboutUs_ExitButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.aboutUsTextBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.creatorsLabel = new System.Windows.Forms.Label();
            this.aboutUsTitleLabel = new System.Windows.Forms.Label();
            this.aboutUsMainPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // aboutUsMainPanel
            // 
            resources.ApplyResources(this.aboutUsMainPanel, "aboutUsMainPanel");
            this.aboutUsMainPanel.Controls.Add(this.aboutUs_ExitButton);
            this.aboutUsMainPanel.Controls.Add(this.panel2);
            this.aboutUsMainPanel.Controls.Add(this.aboutUsTitleLabel);
            this.aboutUsMainPanel.Name = "aboutUsMainPanel";
            // 
            // aboutUs_ExitButton
            // 
            resources.ApplyResources(this.aboutUs_ExitButton, "aboutUs_ExitButton");
            this.aboutUs_ExitButton.Name = "aboutUs_ExitButton";
            this.aboutUs_ExitButton.UseVisualStyleBackColor = true;
            this.aboutUs_ExitButton.Click += new System.EventHandler(this.aboutUs_ExitButton_Click);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.aboutUsTextBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.creatorsLabel);
            this.panel2.Name = "panel2";
            // 
            // aboutUsTextBox
            // 
            this.aboutUsTextBox.BackColor = System.Drawing.Color.Lavender;
            this.aboutUsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.aboutUsTextBox, "aboutUsTextBox");
            this.aboutUsTextBox.Name = "aboutUsTextBox";
            this.aboutUsTextBox.ReadOnly = true;
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
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // creatorsLabel
            // 
            resources.ApplyResources(this.creatorsLabel, "creatorsLabel");
            this.creatorsLabel.Name = "creatorsLabel";
            // 
            // aboutUsTitleLabel
            // 
            this.aboutUsTitleLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            resources.ApplyResources(this.aboutUsTitleLabel, "aboutUsTitleLabel");
            this.aboutUsTitleLabel.ForeColor = System.Drawing.Color.SlateBlue;
            this.aboutUsTitleLabel.Name = "aboutUsTitleLabel";
            // 
            // AboutUsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.Controls.Add(this.aboutUsMainPanel);
            this.Name = "AboutUsForm";
            this.aboutUsMainPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel aboutUsMainPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label aboutUsTitleLabel;
        private System.Windows.Forms.Button aboutUs_ExitButton;
        private System.Windows.Forms.Label creatorsLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox aboutUsTextBox;
    }
}