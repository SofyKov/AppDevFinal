namespace G_Navigation
{
    partial class EncyclopediaForm
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
            this.montreWildDBDataSet = new G_Navigation.MontreWildDBDataSet();
            this.combinedDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.combinedDataTableAdapter = new G_Navigation.MontreWildDBDataSetTableAdapters.CombinedDataTableAdapter();
            this.tableAdapterManager = new G_Navigation.MontreWildDBDataSetTableAdapters.TableAdapterManager();
            this.EncyMainPanel = new System.Windows.Forms.Panel();
            this.encySearchedListBox = new System.Windows.Forms.ListBox();
            this.encySearchButton = new System.Windows.Forms.Button();
            this.encyTextBox = new System.Windows.Forms.TextBox();
            this.encyDescPanel = new System.Windows.Forms.Panel();
            this.encyDetailsPanel = new System.Windows.Forms.Panel();
            this.encyTypeLabel = new System.Windows.Forms.Label();
            this.encyUseLabel = new System.Windows.Forms.Label();
            this.encySciLabel = new System.Windows.Forms.Label();
            this.encyEntityTypeLabel = new System.Windows.Forms.Label();
            this.encyDescriptionLabel = new System.Windows.Forms.Label();
            this.encyTitleLabel = new System.Windows.Forms.Label();
            this.combinedDataListBox = new System.Windows.Forms.ListBox();
            this.combinedDataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.encyFormLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.montreWildDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combinedDataBindingSource)).BeginInit();
            this.EncyMainPanel.SuspendLayout();
            this.encyDescPanel.SuspendLayout();
            this.encyDetailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.combinedDataBindingSource1)).BeginInit();
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
            // EncyMainPanel
            // 
            this.EncyMainPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EncyMainPanel.Controls.Add(this.encyFormLabel);
            this.EncyMainPanel.Controls.Add(this.encySearchedListBox);
            this.EncyMainPanel.Controls.Add(this.encySearchButton);
            this.EncyMainPanel.Controls.Add(this.encyTextBox);
            this.EncyMainPanel.Controls.Add(this.encyDescPanel);
            this.EncyMainPanel.Controls.Add(this.combinedDataListBox);
            this.EncyMainPanel.Location = new System.Drawing.Point(0, 48);
            this.EncyMainPanel.Name = "EncyMainPanel";
            this.EncyMainPanel.Size = new System.Drawing.Size(2420, 1372);
            this.EncyMainPanel.TabIndex = 12;
            // 
            // encySearchedListBox
            // 
            this.encySearchedListBox.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encySearchedListBox.FormattingEnabled = true;
            this.encySearchedListBox.ItemHeight = 44;
            this.encySearchedListBox.Location = new System.Drawing.Point(32, 336);
            this.encySearchedListBox.Name = "encySearchedListBox";
            this.encySearchedListBox.Size = new System.Drawing.Size(584, 884);
            this.encySearchedListBox.TabIndex = 20;
            this.encySearchedListBox.Visible = false;
            this.encySearchedListBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            this.encySearchedListBox.SelectedValueChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // encySearchButton
            // 
            this.encySearchButton.Location = new System.Drawing.Point(640, 240);
            this.encySearchButton.Name = "encySearchButton";
            this.encySearchButton.Size = new System.Drawing.Size(216, 64);
            this.encySearchButton.TabIndex = 13;
            this.encySearchButton.Text = "Search";
            this.encySearchButton.UseVisualStyleBackColor = true;
            this.encySearchButton.Click += new System.EventHandler(this.encySearchButton_Click);
            // 
            // encyTextBox
            // 
            this.encyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encyTextBox.Location = new System.Drawing.Point(32, 240);
            this.encyTextBox.Name = "encyTextBox";
            this.encyTextBox.Size = new System.Drawing.Size(584, 55);
            this.encyTextBox.TabIndex = 19;
            this.encyTextBox.TextChanged += new System.EventHandler(this.encyTextBox_TextChanged);
            // 
            // encyDescPanel
            // 
            this.encyDescPanel.AutoScroll = true;
            this.encyDescPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.encyDescPanel.Controls.Add(this.encyDetailsPanel);
            this.encyDescPanel.Controls.Add(this.encyTitleLabel);
            this.encyDescPanel.Location = new System.Drawing.Point(640, 336);
            this.encyDescPanel.Name = "encyDescPanel";
            this.encyDescPanel.Size = new System.Drawing.Size(1752, 916);
            this.encyDescPanel.TabIndex = 18;
            // 
            // encyDetailsPanel
            // 
            this.encyDetailsPanel.Controls.Add(this.encyTypeLabel);
            this.encyDetailsPanel.Controls.Add(this.encyUseLabel);
            this.encyDetailsPanel.Controls.Add(this.encySciLabel);
            this.encyDetailsPanel.Controls.Add(this.encyEntityTypeLabel);
            this.encyDetailsPanel.Controls.Add(this.encyDescriptionLabel);
            this.encyDetailsPanel.Location = new System.Drawing.Point(8, 160);
            this.encyDetailsPanel.Name = "encyDetailsPanel";
            this.encyDetailsPanel.Size = new System.Drawing.Size(1672, 1488);
            this.encyDetailsPanel.TabIndex = 20;
            // 
            // encyTypeLabel
            // 
            this.encyTypeLabel.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encyTypeLabel.Location = new System.Drawing.Point(40, 144);
            this.encyTypeLabel.Name = "encyTypeLabel";
            this.encyTypeLabel.Size = new System.Drawing.Size(592, 72);
            this.encyTypeLabel.TabIndex = 2;
            // 
            // encyUseLabel
            // 
            this.encyUseLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.encyUseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encyUseLabel.Location = new System.Drawing.Point(40, 952);
            this.encyUseLabel.Name = "encyUseLabel";
            this.encyUseLabel.Size = new System.Drawing.Size(1560, 568);
            this.encyUseLabel.TabIndex = 22;
            // 
            // encySciLabel
            // 
            this.encySciLabel.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encySciLabel.Location = new System.Drawing.Point(40, 240);
            this.encySciLabel.Name = "encySciLabel";
            this.encySciLabel.Size = new System.Drawing.Size(1032, 72);
            this.encySciLabel.TabIndex = 21;
            // 
            // encyEntityTypeLabel
            // 
            this.encyEntityTypeLabel.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encyEntityTypeLabel.Location = new System.Drawing.Point(40, 56);
            this.encyEntityTypeLabel.Name = "encyEntityTypeLabel";
            this.encyEntityTypeLabel.Size = new System.Drawing.Size(616, 64);
            this.encyEntityTypeLabel.TabIndex = 1;
            // 
            // encyDescriptionLabel
            // 
            this.encyDescriptionLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.encyDescriptionLabel.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encyDescriptionLabel.Location = new System.Drawing.Point(40, 328);
            this.encyDescriptionLabel.Name = "encyDescriptionLabel";
            this.encyDescriptionLabel.Size = new System.Drawing.Size(1592, 552);
            this.encyDescriptionLabel.TabIndex = 0;
            // 
            // encyTitleLabel
            // 
            this.encyTitleLabel.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encyTitleLabel.Location = new System.Drawing.Point(224, 40);
            this.encyTitleLabel.Name = "encyTitleLabel";
            this.encyTitleLabel.Size = new System.Drawing.Size(1160, 88);
            this.encyTitleLabel.TabIndex = 19;
            this.encyTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // combinedDataListBox
            // 
            this.combinedDataListBox.DataSource = this.combinedDataBindingSource1;
            this.combinedDataListBox.DisplayMember = "Name";
            this.combinedDataListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combinedDataListBox.FormattingEnabled = true;
            this.combinedDataListBox.ItemHeight = 48;
            this.combinedDataListBox.Location = new System.Drawing.Point(32, 336);
            this.combinedDataListBox.Name = "combinedDataListBox";
            this.combinedDataListBox.Size = new System.Drawing.Size(584, 964);
            this.combinedDataListBox.Sorted = true;
            this.combinedDataListBox.TabIndex = 17;
            this.combinedDataListBox.ValueMember = "EntityType";
            this.combinedDataListBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // combinedDataBindingSource1
            // 
            this.combinedDataBindingSource1.DataMember = "CombinedData";
            this.combinedDataBindingSource1.DataSource = this.montreWildDBDataSet;
            // 
            // encyFormLabel
            // 
            this.encyFormLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.encyFormLabel.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encyFormLabel.Location = new System.Drawing.Point(952, 112);
            this.encyFormLabel.Name = "encyFormLabel";
            this.encyFormLabel.Size = new System.Drawing.Size(752, 152);
            this.encyFormLabel.TabIndex = 21;
            this.encyFormLabel.Text = "ENCYCLOPEDIA";
            // 
            // EncyclopediaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2420, 1420);
            this.Controls.Add(this.EncyMainPanel);
            this.Name = "EncyclopediaForm";
            this.Text = "EncyclopediaForm";
            this.Load += new System.EventHandler(this.EncyclopediaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.montreWildDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combinedDataBindingSource)).EndInit();
            this.EncyMainPanel.ResumeLayout(false);
            this.EncyMainPanel.PerformLayout();
            this.encyDescPanel.ResumeLayout(false);
            this.encyDetailsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.combinedDataBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MontreWildDBDataSet montreWildDBDataSet;
        private System.Windows.Forms.BindingSource combinedDataBindingSource;
        private MontreWildDBDataSetTableAdapters.CombinedDataTableAdapter combinedDataTableAdapter;
        private MontreWildDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel EncyMainPanel;
        private System.Windows.Forms.ListBox combinedDataListBox;
        private System.Windows.Forms.BindingSource combinedDataBindingSource1;
        private System.Windows.Forms.Panel encyDescPanel;
        private System.Windows.Forms.Panel encyDetailsPanel;
        private System.Windows.Forms.Label encyTitleLabel;
        private System.Windows.Forms.Button encySearchButton;
        private System.Windows.Forms.TextBox encyTextBox;
        private System.Windows.Forms.ListBox encySearchedListBox;
        private System.Windows.Forms.Label encyEntityTypeLabel;
        private System.Windows.Forms.Label encyDescriptionLabel;
        private System.Windows.Forms.Label encyTypeLabel;
        private System.Windows.Forms.Label encySciLabel;
        private System.Windows.Forms.Label encyUseLabel;
        private System.Windows.Forms.Label encyFormLabel;
    }
}