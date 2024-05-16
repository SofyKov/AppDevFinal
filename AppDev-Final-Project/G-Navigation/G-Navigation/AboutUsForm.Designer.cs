namespace G_Navigation
{
    partial class AboutUsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.aboutUsTitleLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.aboutUs_ExitButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.aboutUs_ExitButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.aboutUsTitleLabel);
            this.panel1.Location = new System.Drawing.Point(8, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2400, 1280);
            this.panel1.TabIndex = 0;
            // 
            // aboutUsTitleLabel
            // 
            this.aboutUsTitleLabel.Font = new System.Drawing.Font("Modern No. 20", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutUsTitleLabel.Location = new System.Drawing.Point(944, 104);
            this.aboutUsTitleLabel.Name = "aboutUsTitleLabel";
            this.aboutUsTitleLabel.Size = new System.Drawing.Size(808, 176);
            this.aboutUsTitleLabel.TabIndex = 0;
            this.aboutUsTitleLabel.Text = "About Us";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(112, 336);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2184, 872);
            this.panel2.TabIndex = 1;
            // 
            // aboutUs_ExitButton
            // 
            this.aboutUs_ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutUs_ExitButton.Location = new System.Drawing.Point(2160, 24);
            this.aboutUs_ExitButton.Name = "aboutUs_ExitButton";
            this.aboutUs_ExitButton.Size = new System.Drawing.Size(112, 64);
            this.aboutUs_ExitButton.TabIndex = 2;
            this.aboutUs_ExitButton.Text = "Exit";
            this.aboutUs_ExitButton.UseVisualStyleBackColor = true;
            this.aboutUs_ExitButton.Click += new System.EventHandler(this.aboutUs_ExitButton_Click);
            // 
            // AboutUsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2420, 1420);
            this.Controls.Add(this.panel1);
            this.Name = "AboutUsForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label aboutUsTitleLabel;
        private System.Windows.Forms.Button aboutUs_ExitButton;
    }
}