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
            this.labelClickListBoxInstructions = new System.Windows.Forms.Label();
            this.labelMostRecentPhoto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTopPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxYearStats
            // 
            this.listBoxYearStats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxYearStats.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listBoxYearStats.FormattingEnabled = true;
            this.listBoxYearStats.ItemHeight = 23;
            this.listBoxYearStats.Location = new System.Drawing.Point(50, 140);
            this.listBoxYearStats.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxYearStats.Name = "listBoxYearStats";
            this.listBoxYearStats.Size = new System.Drawing.Size(280, 324);
            this.listBoxYearStats.TabIndex = 0;
            this.listBoxYearStats.SelectedIndexChanged += new System.EventHandler(this.listBoxYearStats_SelectedIndexChanged);
            // 
            // labelTopYear
            // 
            this.labelTopYear.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.labelTopYear.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelTopYear.Location = new System.Drawing.Point(12, 20);
            this.labelTopYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTopYear.Name = "labelTopYear";
            this.labelTopYear.Size = new System.Drawing.Size(1043, 60);
            this.labelTopYear.TabIndex = 1;
            this.labelTopYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelYearDetails
            // 
            this.labelYearDetails.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelYearDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelYearDetails.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelYearDetails.Location = new System.Drawing.Point(360, 140);
            this.labelYearDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelYearDetails.Name = "labelYearDetails";
            this.labelYearDetails.Padding = new System.Windows.Forms.Padding(10);
            this.labelYearDetails.Size = new System.Drawing.Size(340, 324);
            this.labelYearDetails.TabIndex = 2;
            // 
            // pictureBoxTopPhoto
            // 
            this.pictureBoxTopPhoto.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxTopPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxTopPhoto.Location = new System.Drawing.Point(730, 140);
            this.pictureBoxTopPhoto.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxTopPhoto.Name = "pictureBoxTopPhoto";
            this.pictureBoxTopPhoto.Size = new System.Drawing.Size(300, 324);
            this.pictureBoxTopPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTopPhoto.TabIndex = 3;
            this.pictureBoxTopPhoto.TabStop = false;
            // 
            // labelClickListBoxInstructions
            // 
            this.labelClickListBoxInstructions.AutoSize = true;
            this.labelClickListBoxInstructions.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.labelClickListBoxInstructions.ForeColor = System.Drawing.Color.DimGray;
            this.labelClickListBoxInstructions.Location = new System.Drawing.Point(46, 113);
            this.labelClickListBoxInstructions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClickListBoxInstructions.Name = "labelClickListBoxInstructions";
            this.labelClickListBoxInstructions.Size = new System.Drawing.Size(215, 23);
            this.labelClickListBoxInstructions.TabIndex = 4;
            this.labelClickListBoxInstructions.Text = "Select an item to view details";
            // 
            // labelMostRecentPhoto
            // 
            this.labelMostRecentPhoto.AutoSize = true;
            this.labelMostRecentPhoto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelMostRecentPhoto.Location = new System.Drawing.Point(726, 113);
            this.labelMostRecentPhoto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMostRecentPhoto.Name = "labelMostRecentPhoto";
            this.labelMostRecentPhoto.Size = new System.Drawing.Size(162, 23);
            this.labelMostRecentPhoto.TabIndex = 5;
            this.labelMostRecentPhoto.Text = "Most Recent Photo";
            // 
            // MostPhotogenicYearAnalyzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.labelMostRecentPhoto);
            this.Controls.Add(this.labelClickListBoxInstructions);
            this.Controls.Add(this.pictureBoxTopPhoto);
            this.Controls.Add(this.labelYearDetails);
            this.Controls.Add(this.labelTopYear);
            this.Controls.Add(this.listBoxYearStats);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MostPhotogenicYearAnalyzer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MostActiveFriendAnalyzer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTopPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox listBoxYearStats;
        private System.Windows.Forms.Label labelTopYear;
        private System.Windows.Forms.Label labelYearDetails;
        private System.Windows.Forms.PictureBox pictureBoxTopPhoto;
        private System.Windows.Forms.Label labelClickListBoxInstructions;
        private System.Windows.Forms.Label labelMostRecentPhoto;
    }
}