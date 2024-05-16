namespace PlantsPage
{
    partial class ShrubsPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShrubsPage));
            this.plantsPanel = new System.Windows.Forms.Panel();
            this.sciPlantName_lbl = new System.Windows.Forms.Label();
            this.next_btn = new System.Windows.Forms.Button();
            this.prev_btn = new System.Windows.Forms.Button();
            this.plantName_lbl = new System.Windows.Forms.Label();
            this.plantUse_lbl = new System.Windows.Forms.Label();
            this.plantUse_richTBox = new System.Windows.Forms.RichTextBox();
            this.description_richTBox = new System.Windows.Forms.RichTextBox();
            this.plantsPictureBox = new System.Windows.Forms.PictureBox();
            this.plantsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plantsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // plantsPanel
            // 
            this.plantsPanel.Controls.Add(this.sciPlantName_lbl);
            this.plantsPanel.Controls.Add(this.next_btn);
            this.plantsPanel.Controls.Add(this.prev_btn);
            this.plantsPanel.Controls.Add(this.plantName_lbl);
            this.plantsPanel.Controls.Add(this.plantUse_lbl);
            this.plantsPanel.Controls.Add(this.plantUse_richTBox);
            this.plantsPanel.Controls.Add(this.description_richTBox);
            this.plantsPanel.Controls.Add(this.plantsPictureBox);
            resources.ApplyResources(this.plantsPanel, "plantsPanel");
            this.plantsPanel.Name = "plantsPanel";
            // 
            // sciPlantName_lbl
            // 
            resources.ApplyResources(this.sciPlantName_lbl, "sciPlantName_lbl");
            this.sciPlantName_lbl.Name = "sciPlantName_lbl";
            // 
            // next_btn
            // 
            resources.ApplyResources(this.next_btn, "next_btn");
            this.next_btn.Name = "next_btn";
            this.next_btn.UseVisualStyleBackColor = true;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // prev_btn
            // 
            resources.ApplyResources(this.prev_btn, "prev_btn");
            this.prev_btn.Name = "prev_btn";
            this.prev_btn.UseVisualStyleBackColor = true;
            this.prev_btn.Click += new System.EventHandler(this.prev_btn_Click);
            // 
            // plantName_lbl
            // 
            resources.ApplyResources(this.plantName_lbl, "plantName_lbl");
            this.plantName_lbl.Name = "plantName_lbl";
            // 
            // plantUse_lbl
            // 
            resources.ApplyResources(this.plantUse_lbl, "plantUse_lbl");
            this.plantUse_lbl.Name = "plantUse_lbl";
            // 
            // plantUse_richTBox
            // 
            this.plantUse_richTBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.plantUse_richTBox, "plantUse_richTBox");
            this.plantUse_richTBox.Name = "plantUse_richTBox";
            // 
            // description_richTBox
            // 
            this.description_richTBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.description_richTBox, "description_richTBox");
            this.description_richTBox.Name = "description_richTBox";
            this.description_richTBox.ReadOnly = true;
            // 
            // plantsPictureBox
            // 
            resources.ApplyResources(this.plantsPictureBox, "plantsPictureBox");
            this.plantsPictureBox.Name = "plantsPictureBox";
            this.plantsPictureBox.TabStop = false;
            // 
            // ShrubsPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.plantsPanel);
            this.Name = "ShrubsPage";
            this.plantsPanel.ResumeLayout(false);
            this.plantsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plantsPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plantsPanel;
        private System.Windows.Forms.Label sciPlantName_lbl;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.Button prev_btn;
        private System.Windows.Forms.Label plantName_lbl;
        private System.Windows.Forms.Label plantUse_lbl;
        private System.Windows.Forms.RichTextBox plantUse_richTBox;
        private System.Windows.Forms.RichTextBox description_richTBox;
        private System.Windows.Forms.PictureBox plantsPictureBox;
    }
}