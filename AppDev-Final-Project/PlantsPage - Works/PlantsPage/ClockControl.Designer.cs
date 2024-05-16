namespace PlantsPage
{
    partial class ClockControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Timer Timer;
            this.time_lbl = new System.Windows.Forms.Label();
            Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Timer
            // 
            Timer.Enabled = true;
            Timer.Interval = 1000;
            Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // time_lbl
            // 
            this.time_lbl.BackColor = System.Drawing.SystemColors.Window;
            this.time_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.time_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_lbl.ForeColor = System.Drawing.Color.IndianRed;
            this.time_lbl.Location = new System.Drawing.Point(3, 3);
            this.time_lbl.Name = "time_lbl";
            this.time_lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.time_lbl.Size = new System.Drawing.Size(112, 48);
            this.time_lbl.TabIndex = 0;
            this.time_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClockControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.Controls.Add(this.time_lbl);
            this.Name = "ClockControl";
            this.Size = new System.Drawing.Size(118, 54);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label time_lbl;
    }
}
