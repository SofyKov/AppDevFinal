namespace G_Navigation
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.montreWildDBDataSet = new G_Navigation.MontreWildDBDataSet();
            this.combinedDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.combinedDataTableAdapter = new G_Navigation.MontreWildDBDataSetTableAdapters.CombinedDataTableAdapter();
            this.tableAdapterManager = new G_Navigation.MontreWildDBDataSetTableAdapters.TableAdapterManager();
            this.combinedDataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.combinedDataBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.HomeMainPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.languagesComboBox = new System.Windows.Forms.ComboBox();
            this.Earth_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button9 = new System.Windows.Forms.Button();
            this.Maps_btn = new System.Windows.Forms.Button();
            this.Encyclopedia_btn = new System.Windows.Forms.Button();
            this.Fauna_btn = new System.Windows.Forms.Button();
            this.gamesButton = new System.Windows.Forms.Button();
            this.Gallery_btn = new System.Windows.Forms.Button();
            this.Flora_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.montreWildDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combinedDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combinedDataBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combinedDataBindingSource2)).BeginInit();
            this.HomeMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // montreWildDBDataSet
            // 
            this.montreWildDBDataSet.DataSetName = "MontreWildDBDataSet";
            this.montreWildDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // combinedDataBindingSource
            // 
            this.combinedDataBindingSource.DataMember = "CombinedData";
            this.combinedDataBindingSource.DataSource = this.montreWildDBDataSet;
            // 
            // combinedDataTableAdapter
            // 
            this.combinedDataTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AnimalTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.MapTableAdapter = null;
            this.tableAdapterManager.PlantTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = G_Navigation.MontreWildDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // combinedDataBindingSource1
            // 
            this.combinedDataBindingSource1.DataMember = "CombinedData";
            this.combinedDataBindingSource1.DataSource = this.montreWildDBDataSet;
            // 
            // combinedDataBindingSource2
            // 
            this.combinedDataBindingSource2.DataMember = "CombinedData";
            this.combinedDataBindingSource2.DataSource = this.montreWildDBDataSet;
            // 
            // HomeMainPanel
            // 
            this.HomeMainPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.HomeMainPanel, "HomeMainPanel");
            this.HomeMainPanel.Controls.Add(this.label1);
            this.HomeMainPanel.Controls.Add(this.languagesComboBox);
            this.HomeMainPanel.Controls.Add(this.Earth_btn);
            this.HomeMainPanel.Controls.Add(this.pictureBox1);
            this.HomeMainPanel.Controls.Add(this.button9);
            this.HomeMainPanel.Controls.Add(this.Maps_btn);
            this.HomeMainPanel.Controls.Add(this.Encyclopedia_btn);
            this.HomeMainPanel.Controls.Add(this.Fauna_btn);
            this.HomeMainPanel.Controls.Add(this.gamesButton);
            this.HomeMainPanel.Controls.Add(this.Gallery_btn);
            this.HomeMainPanel.Controls.Add(this.Flora_btn);
            this.HomeMainPanel.Name = "HomeMainPanel";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // languagesComboBox
            // 
            this.languagesComboBox.FormattingEnabled = true;
            this.languagesComboBox.Items.AddRange(new object[] {
            resources.GetString("languagesComboBox.Items"),
            resources.GetString("languagesComboBox.Items1"),
            resources.GetString("languagesComboBox.Items2"),
            resources.GetString("languagesComboBox.Items3")});
            resources.ApplyResources(this.languagesComboBox, "languagesComboBox");
            this.languagesComboBox.Name = "languagesComboBox";
            this.languagesComboBox.SelectedIndexChanged += new System.EventHandler(this.languagesComboBox_SelectedIndexChanged);
            // 
            // Earth_btn
            // 
            resources.ApplyResources(this.Earth_btn, "Earth_btn");
            this.Earth_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Earth_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Earth_btn.Name = "Earth_btn";
            this.Earth_btn.UseVisualStyleBackColor = true;
            this.Earth_btn.Click += new System.EventHandler(this.Earth_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // button9
            // 
            resources.ApplyResources(this.button9, "button9");
            this.button9.Name = "button9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // Maps_btn
            // 
            resources.ApplyResources(this.Maps_btn, "Maps_btn");
            this.Maps_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Maps_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Maps_btn.Name = "Maps_btn";
            this.Maps_btn.UseVisualStyleBackColor = true;
            this.Maps_btn.Click += new System.EventHandler(this.Maps_btn_Click);
            // 
            // Encyclopedia_btn
            // 
            resources.ApplyResources(this.Encyclopedia_btn, "Encyclopedia_btn");
            this.Encyclopedia_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Thistle;
            this.Encyclopedia_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Thistle;
            this.Encyclopedia_btn.Name = "Encyclopedia_btn";
            this.Encyclopedia_btn.UseVisualStyleBackColor = true;
            this.Encyclopedia_btn.Click += new System.EventHandler(this.Encyclopedia_btn_Click);
            // 
            // Fauna_btn
            // 
            resources.ApplyResources(this.Fauna_btn, "Fauna_btn");
            this.Fauna_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Fauna_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Fauna_btn.Name = "Fauna_btn";
            this.Fauna_btn.UseVisualStyleBackColor = true;
            this.Fauna_btn.Click += new System.EventHandler(this.Fauna_btn_Click);
            // 
            // gamesButton
            // 
            resources.ApplyResources(this.gamesButton, "gamesButton");
            this.gamesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gamesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gamesButton.Name = "gamesButton";
            this.gamesButton.UseVisualStyleBackColor = true;
            this.gamesButton.Click += new System.EventHandler(this.gamesButton_Click);
            // 
            // Gallery_btn
            // 
            resources.ApplyResources(this.Gallery_btn, "Gallery_btn");
            this.Gallery_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.Gallery_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.Gallery_btn.Name = "Gallery_btn";
            this.Gallery_btn.UseVisualStyleBackColor = true;
            this.Gallery_btn.Click += new System.EventHandler(this.Gallery_btn_Click);
            // 
            // Flora_btn
            // 
            resources.ApplyResources(this.Flora_btn, "Flora_btn");
            this.Flora_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Flora_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Honeydew;
            this.Flora_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew;
            this.Flora_btn.Name = "Flora_btn";
            this.Flora_btn.UseVisualStyleBackColor = false;
            this.Flora_btn.Click += new System.EventHandler(this.Flora_btn_Click);
            // 
            // HomeForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.HomeMainPanel);
            this.Name = "HomeForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.Controls.SetChildIndex(this.HomeMainPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.montreWildDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combinedDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combinedDataBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combinedDataBindingSource2)).EndInit();
            this.HomeMainPanel.ResumeLayout(false);
            this.HomeMainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel HomeMainPanel;
        private System.Windows.Forms.Button Flora_btn;
        private System.Windows.Forms.Button gamesButton;
        private System.Windows.Forms.Button Gallery_btn;
        private System.Windows.Forms.Button Maps_btn;
        private System.Windows.Forms.Button Encyclopedia_btn;
        private System.Windows.Forms.Button Fauna_btn;
        private System.Windows.Forms.Button button9;
        private MontreWildDBDataSet montreWildDBDataSet;
        private System.Windows.Forms.BindingSource combinedDataBindingSource;
        private MontreWildDBDataSetTableAdapters.CombinedDataTableAdapter combinedDataTableAdapter;
        private MontreWildDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource combinedDataBindingSource1;
        private System.Windows.Forms.BindingSource combinedDataBindingSource2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Earth_btn;
        private System.Windows.Forms.ComboBox languagesComboBox;
        private System.Windows.Forms.Label label1;
    }
}

