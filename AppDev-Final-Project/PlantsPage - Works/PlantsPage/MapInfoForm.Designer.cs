namespace PlantsPage
{
    partial class MapInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapInfoForm));
            this.animalsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.plantsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.animal_lbl = new System.Windows.Forms.Label();
            this.plat_lbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // animalsRichTextBox
            // 
            resources.ApplyResources(this.animalsRichTextBox, "animalsRichTextBox");
            this.animalsRichTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.animalsRichTextBox.Name = "animalsRichTextBox";
            this.animalsRichTextBox.ReadOnly = true;
            // 
            // plantsRichTextBox
            // 
            resources.ApplyResources(this.plantsRichTextBox, "plantsRichTextBox");
            this.plantsRichTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.plantsRichTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.plantsRichTextBox.Name = "plantsRichTextBox";
            this.plantsRichTextBox.ReadOnly = true;
            // 
            // animal_lbl
            // 
            resources.ApplyResources(this.animal_lbl, "animal_lbl");
            this.animal_lbl.BackColor = System.Drawing.Color.Transparent;
            this.animal_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.animal_lbl.ForeColor = System.Drawing.Color.IndianRed;
            this.animal_lbl.Name = "animal_lbl";
            // 
            // plat_lbl
            // 
            resources.ApplyResources(this.plat_lbl, "plat_lbl");
            this.plat_lbl.BackColor = System.Drawing.Color.Transparent;
            this.plat_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plat_lbl.ForeColor = System.Drawing.Color.IndianRed;
            this.plat_lbl.Name = "plat_lbl";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // MapInfoForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.animal_lbl);
            this.Controls.Add(this.plat_lbl);
            this.Controls.Add(this.plantsRichTextBox);
            this.Controls.Add(this.animalsRichTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MapInfoForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox animalsRichTextBox;
        private System.Windows.Forms.RichTextBox plantsRichTextBox;
        private System.Windows.Forms.Label animal_lbl;
        private System.Windows.Forms.Label plat_lbl;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}