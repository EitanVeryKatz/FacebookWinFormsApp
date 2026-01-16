namespace BasicFacebookFeatures
{
    partial class MostPhotogenicYearAnalyzerForm
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
            this.listBoxYearStats.ItemHeight = 17;
            this.listBoxYearStats.Location = new System.Drawing.Point(38, 114);
            this.listBoxYearStats.Name = "listBoxYearStats";
            this.listBoxYearStats.Size = new System.Drawing.Size(210, 257);
            this.listBoxYearStats.TabIndex = 0;
            this.listBoxYearStats.SelectedIndexChanged += new System.EventHandler(this.listBoxYearStats_SelectedIndexChanged);
            // 
            // labelTopYear
            // 
            this.labelTopYear.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.labelTopYear.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelTopYear.Location = new System.Drawing.Point(9, 16);
            this.labelTopYear.Name = "labelTopYear";
            this.labelTopYear.Size = new System.Drawing.Size(782, 49);
            this.labelTopYear.TabIndex = 1;
            this.labelTopYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelYearDetails
            // 
            this.labelYearDetails.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelYearDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelYearDetails.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelYearDetails.Location = new System.Drawing.Point(270, 114);
            this.labelYearDetails.Name = "labelYearDetails";
            this.labelYearDetails.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.labelYearDetails.Size = new System.Drawing.Size(256, 264);
            this.labelYearDetails.TabIndex = 2;
            // 
            // pictureBoxTopPhoto
            // 
            this.pictureBoxTopPhoto.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxTopPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxTopPhoto.Location = new System.Drawing.Point(548, 114);
            this.pictureBoxTopPhoto.Name = "pictureBoxTopPhoto";
            this.pictureBoxTopPhoto.Size = new System.Drawing.Size(226, 264);
            this.pictureBoxTopPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTopPhoto.TabIndex = 3;
            this.pictureBoxTopPhoto.TabStop = false;
            // 
            // labelClickListBoxInstructions
            // 
            this.labelClickListBoxInstructions.AutoSize = true;
            this.labelClickListBoxInstructions.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.labelClickListBoxInstructions.ForeColor = System.Drawing.Color.DimGray;
            this.labelClickListBoxInstructions.Location = new System.Drawing.Point(34, 92);
            this.labelClickListBoxInstructions.Name = "labelClickListBoxInstructions";
            this.labelClickListBoxInstructions.Size = new System.Drawing.Size(192, 19);
            this.labelClickListBoxInstructions.TabIndex = 4;
            this.labelClickListBoxInstructions.Text = "Select an item to view details";
            // 
            // labelMostRecentPhoto
            // 
            this.labelMostRecentPhoto.AutoSize = true;
            this.labelMostRecentPhoto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelMostRecentPhoto.Location = new System.Drawing.Point(544, 92);
            this.labelMostRecentPhoto.Name = "labelMostRecentPhoto";
            this.labelMostRecentPhoto.Size = new System.Drawing.Size(126, 19);
            this.labelMostRecentPhoto.TabIndex = 5;
            this.labelMostRecentPhoto.Text = "Most Liked Photo";
            // 
            // MostPhotogenicYearAnalyzerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelMostRecentPhoto);
            this.Controls.Add(this.labelClickListBoxInstructions);
            this.Controls.Add(this.pictureBoxTopPhoto);
            this.Controls.Add(this.labelYearDetails);
            this.Controls.Add(this.labelTopYear);
            this.Controls.Add(this.listBoxYearStats);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MostPhotogenicYearAnalyzerForm";
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