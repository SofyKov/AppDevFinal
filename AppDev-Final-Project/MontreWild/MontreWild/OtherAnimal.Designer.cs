namespace MontreWild
{
    partial class OtherAnimal
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
            this.backButton = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.otherPictureBox = new System.Windows.Forms.PictureBox();
            this.otherLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.otherPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lastButton
            // 
            this.lastButton.Location = new System.Drawing.Point(12, 119);
            this.lastButton.Name = "lastButton";
            this.lastButton.Size = new System.Drawing.Size(75, 23);
            this.lastButton.TabIndex = 0;
            this.lastButton.Text = "<";
            this.lastButton.UseVisualStyleBackColor = true;
            this.lastButton.Click += new System.EventHandler(this.lastButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(475, 119);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 2;
            this.nextButton.Text = ">";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 512);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(702, 131);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(421, 391);
            this.descriptionTextBox.TabIndex = 5;
            this.descriptionTextBox.Text = "";
            // 
            // otherPictureBox
            // 
            this.otherPictureBox.Location = new System.Drawing.Point(12, 160);
            this.otherPictureBox.Name = "otherPictureBox";
            this.otherPictureBox.Size = new System.Drawing.Size(532, 329);
            this.otherPictureBox.TabIndex = 6;
            this.otherPictureBox.TabStop = false;
            // 
            // otherLabel
            // 
            this.otherLabel.AutoSize = true;
            this.otherLabel.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherLabel.Location = new System.Drawing.Point(490, 40);
            this.otherLabel.Name = "otherLabel";
            this.otherLabel.Size = new System.Drawing.Size(254, 38);
            this.otherLabel.TabIndex = 7;
            this.otherLabel.Text = "Other Animals";
            // 
            // OtherAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1163, 556);
            this.Controls.Add(this.otherLabel);
            this.Controls.Add(this.otherPictureBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.lastButton);
            this.Name = "OtherAnimal";
            this.Text = "OtherAnimal";
            ((System.ComponentModel.ISupportInitialize)(this.otherPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lastButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.RichTextBox descriptionTextBox;
        private System.Windows.Forms.PictureBox otherPictureBox;
        private System.Windows.Forms.Label otherLabel;
    }
}