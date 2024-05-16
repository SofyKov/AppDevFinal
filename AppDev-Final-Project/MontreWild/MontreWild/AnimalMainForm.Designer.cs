namespace MontreWild
{
    partial class AnimalMainForm
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
            this.mammalButton = new System.Windows.Forms.Button();
            this.birdButton = new System.Windows.Forms.Button();
            this.otherButton = new System.Windows.Forms.Button();
            this.animalsLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mammalButton
            // 
            this.mammalButton.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mammalButton.Location = new System.Drawing.Point(51, 229);
            this.mammalButton.Name = "mammalButton";
            this.mammalButton.Size = new System.Drawing.Size(302, 138);
            this.mammalButton.TabIndex = 0;
            this.mammalButton.Text = "Mammals";
            this.mammalButton.UseVisualStyleBackColor = true;
            this.mammalButton.Click += new System.EventHandler(this.mammalButton_Click);
            // 
            // birdButton
            // 
            this.birdButton.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birdButton.Location = new System.Drawing.Point(435, 229);
            this.birdButton.Name = "birdButton";
            this.birdButton.Size = new System.Drawing.Size(304, 138);
            this.birdButton.TabIndex = 1;
            this.birdButton.Text = "Birds";
            this.birdButton.UseVisualStyleBackColor = true;
            this.birdButton.Click += new System.EventHandler(this.birdButton_Click);
            // 
            // otherButton
            // 
            this.otherButton.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherButton.Location = new System.Drawing.Point(826, 229);
            this.otherButton.Name = "otherButton";
            this.otherButton.Size = new System.Drawing.Size(295, 138);
            this.otherButton.TabIndex = 2;
            this.otherButton.Text = "Other";
            this.otherButton.UseVisualStyleBackColor = true;
            this.otherButton.Click += new System.EventHandler(this.otherButton_Click);
            // 
            // animalsLabel
            // 
            this.animalsLabel.AutoSize = true;
            this.animalsLabel.Font = new System.Drawing.Font("Modern No. 20", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animalsLabel.Location = new System.Drawing.Point(498, 62);
            this.animalsLabel.Name = "animalsLabel";
            this.animalsLabel.Size = new System.Drawing.Size(188, 48);
            this.animalsLabel.TabIndex = 3;
            this.animalsLabel.Text = "Animals";
            this.animalsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 521);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // AnimalMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 556);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.animalsLabel);
            this.Controls.Add(this.otherButton);
            this.Controls.Add(this.birdButton);
            this.Controls.Add(this.mammalButton);
            this.Name = "AnimalMainForm";
            this.Text = "Animals";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mammalButton;
        private System.Windows.Forms.Button birdButton;
        private System.Windows.Forms.Button otherButton;
        private System.Windows.Forms.Label animalsLabel;
        private System.Windows.Forms.Button backButton;
    }
}

