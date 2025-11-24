namespace BasicFacebookFeatures
{
    partial class MostPhotogenicYearAnalyzer
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
            this.listBoxYearStats = new System.Windows.Forms.ListBox();
            this.labelTopYear = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxYearStats
            // 
            this.listBoxYearStats.FormattingEnabled = true;
            this.listBoxYearStats.Location = new System.Drawing.Point(12, 252);
            this.listBoxYearStats.Name = "listBoxYearStats";
            this.listBoxYearStats.Size = new System.Drawing.Size(222, 186);
            this.listBoxYearStats.TabIndex = 0;
            // 
            // labelTopYear
            // 
            this.labelTopYear.Location = new System.Drawing.Point(286, 9);
            this.labelTopYear.Name = "labelTopYear";
            this.labelTopYear.Size = new System.Drawing.Size(221, 33);
            this.labelTopYear.TabIndex = 1;
            // 
            // MostPhotogenicYearAnalyzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTopYear);
            this.Controls.Add(this.listBoxYearStats);
            this.Name = "MostPhotogenicYearAnalyzer";
            this.Text = "MostActiveFriendAnalyzer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxYearStats;
        private System.Windows.Forms.Label labelTopYear;
    }
}