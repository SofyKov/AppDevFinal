namespace MontreWild
{
    partial class Birds
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
            this.lastButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.birdPictureBox = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.birdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.birdPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lastButton
            // 
            this.lastButton.Location = new System.Drawing.Point(12, 116);
            this.lastButton.Name = "lastButton";
            this.lastButton.Size = new System.Drawing.Size(75, 23);
            this.lastButton.TabIndex = 0;
            this.lastButton.Text = "<";
            this.lastButton.UseVisualStyleBackColor = true;
            this.lastButton.Click += new System.EventHandler(this.lastButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(469, 116);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 1;
            this.nextButton.Text = ">";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // birdPictureBox
            // 
            this.birdPictureBox.Location = new System.Drawing.Point(12, 145);
            this.birdPictureBox.Name = "birdPictureBox";
            this.birdPictureBox.Size = new System.Drawing.Size(532, 329);
            this.birdPictureBox.TabIndex = 2;
            this.birdPictureBox.TabStop = false;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 483);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(706, 115);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(421, 391);
            this.descriptionTextBox.TabIndex = 4;
            this.descriptionTextBox.Text = "";
            // 
            // birdLabel
            // 
            this.birdLabel.AutoSize = true;
            this.birdLabel.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birdLabel.Location = new System.Drawing.Point(568, 33);
            this.birdLabel.Name = "birdLabel";
            this.birdLabel.Size = new System.Drawing.Size(106, 38);
            this.birdLabel.TabIndex = 5;
            this.birdLabel.Text = "Birds";
            // 
            // Birds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1163, 556);
            this.Controls.Add(this.birdLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.birdPictureBox);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.lastButton);
            this.Name = "Birds";
            this.Text = "Birds";
            ((System.ComponentModel.ISupportInitialize)(this.birdPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lastButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.PictureBox birdPictureBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.RichTextBox descriptionTextBox;
        private System.Windows.Forms.Label birdLabel;
    }
}