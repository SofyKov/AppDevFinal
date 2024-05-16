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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EncyclopediaForm));
            this.montreWildDBDataSet = new G_Navigation.MontreWildDBDataSet();
            this.combinedDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.combinedDataTableAdapter = new G_Navigation.MontreWildDBDataSetTableAdapters.CombinedDataTableAdapter();
            this.tableAdapterManager = new G_Navigation.MontreWildDBDataSetTableAdapters.TableAdapterManager();
            this.EncyMainPanel = new System.Windows.Forms.Panel();
            this.encyFormLabel = new System.Windows.Forms.Label();
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
            resources.ApplyResources(this.EncyMainPanel, "EncyMainPanel");
            this.EncyMainPanel.Name = "EncyMainPanel";
            // 
            // encyFormLabel
            // 
            resources.ApplyResources(this.encyFormLabel, "encyFormLabel");
            this.encyFormLabel.Name = "encyFormLabel";
            // 
            // encySearchedListBox
            // 
            resources.ApplyResources(this.encySearchedListBox, "encySearchedListBox");
            this.encySearchedListBox.FormattingEnabled = true;
            this.encySearchedListBox.Name = "encySearchedListBox";
            this.encySearchedListBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            this.encySearchedListBox.SelectedValueChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // encySearchButton
            // 
            resources.ApplyResources(this.encySearchButton, "encySearchButton");
            this.encySearchButton.Name = "encySearchButton";
            this.encySearchButton.UseVisualStyleBackColor = true;
            this.encySearchButton.Click += new System.EventHandler(this.encySearchButton_Click);
            // 
            // encyTextBox
            // 
            resources.ApplyResources(this.encyTextBox, "encyTextBox");
            this.encyTextBox.Name = "encyTextBox";
            this.encyTextBox.TextChanged += new System.EventHandler(this.encyTextBox_TextChanged);
            // 
            // encyDescPanel
            // 
            resources.ApplyResources(this.encyDescPanel, "encyDescPanel");
            this.encyDescPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.encyDescPanel.Controls.Add(this.encyDetailsPanel);
            this.encyDescPanel.Controls.Add(this.encyTitleLabel);
            this.encyDescPanel.Name = "encyDescPanel";
            // 
            // encyDetailsPanel
            // 
            this.encyDetailsPanel.Controls.Add(this.encyTypeLabel);
            this.encyDetailsPanel.Controls.Add(this.encyUseLabel);
            this.encyDetailsPanel.Controls.Add(this.encySciLabel);
            this.encyDetailsPanel.Controls.Add(this.encyEntityTypeLabel);
            this.encyDetailsPanel.Controls.Add(this.encyDescriptionLabel);
            resources.ApplyResources(this.encyDetailsPanel, "encyDetailsPanel");
            this.encyDetailsPanel.Name = "encyDetailsPanel";
            // 
            // encyTypeLabel
            // 
            resources.ApplyResources(this.encyTypeLabel, "encyTypeLabel");
            this.encyTypeLabel.Name = "encyTypeLabel";
            // 
            // encyUseLabel
            // 
            this.encyUseLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.encyUseLabel, "encyUseLabel");
            this.encyUseLabel.Name = "encyUseLabel";
            // 
            // encySciLabel
            // 
            resources.ApplyResources(this.encySciLabel, "encySciLabel");
            this.encySciLabel.Name = "encySciLabel";
            // 
            // encyEntityTypeLabel
            // 
            resources.ApplyResources(this.encyEntityTypeLabel, "encyEntityTypeLabel");
            this.encyEntityTypeLabel.Name = "encyEntityTypeLabel";
            // 
            // encyDescriptionLabel
            // 
            this.encyDescriptionLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.encyDescriptionLabel, "encyDescriptionLabel");
            this.encyDescriptionLabel.Name = "encyDescriptionLabel";
            // 
            // encyTitleLabel
            // 
            resources.ApplyResources(this.encyTitleLabel, "encyTitleLabel");
            this.encyTitleLabel.Name = "encyTitleLabel";
            // 
            // combinedDataListBox
            // 
            this.combinedDataListBox.DataSource = this.combinedDataBindingSource1;
            this.combinedDataListBox.DisplayMember = "Name";
            resources.ApplyResources(this.combinedDataListBox, "combinedDataListBox");
            this.combinedDataListBox.FormattingEnabled = true;
            this.combinedDataListBox.Name = "combinedDataListBox";
            this.combinedDataListBox.Sorted = true;
            this.combinedDataListBox.ValueMember = "EntityType";
            this.combinedDataListBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // combinedDataBindingSource1
            // 
            this.combinedDataBindingSource1.DataMember = "CombinedData";
            this.combinedDataBindingSource1.DataSource = this.montreWildDBDataSet;
            // 
            // EncyclopediaForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EncyMainPanel);
            this.Name = "EncyclopediaForm";
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