namespace Navigation
{
    partial class NavigationForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.aboutUsLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.goToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encyclopediaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.montreWildDBDataSet = new Navigation.MontreWildDBDataSet();
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalTableAdapter = new Navigation.MontreWildDBDataSetTableAdapters.AnimalTableAdapter();
            this.tableAdapterManager = new Navigation.MontreWildDBDataSetTableAdapters.TableAdapterManager();
            this.plantTableAdapter = new Navigation.MontreWildDBDataSetTableAdapters.PlantTableAdapter();
            this.plantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.navHomeLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.montreWildDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.navHomeLabel);
            this.panel1.Controls.Add(this.aboutUsLabel);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1042, 67);
            this.panel1.TabIndex = 11;
            // 
            // aboutUsLabel
            // 
            this.aboutUsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aboutUsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutUsLabel.Location = new System.Drawing.Point(881, 18);
            this.aboutUsLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.aboutUsLabel.Name = "aboutUsLabel";
            this.aboutUsLabel.Size = new System.Drawing.Size(123, 36);
            this.aboutUsLabel.TabIndex = 8;
            this.aboutUsLabel.Text = "ABOUT US";
            this.aboutUsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.aboutUsLabel.Click += new System.EventHandler(this.aboutUsLabel_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goToToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(243, 18);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(13, 4, 13, 4);
            this.menuStrip1.Size = new System.Drawing.Size(97, 33);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "navMenuStrip";
            // 
            // goToToolStripMenuItem
            // 
            this.goToToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.goToToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.animalsToolStripMenuItem,
            this.plantsToolStripMenuItem,
            this.encyclopediaToolStripMenuItem,
            this.gamesToolStripMenuItem});
            this.goToToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.goToToolStripMenuItem.ImageTransparentColor = System.Drawing.SystemColors.ActiveCaption;
            this.goToToolStripMenuItem.Name = "goToToolStripMenuItem";
            this.goToToolStripMenuItem.Size = new System.Drawing.Size(69, 25);
            this.goToToolStripMenuItem.Text = "GO TO";
            // 
            // animalsToolStripMenuItem
            // 
            this.animalsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.animalsToolStripMenuItem.Name = "animalsToolStripMenuItem";
            this.animalsToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.animalsToolStripMenuItem.Text = "Animals";
            this.animalsToolStripMenuItem.Click += new System.EventHandler(this.animalsToolStripMenuItem_Click);
            // 
            // plantsToolStripMenuItem
            // 
            this.plantsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.plantsToolStripMenuItem.Name = "plantsToolStripMenuItem";
            this.plantsToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.plantsToolStripMenuItem.Text = "Plants";
            this.plantsToolStripMenuItem.Click += new System.EventHandler(this.plantsToolStripMenuItem_Click);
            // 
            // encyclopediaToolStripMenuItem
            // 
            this.encyclopediaToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.encyclopediaToolStripMenuItem.Name = "encyclopediaToolStripMenuItem";
            this.encyclopediaToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.encyclopediaToolStripMenuItem.Text = "Encyclopedia";
            this.encyclopediaToolStripMenuItem.Click += new System.EventHandler(this.encyclopediaToolStripMenuItem_Click);
            // 
            // gamesToolStripMenuItem
            // 
            this.gamesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gamesToolStripMenuItem.Name = "gamesToolStripMenuItem";
            this.gamesToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.gamesToolStripMenuItem.Text = "Games";
            this.gamesToolStripMenuItem.Click += new System.EventHandler(this.gamesToolStripMenuItem_Click);
            // 
            // montreWildDBDataSet
            // 
            this.montreWildDBDataSet.DataSetName = "MontreWildDBDataSet";
            this.montreWildDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // animalBindingSource
            // 
            this.animalBindingSource.DataMember = "Animal";
            this.animalBindingSource.DataSource = this.montreWildDBDataSet;
            // 
            // animalTableAdapter
            // 
            this.animalTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AnimalTableAdapter = this.animalTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MapTableAdapter = null;
            this.tableAdapterManager.PlantTableAdapter = this.plantTableAdapter;
            this.tableAdapterManager.UpdateOrder = Navigation.MontreWildDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // plantTableAdapter
            // 
            this.plantTableAdapter.ClearBeforeFill = true;
            // 
            // plantBindingSource
            // 
            this.plantBindingSource.DataMember = "Plant";
            this.plantBindingSource.DataSource = this.montreWildDBDataSet;
            // 
            // navHomeLabel
            // 
            this.navHomeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.navHomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.navHomeLabel.Image = global::Navigation.Properties.Resources.smallLogo;
            this.navHomeLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navHomeLabel.Location = new System.Drawing.Point(14, 18);
            this.navHomeLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.navHomeLabel.MaximumSize = new System.Drawing.Size(206, 36);
            this.navHomeLabel.Name = "navHomeLabel";
            this.navHomeLabel.Size = new System.Drawing.Size(206, 36);
            this.navHomeLabel.TabIndex = 9;
            this.navHomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navHomeLabel.Click += new System.EventHandler(this.navHomeLabel_Click);
            // 
            // NavigationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1042, 476);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "NavigationForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.montreWildDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label navHomeLabel;
        private System.Windows.Forms.Label aboutUsLabel;
        private MontreWildDBDataSet montreWildDBDataSet;
        private System.Windows.Forms.BindingSource animalBindingSource;
        private MontreWildDBDataSetTableAdapters.AnimalTableAdapter animalTableAdapter;
        private MontreWildDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private MontreWildDBDataSetTableAdapters.PlantTableAdapter plantTableAdapter;
        private System.Windows.Forms.BindingSource plantBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem goToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem animalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encyclopediaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gamesToolStripMenuItem;
    }
}

