namespace PlantsPage
{
    partial class FloraForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FloraForm));
            this.plantsPanel = new System.Windows.Forms.Panel();
            this.btn_Tree = new System.Windows.Forms.Button();
            this.btn_Shrub = new System.Windows.Forms.Button();
            this.btn_Plants = new System.Windows.Forms.Button();
            this.plantsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // plantsPanel
            // 
            this.plantsPanel.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.plantsPanel, "plantsPanel");
            this.plantsPanel.Controls.Add(this.btn_Tree);
            this.plantsPanel.Controls.Add(this.btn_Shrub);
            this.plantsPanel.Controls.Add(this.btn_Plants);
            this.plantsPanel.Name = "plantsPanel";
            // 
            // btn_Tree
            // 
            this.btn_Tree.BackColor = System.Drawing.Color.White;
            this.btn_Tree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Tree.FlatAppearance.BorderSize = 3;
            this.btn_Tree.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Tree.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.btn_Tree, "btn_Tree");
            this.btn_Tree.ForeColor = System.Drawing.Color.Indigo;
            this.btn_Tree.Name = "btn_Tree";
            this.btn_Tree.UseVisualStyleBackColor = false;
            this.btn_Tree.Click += new System.EventHandler(this.btn_Tree_Click);
            // 
            // btn_Shrub
            // 
            this.btn_Shrub.BackColor = System.Drawing.Color.White;
            this.btn_Shrub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Shrub.FlatAppearance.BorderSize = 3;
            this.btn_Shrub.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Shrub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.btn_Shrub, "btn_Shrub");
            this.btn_Shrub.ForeColor = System.Drawing.Color.Indigo;
            this.btn_Shrub.Name = "btn_Shrub";
            this.btn_Shrub.UseVisualStyleBackColor = false;
            this.btn_Shrub.Click += new System.EventHandler(this.btn_Shrub_Click);
            // 
            // btn_Plants
            // 
            this.btn_Plants.BackColor = System.Drawing.Color.White;
            this.btn_Plants.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Plants.FlatAppearance.BorderSize = 3;
            this.btn_Plants.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Plants.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.btn_Plants, "btn_Plants");
            this.btn_Plants.ForeColor = System.Drawing.Color.Indigo;
            this.btn_Plants.Name = "btn_Plants";
            this.btn_Plants.UseVisualStyleBackColor = false;
            this.btn_Plants.Click += new System.EventHandler(this.btn_Plants_Click);
            // 
            // FloraForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Controls.Add(this.plantsPanel);
            this.DoubleBuffered = true;
            this.Name = "FloraForm";
            this.TransparencyKey = System.Drawing.SystemColors.InactiveBorder;
            this.plantsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plantsPanel;
        private System.Windows.Forms.Button btn_Tree;
        private System.Windows.Forms.Button btn_Shrub;
        private System.Windows.Forms.Button btn_Plants;
    }
}

