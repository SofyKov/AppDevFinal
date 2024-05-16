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
            this.HomeMainPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button9 = new System.Windows.Forms.Button();
            this.Maps_btn = new System.Windows.Forms.Button();
            this.Encyclopedia_btn = new System.Windows.Forms.Button();
            this.Fauna_btn = new System.Windows.Forms.Button();
            this.gamesButton = new System.Windows.Forms.Button();
            this.Gallery_btn = new System.Windows.Forms.Button();
            this.Flora_btn = new System.Windows.Forms.Button();
            this.montreWildDBDataSet = new G_Navigation.MontreWildDBDataSet();
            this.combinedDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.combinedDataTableAdapter = new G_Navigation.MontreWildDBDataSetTableAdapters.CombinedDataTableAdapter();
            this.tableAdapterManager = new G_Navigation.MontreWildDBDataSetTableAdapters.TableAdapterManager();
            this.combinedDataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.combinedDataBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.Earth_btn = new System.Windows.Forms.Button();
            this.HomeMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.montreWildDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combinedDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combinedDataBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combinedDataBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // HomeMainPanel
            // 
            this.HomeMainPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.HomeMainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HomeMainPanel.BackgroundImage")));
            this.HomeMainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HomeMainPanel.Controls.Add(this.Earth_btn);
            this.HomeMainPanel.Controls.Add(this.pictureBox1);
            this.HomeMainPanel.Controls.Add(this.button9);
            this.HomeMainPanel.Controls.Add(this.Maps_btn);
            this.HomeMainPanel.Controls.Add(this.Encyclopedia_btn);
            this.HomeMainPanel.Controls.Add(this.Fauna_btn);
            this.HomeMainPanel.Controls.Add(this.gamesButton);
            this.HomeMainPanel.Controls.Add(this.Gallery_btn);
            this.HomeMainPanel.Controls.Add(this.Flora_btn);
            this.HomeMainPanel.Location = new System.Drawing.Point(0, 65);
            this.HomeMainPanel.Margin = new System.Windows.Forms.Padding(1);
            this.HomeMainPanel.Name = "HomeMainPanel";
            this.HomeMainPanel.Size = new System.Drawing.Size(1042, 523);
            this.HomeMainPanel.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(288, 180);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(472, 173);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(987, 524);
            this.button9.Margin = new System.Windows.Forms.Padding(1);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(41, 29);
            this.button9.TabIndex = 17;
            this.button9.Text = "FRE";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // Maps_btn
            // 
            this.Maps_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Maps_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Maps_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Maps_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Maps_btn.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Maps_btn.Location = new System.Drawing.Point(33, 404);
            this.Maps_btn.Margin = new System.Windows.Forms.Padding(1);
            this.Maps_btn.Name = "Maps_btn";
            this.Maps_btn.Size = new System.Drawing.Size(240, 90);
            this.Maps_btn.TabIndex = 16;
            this.Maps_btn.Text = "MAPS";
            this.Maps_btn.UseVisualStyleBackColor = true;
            this.Maps_btn.Click += new System.EventHandler(this.Maps_btn_Click);
            // 
            // Encyclopedia_btn
            // 
            this.Encyclopedia_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Encyclopedia_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Thistle;
            this.Encyclopedia_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Thistle;
            this.Encyclopedia_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Encyclopedia_btn.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Encyclopedia_btn.Location = new System.Drawing.Point(33, 222);
            this.Encyclopedia_btn.Margin = new System.Windows.Forms.Padding(1);
            this.Encyclopedia_btn.Name = "Encyclopedia_btn";
            this.Encyclopedia_btn.Size = new System.Drawing.Size(240, 90);
            this.Encyclopedia_btn.TabIndex = 15;
            this.Encyclopedia_btn.Text = "ENCYCLOPEDIA";
            this.Encyclopedia_btn.UseVisualStyleBackColor = true;
            this.Encyclopedia_btn.Click += new System.EventHandler(this.Encyclopedia_btn_Click);
            // 
            // Fauna_btn
            // 
            this.Fauna_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Fauna_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Fauna_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Fauna_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fauna_btn.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fauna_btn.Location = new System.Drawing.Point(33, 42);
            this.Fauna_btn.Margin = new System.Windows.Forms.Padding(1);
            this.Fauna_btn.Name = "Fauna_btn";
            this.Fauna_btn.Size = new System.Drawing.Size(240, 90);
            this.Fauna_btn.TabIndex = 14;
            this.Fauna_btn.Text = "FAUNA";
            this.Fauna_btn.UseVisualStyleBackColor = true;
            this.Fauna_btn.Click += new System.EventHandler(this.Fauna_btn_Click);
            // 
            // gamesButton
            // 
            this.gamesButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.gamesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gamesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gamesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gamesButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamesButton.Location = new System.Drawing.Point(776, 402);
            this.gamesButton.Margin = new System.Windows.Forms.Padding(1);
            this.gamesButton.Name = "gamesButton";
            this.gamesButton.Size = new System.Drawing.Size(240, 90);
            this.gamesButton.TabIndex = 13;
            this.gamesButton.Text = "GAMES";
            this.gamesButton.UseVisualStyleBackColor = true;
            this.gamesButton.Click += new System.EventHandler(this.gamesButton_Click);
            // 
            // Gallery_btn
            // 
            this.Gallery_btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Gallery_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.Gallery_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.Gallery_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Gallery_btn.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gallery_btn.Location = new System.Drawing.Point(776, 222);
            this.Gallery_btn.Margin = new System.Windows.Forms.Padding(1);
            this.Gallery_btn.Name = "Gallery_btn";
            this.Gallery_btn.Size = new System.Drawing.Size(240, 90);
            this.Gallery_btn.TabIndex = 12;
            this.Gallery_btn.Text = "GALLERY";
            this.Gallery_btn.UseVisualStyleBackColor = true;
            this.Gallery_btn.Click += new System.EventHandler(this.Gallery_btn_Click);
            // 
            // Flora_btn
            // 
            this.Flora_btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Flora_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Flora_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Honeydew;
            this.Flora_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew;
            this.Flora_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Flora_btn.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Flora_btn.Location = new System.Drawing.Point(776, 42);
            this.Flora_btn.Margin = new System.Windows.Forms.Padding(1);
            this.Flora_btn.Name = "Flora_btn";
            this.Flora_btn.Size = new System.Drawing.Size(240, 90);
            this.Flora_btn.TabIndex = 11;
            this.Flora_btn.Text = "FLORA";
            this.Flora_btn.UseVisualStyleBackColor = false;
            this.Flora_btn.Click += new System.EventHandler(this.Flora_btn_Click);
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
            // Earth_btn
            // 
            this.Earth_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Earth_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Earth_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Earth_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Earth_btn.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Earth_btn.Location = new System.Drawing.Point(420, 404);
            this.Earth_btn.Margin = new System.Windows.Forms.Padding(1);
            this.Earth_btn.Name = "Earth_btn";
            this.Earth_btn.Size = new System.Drawing.Size(240, 90);
            this.Earth_btn.TabIndex = 19;
            this.Earth_btn.Text = "EARTH";
            this.Earth_btn.UseVisualStyleBackColor = true;
            this.Earth_btn.Click += new System.EventHandler(this.Earth_btn_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1042, 585);
            this.Controls.Add(this.HomeMainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "HomeForm";
            this.Text = "MontreWild - Main Page";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.Controls.SetChildIndex(this.HomeMainPanel, 0);
            this.HomeMainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.montreWildDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combinedDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combinedDataBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combinedDataBindingSource2)).EndInit();
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
    }
}

