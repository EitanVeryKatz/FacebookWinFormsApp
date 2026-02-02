namespace BasicFacebookFeatures
{
    partial class HigherOrLowerForm
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
            this.components = new System.ComponentModel.Container();
            this.nextGroupOrProfilePictureBox = new System.Windows.Forms.PictureBox();
            this.currentGroupOrProfilePictureBox = new System.Windows.Forms.PictureBox();
            this.higherBtn = new System.Windows.Forms.Button();
            this.lowerBtn = new System.Windows.Forms.Button();
            this.startNewGameBtn = new System.Windows.Forms.Button();
            this.orLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.rulesBtn = new System.Windows.Forms.Button();
            this.nextPostOrGroupNameLabel = new System.Windows.Forms.Label();
            this.currentPostOrGroupNameLabel = new System.Windows.Forms.Label();
            this.currentGameItemValueLabel = new System.Windows.Forms.Label();
            this.highscoreLabel = new System.Windows.Forms.Label();
            this.isLabel = new System.Windows.Forms.Label();
            this.thanLabel = new System.Windows.Forms.Label();
            this.highschoreValueLabel = new System.Windows.Forms.Label();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.statisticsBtn = new System.Windows.Forms.Button();
            this.loadingLabel = new System.Windows.Forms.Label();
            this.HigherLowerDataSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nextGroupOrProfilePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentGroupOrProfilePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HigherLowerDataSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nextGroupOrProfilePictureBox
            // 
            this.nextGroupOrProfilePictureBox.BackColor = System.Drawing.Color.Gainsboro;
            this.nextGroupOrProfilePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nextGroupOrProfilePictureBox.Location = new System.Drawing.Point(680, 120);
            this.nextGroupOrProfilePictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nextGroupOrProfilePictureBox.Name = "nextGroupOrProfilePictureBox";
            this.nextGroupOrProfilePictureBox.Size = new System.Drawing.Size(300, 300);
            this.nextGroupOrProfilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.nextGroupOrProfilePictureBox.TabIndex = 0;
            this.nextGroupOrProfilePictureBox.TabStop = false;
            // 
            // currentGroupOrProfilePictureBox
            // 
            this.currentGroupOrProfilePictureBox.BackColor = System.Drawing.Color.Gainsboro;
            this.currentGroupOrProfilePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentGroupOrProfilePictureBox.Location = new System.Drawing.Point(80, 120);
            this.currentGroupOrProfilePictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.currentGroupOrProfilePictureBox.Name = "currentGroupOrProfilePictureBox";
            this.currentGroupOrProfilePictureBox.Size = new System.Drawing.Size(300, 300);
            this.currentGroupOrProfilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.currentGroupOrProfilePictureBox.TabIndex = 1;
            this.currentGroupOrProfilePictureBox.TabStop = false;
            // 
            // higherBtn
            // 
            this.higherBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.higherBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.higherBtn.Enabled = false;
            this.higherBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.higherBtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.higherBtn.ForeColor = System.Drawing.Color.White;
            this.higherBtn.Location = new System.Drawing.Point(450, 150);
            this.higherBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.higherBtn.Name = "higherBtn";
            this.higherBtn.Size = new System.Drawing.Size(160, 70);
            this.higherBtn.TabIndex = 2;
            this.higherBtn.Text = "Higher";
            this.higherBtn.UseVisualStyleBackColor = false;
            this.higherBtn.Click += new System.EventHandler(this.higherBtn_Click);
            // 
            // lowerBtn
            // 
            this.lowerBtn.BackColor = System.Drawing.Color.IndianRed;
            this.lowerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lowerBtn.Enabled = false;
            this.lowerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lowerBtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowerBtn.ForeColor = System.Drawing.Color.White;
            this.lowerBtn.Location = new System.Drawing.Point(450, 320);
            this.lowerBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lowerBtn.Name = "lowerBtn";
            this.lowerBtn.Size = new System.Drawing.Size(160, 70);
            this.lowerBtn.TabIndex = 3;
            this.lowerBtn.Text = "Lower";
            this.lowerBtn.UseVisualStyleBackColor = false;
            this.lowerBtn.Click += new System.EventHandler(this.lowerBtn_Click);
            // 
            // startNewGameBtn
            // 
            this.startNewGameBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.startNewGameBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startNewGameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startNewGameBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startNewGameBtn.ForeColor = System.Drawing.Color.White;
            this.startNewGameBtn.Location = new System.Drawing.Point(430, 540);
            this.startNewGameBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.startNewGameBtn.Name = "startNewGameBtn";
            this.startNewGameBtn.Size = new System.Drawing.Size(200, 60);
            this.startNewGameBtn.TabIndex = 4;
            this.startNewGameBtn.Text = "Start New Game";
            this.startNewGameBtn.UseVisualStyleBackColor = false;
            this.startNewGameBtn.Click += new System.EventHandler(this.startNewGameBtn_Click);
            // 
            // orLabel
            // 
            this.orLabel.AutoSize = true;
            this.orLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orLabel.ForeColor = System.Drawing.Color.DimGray;
            this.orLabel.Location = new System.Drawing.Point(513, 255);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(34, 28);
            this.orLabel.TabIndex = 5;
            this.orLabel.Text = "Or";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.scoreLabel.Location = new System.Drawing.Point(465, 480);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(102, 37);
            this.scoreLabel.TabIndex = 8;
            this.scoreLabel.Text = "Score: ";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rulesBtn
            // 
            this.rulesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rulesBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rulesBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rulesBtn.Location = new System.Drawing.Point(14, 615);
            this.rulesBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rulesBtn.Name = "rulesBtn";
            this.rulesBtn.Size = new System.Drawing.Size(118, 38);
            this.rulesBtn.TabIndex = 9;
            this.rulesBtn.Text = "How To Play";
            this.rulesBtn.UseVisualStyleBackColor = true;
            this.rulesBtn.Click += new System.EventHandler(this.rulesBtn_Click);
            // 
            // nextPostOrGroupNameLabel
            // 
            this.nextPostOrGroupNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextPostOrGroupNameLabel.Location = new System.Drawing.Point(680, 430);
            this.nextPostOrGroupNameLabel.Name = "nextPostOrGroupNameLabel";
            this.nextPostOrGroupNameLabel.Size = new System.Drawing.Size(300, 30);
            this.nextPostOrGroupNameLabel.TabIndex = 10;
            this.nextPostOrGroupNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // currentPostOrGroupNameLabel
            // 
            this.currentPostOrGroupNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPostOrGroupNameLabel.Location = new System.Drawing.Point(80, 430);
            this.currentPostOrGroupNameLabel.Name = "currentPostOrGroupNameLabel";
            this.currentPostOrGroupNameLabel.Size = new System.Drawing.Size(300, 30);
            this.currentPostOrGroupNameLabel.TabIndex = 11;
            this.currentPostOrGroupNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // currentGameItemValueLabel
            // 
            this.currentGameItemValueLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentGameItemValueLabel.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.currentGameItemValueLabel.Location = new System.Drawing.Point(80, 80);
            this.currentGameItemValueLabel.Name = "currentGameItemValueLabel";
            this.currentGameItemValueLabel.Size = new System.Drawing.Size(300, 35);
            this.currentGameItemValueLabel.TabIndex = 12;
            this.currentGameItemValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // highscoreLabel
            // 
            this.highscoreLabel.AutoSize = true;
            this.highscoreLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highscoreLabel.ForeColor = System.Drawing.Color.DimGray;
            this.highscoreLabel.Location = new System.Drawing.Point(880, 625);
            this.highscoreLabel.Name = "highscoreLabel";
            this.highscoreLabel.Size = new System.Drawing.Size(105, 23);
            this.highscoreLabel.TabIndex = 13;
            this.highscoreLabel.Text = "Highschore: ";
            // 
            // isLabel
            // 
            this.isLabel.AutoSize = true;
            this.isLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isLabel.Location = new System.Drawing.Point(40, 435);
            this.isLabel.Name = "isLabel";
            this.isLabel.Size = new System.Drawing.Size(0, 23);
            this.isLabel.TabIndex = 14;
            // 
            // thanLabel
            // 
            this.thanLabel.AutoSize = true;
            this.thanLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thanLabel.Location = new System.Drawing.Point(620, 435);
            this.thanLabel.Name = "thanLabel";
            this.thanLabel.Size = new System.Drawing.Size(0, 23);
            this.thanLabel.TabIndex = 15;
            // 
            // highschoreValueLabel
            // 
            this.highschoreValueLabel.AutoSize = true;
            this.highschoreValueLabel.Location = new System.Drawing.Point(991, 625);
            this.highschoreValueLabel.Name = "highschoreValueLabel";
            this.highschoreValueLabel.Size = new System.Drawing.Size(0, 23);
            this.highschoreValueLabel.TabIndex = 16;
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // statisticsBtn
            // 
            this.statisticsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.statisticsBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.statisticsBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statisticsBtn.Location = new System.Drawing.Point(157, 615);
            this.statisticsBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.statisticsBtn.Name = "statisticsBtn";
            this.statisticsBtn.Size = new System.Drawing.Size(118, 38);
            this.statisticsBtn.TabIndex = 17;
            this.statisticsBtn.Text = "Statistics";
            this.statisticsBtn.UseVisualStyleBackColor = true;
            this.statisticsBtn.Click += new System.EventHandler(this.statisticsBtn_Click);
            // 
            // loadingLabel
            // 
            this.loadingLabel.AutoSize = true;
            this.loadingLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingLabel.ForeColor = System.Drawing.Color.DimGray;
            this.loadingLabel.Location = new System.Drawing.Point(513, 28);
            this.loadingLabel.Name = "loadingLabel";
            this.loadingLabel.Size = new System.Drawing.Size(0, 28);
            this.loadingLabel.TabIndex = 18;
            // 
            // HigherLowerDataSource
            // 
            this.HigherLowerDataSource.DataSource = typeof(BasicFacebookFeatures.HigherLowerGameLogic);
            // 
            // HigherOrLowerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1060, 668);
            this.Controls.Add(this.loadingLabel);
            this.Controls.Add(this.statisticsBtn);
            this.Controls.Add(this.highschoreValueLabel);
            this.Controls.Add(this.thanLabel);
            this.Controls.Add(this.isLabel);
            this.Controls.Add(this.highscoreLabel);
            this.Controls.Add(this.currentGameItemValueLabel);
            this.Controls.Add(this.currentPostOrGroupNameLabel);
            this.Controls.Add(this.nextPostOrGroupNameLabel);
            this.Controls.Add(this.rulesBtn);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.orLabel);
            this.Controls.Add(this.startNewGameBtn);
            this.Controls.Add(this.lowerBtn);
            this.Controls.Add(this.higherBtn);
            this.Controls.Add(this.currentGroupOrProfilePictureBox);
            this.Controls.Add(this.nextGroupOrProfilePictureBox);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.HigherLowerDataSource, "MaxScore", true));
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "HigherOrLowerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Higher Or Lower";
            ((System.ComponentModel.ISupportInitialize)(this.nextGroupOrProfilePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentGroupOrProfilePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HigherLowerDataSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox nextGroupOrProfilePictureBox;
        private System.Windows.Forms.PictureBox currentGroupOrProfilePictureBox;
        private System.Windows.Forms.Button higherBtn;
        private System.Windows.Forms.Button lowerBtn;
        private System.Windows.Forms.Button startNewGameBtn;
        private System.Windows.Forms.Label orLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Button rulesBtn;
        private System.Windows.Forms.Label nextPostOrGroupNameLabel;
        private System.Windows.Forms.Label currentPostOrGroupNameLabel;
        private System.Windows.Forms.Label currentGameItemValueLabel;
        private System.Windows.Forms.Label highscoreLabel;
        private System.Windows.Forms.Label isLabel;
        private System.Windows.Forms.Label thanLabel;
        private System.Windows.Forms.BindingSource HigherLowerDataSource;
        private System.Windows.Forms.Label highschoreValueLabel;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Button statisticsBtn;
        private System.Windows.Forms.Label loadingLabel;
    }
}