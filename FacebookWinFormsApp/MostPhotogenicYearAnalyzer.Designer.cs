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
            this.labelYearDetails = new System.Windows.Forms.Label();
            this.pictureBoxTopPhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTopPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxYearStats
            // 
            this.listBoxYearStats.FormattingEnabled = true;
            this.listBoxYearStats.ItemHeight = 16;
            this.listBoxYearStats.Location = new System.Drawing.Point(16, 310);
            this.listBoxYearStats.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxYearStats.Name = "listBoxYearStats";
            this.listBoxYearStats.Size = new System.Drawing.Size(295, 228);
            this.listBoxYearStats.TabIndex = 0;
            this.listBoxYearStats.SelectedIndexChanged += new System.EventHandler(this.listBoxYearStats_SelectedIndexChanged);
            // 
            // labelTopYear
            // 
            this.labelTopYear.Location = new System.Drawing.Point(381, 11);
            this.labelTopYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTopYear.Name = "labelTopYear";
            this.labelTopYear.Size = new System.Drawing.Size(295, 41);
            this.labelTopYear.TabIndex = 1;
            // 
            // labelYearDetails
            // 
            this.labelYearDetails.Location = new System.Drawing.Point(12, 250);
            this.labelYearDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelYearDetails.Name = "labelYearDetails";
            this.labelYearDetails.Size = new System.Drawing.Size(296, 41);
            this.labelYearDetails.TabIndex = 2;
            // 
            // pictureBoxTopPhoto
            // 
            this.pictureBoxTopPhoto.Location = new System.Drawing.Point(385, 310);
            this.pictureBoxTopPhoto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxTopPhoto.Name = "pictureBoxTopPhoto";
            this.pictureBoxTopPhoto.Size = new System.Drawing.Size(280, 229);
            this.pictureBoxTopPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTopPhoto.TabIndex = 3;
            this.pictureBoxTopPhoto.TabStop = false;
            // 
            // MostPhotogenicYearAnalyzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pictureBoxTopPhoto);
            this.Controls.Add(this.labelYearDetails);
            this.Controls.Add(this.labelTopYear);
            this.Controls.Add(this.listBoxYearStats);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MostPhotogenicYearAnalyzer";
            this.Text = "MostActiveFriendAnalyzer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTopPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxYearStats;
        private System.Windows.Forms.Label labelTopYear;
        private System.Windows.Forms.Label labelYearDetails;
        private System.Windows.Forms.PictureBox pictureBoxTopPhoto;
    }
}