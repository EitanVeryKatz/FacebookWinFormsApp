namespace BasicFacebookFeatures
{
    partial class FormMain
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.facebookExperianceWindow = new System.Windows.Forms.TabControl();
            this.loginPage = new System.Windows.Forms.TabPage();
            this.buttonConnectAsDesig = new System.Windows.Forms.Button();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.textBoxAppID = new System.Windows.Forms.TextBox();
            this.facebookBasicExperiancePage = new System.Windows.Forms.TabPage();
            this.buttonMostPhotogenicYear = new System.Windows.Forms.Button();
            this.higherOrLowerBtn = new System.Windows.Forms.Button();
            this.friendsPictureBox = new System.Windows.Forms.PictureBox();
            this.MusicPictureBox = new System.Windows.Forms.PictureBox();
            this.GroupsPictureBox = new System.Windows.Forms.PictureBox();
            this.likedFriendsListBox = new System.Windows.Forms.ListBox();
            this.likedMusicListBox = new System.Windows.Forms.ListBox();
            this.likedGroupsListBox = new System.Windows.Forms.ListBox();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.myFavoritePostLabel = new System.Windows.Forms.Label();
            this.currentFavoritePostLabel = new System.Windows.Forms.Label();
            this.postsComboBox = new System.Windows.Forms.ComboBox();
            this.myPostsLabel = new System.Windows.Forms.Label();
            this.selectPostBtn = new System.Windows.Forms.Button();
            this.facebookExperianceWindow.SuspendLayout();
            this.loginPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.facebookBasicExperiancePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.friendsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusicPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(340, 200);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(300, 50);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.IndianRed;
            this.buttonLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogout.Enabled = false;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonLogout.ForeColor = System.Drawing.Color.White;
            this.buttonLogout.Location = new System.Drawing.Point(340, 320);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(300, 40);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(240, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 69);
            this.label1.TabIndex = 53;
            this.label1.Text = "This is the AppID of \"Design Patterns App 2.4\".\r\nThe grader will use it to test y" +
            "our app.\r\nType here your own AppID to test it:\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // facebookExperianceWindow
            // 
            this.facebookExperianceWindow.Controls.Add(this.loginPage);
            this.facebookExperianceWindow.Controls.Add(this.facebookBasicExperiancePage);
            this.facebookExperianceWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.facebookExperianceWindow.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.facebookExperianceWindow.Location = new System.Drawing.Point(0, 0);
            this.facebookExperianceWindow.Name = "facebookExperianceWindow";
            this.facebookExperianceWindow.SelectedIndex = 0;
            this.facebookExperianceWindow.Size = new System.Drawing.Size(983, 545);
            this.facebookExperianceWindow.TabIndex = 54;
            // 
            // loginPage
            // 
            this.loginPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.loginPage.Controls.Add(this.buttonConnectAsDesig);
            this.loginPage.Controls.Add(this.pictureBoxProfile);
            this.loginPage.Controls.Add(this.textBoxAppID);
            this.loginPage.Controls.Add(this.label1);
            this.loginPage.Controls.Add(this.buttonLogout);
            this.loginPage.Controls.Add(this.buttonLogin);
            this.loginPage.Location = new System.Drawing.Point(4, 32);
            this.loginPage.Name = "loginPage";
            this.loginPage.Padding = new System.Windows.Forms.Padding(3);
            this.loginPage.Size = new System.Drawing.Size(975, 509);
            this.loginPage.TabIndex = 0;
            this.loginPage.Text = "Login";
            // 
            // buttonConnectAsDesig
            // 
            this.buttonConnectAsDesig.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonConnectAsDesig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConnectAsDesig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConnectAsDesig.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonConnectAsDesig.ForeColor = System.Drawing.Color.White;
            this.buttonConnectAsDesig.Location = new System.Drawing.Point(340, 260);
            this.buttonConnectAsDesig.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConnectAsDesig.Name = "buttonConnectAsDesig";
            this.buttonConnectAsDesig.Size = new System.Drawing.Size(300, 40);
            this.buttonConnectAsDesig.TabIndex = 56;
            this.buttonConnectAsDesig.Text = "Connect As Desig";
            this.buttonConnectAsDesig.UseVisualStyleBackColor = false;
            this.buttonConnectAsDesig.Click += new System.EventHandler(this.buttonConnectAsDesig_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxProfile.Location = new System.Drawing.Point(440, 380);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProfile.TabIndex = 55;
            this.pictureBoxProfile.TabStop = false;
            // 
            // textBoxAppID
            // 
            this.textBoxAppID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAppID.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAppID.Location = new System.Drawing.Point(240, 110);
            this.textBoxAppID.Name = "textBoxAppID";
            this.textBoxAppID.Size = new System.Drawing.Size(500, 31);
            this.textBoxAppID.TabIndex = 54;
            this.textBoxAppID.Text = "1153277586983935";
            this.textBoxAppID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxAppID.TextChanged += new System.EventHandler(this.textBoxAppID_TextChanged);
            // 
            // facebookBasicExperiancePage
            // 
            this.facebookBasicExperiancePage.BackColor = System.Drawing.Color.White;
            this.facebookBasicExperiancePage.Controls.Add(this.selectPostBtn);
            this.facebookBasicExperiancePage.Controls.Add(this.myPostsLabel);
            this.facebookBasicExperiancePage.Controls.Add(this.postsComboBox);
            this.facebookBasicExperiancePage.Controls.Add(this.currentFavoritePostLabel);
            this.facebookBasicExperiancePage.Controls.Add(this.myFavoritePostLabel);
            this.facebookBasicExperiancePage.Controls.Add(this.profilePictureBox);
            this.facebookBasicExperiancePage.Controls.Add(this.buttonMostPhotogenicYear);
            this.facebookBasicExperiancePage.Controls.Add(this.higherOrLowerBtn);
            this.facebookBasicExperiancePage.Controls.Add(this.friendsPictureBox);
            this.facebookBasicExperiancePage.Controls.Add(this.MusicPictureBox);
            this.facebookBasicExperiancePage.Controls.Add(this.GroupsPictureBox);
            this.facebookBasicExperiancePage.Controls.Add(this.likedFriendsListBox);
            this.facebookBasicExperiancePage.Controls.Add(this.likedMusicListBox);
            this.facebookBasicExperiancePage.Controls.Add(this.likedGroupsListBox);
            this.facebookBasicExperiancePage.Location = new System.Drawing.Point(4, 32);
            this.facebookBasicExperiancePage.Name = "facebookBasicExperiancePage";
            this.facebookBasicExperiancePage.Padding = new System.Windows.Forms.Padding(3);
            this.facebookBasicExperiancePage.Size = new System.Drawing.Size(975, 509);
            this.facebookBasicExperiancePage.TabIndex = 1;
            this.facebookBasicExperiancePage.Text = "The Facebook Experience";
            // 
            // buttonMostPhotogenicYear
            // 
            this.buttonMostPhotogenicYear.BackColor = System.Drawing.Color.LightSlateGray;
            this.buttonMostPhotogenicYear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMostPhotogenicYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMostPhotogenicYear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonMostPhotogenicYear.ForeColor = System.Drawing.Color.White;
            this.buttonMostPhotogenicYear.Location = new System.Drawing.Point(780, 110);
            this.buttonMostPhotogenicYear.Name = "buttonMostPhotogenicYear";
            this.buttonMostPhotogenicYear.Size = new System.Drawing.Size(160, 50);
            this.buttonMostPhotogenicYear.TabIndex = 7;
            this.buttonMostPhotogenicYear.Text = "Most Photogenic Year";
            this.buttonMostPhotogenicYear.UseVisualStyleBackColor = false;
            this.buttonMostPhotogenicYear.Click += new System.EventHandler(this.buttonMostPhotogenicYear_Click);
            // 
            // higherOrLowerBtn
            // 
            this.higherOrLowerBtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.higherOrLowerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.higherOrLowerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.higherOrLowerBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.higherOrLowerBtn.ForeColor = System.Drawing.Color.White;
            this.higherOrLowerBtn.Location = new System.Drawing.Point(780, 50);
            this.higherOrLowerBtn.Name = "higherOrLowerBtn";
            this.higherOrLowerBtn.Size = new System.Drawing.Size(160, 50);
            this.higherOrLowerBtn.TabIndex = 6;
            this.higherOrLowerBtn.Text = "Higher or Lower";
            this.higherOrLowerBtn.UseVisualStyleBackColor = false;
            this.higherOrLowerBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // friendsPictureBox
            // 
            this.friendsPictureBox.BackColor = System.Drawing.Color.Gainsboro;
            this.friendsPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.friendsPictureBox.Location = new System.Drawing.Point(710, 260);
            this.friendsPictureBox.Name = "friendsPictureBox";
            this.friendsPictureBox.Size = new System.Drawing.Size(80, 80);
            this.friendsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.friendsPictureBox.TabIndex = 5;
            this.friendsPictureBox.TabStop = false;
            // 
            // MusicPictureBox
            // 
            this.MusicPictureBox.BackColor = System.Drawing.Color.Gainsboro;
            this.MusicPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MusicPictureBox.Location = new System.Drawing.Point(430, 260);
            this.MusicPictureBox.Name = "MusicPictureBox";
            this.MusicPictureBox.Size = new System.Drawing.Size(80, 80);
            this.MusicPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MusicPictureBox.TabIndex = 4;
            this.MusicPictureBox.TabStop = false;
            // 
            // GroupsPictureBox
            // 
            this.GroupsPictureBox.BackColor = System.Drawing.Color.Gainsboro;
            this.GroupsPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GroupsPictureBox.Location = new System.Drawing.Point(140, 260);
            this.GroupsPictureBox.Name = "GroupsPictureBox";
            this.GroupsPictureBox.Size = new System.Drawing.Size(80, 80);
            this.GroupsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GroupsPictureBox.TabIndex = 3;
            this.GroupsPictureBox.TabStop = false;
            // 
            // likedFriendsListBox
            // 
            this.likedFriendsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.likedFriendsListBox.FormattingEnabled = true;
            this.likedFriendsListBox.ItemHeight = 23;
            this.likedFriendsListBox.Location = new System.Drawing.Point(640, 350);
            this.likedFriendsListBox.Name = "likedFriendsListBox";
            this.likedFriendsListBox.Size = new System.Drawing.Size(220, 140);
            this.likedFriendsListBox.TabIndex = 2;
            this.likedFriendsListBox.SelectedIndexChanged += new System.EventHandler(this.likedFriendsListBox_SelectedIndexChanged);
            // 
            // likedMusicListBox
            // 
            this.likedMusicListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.likedMusicListBox.FormattingEnabled = true;
            this.likedMusicListBox.ItemHeight = 23;
            this.likedMusicListBox.Location = new System.Drawing.Point(360, 350);
            this.likedMusicListBox.Name = "likedMusicListBox";
            this.likedMusicListBox.Size = new System.Drawing.Size(220, 140);
            this.likedMusicListBox.TabIndex = 1;
            this.likedMusicListBox.SelectedIndexChanged += new System.EventHandler(this.likedMusicListBox_SelectedIndexChanged);
            // 
            // likedGroupsListBox
            // 
            this.likedGroupsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.likedGroupsListBox.FormattingEnabled = true;
            this.likedGroupsListBox.ItemHeight = 23;
            this.likedGroupsListBox.Location = new System.Drawing.Point(70, 350);
            this.likedGroupsListBox.Name = "likedGroupsListBox";
            this.likedGroupsListBox.Size = new System.Drawing.Size(220, 140);
            this.likedGroupsListBox.TabIndex = 0;
            this.likedGroupsListBox.SelectedIndexChanged += new System.EventHandler(this.likedGroupsListBox_SelectedIndexChanged);
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profilePictureBox.Location = new System.Drawing.Point(30, 30);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(150, 150);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePictureBox.TabIndex = 9;
            this.profilePictureBox.TabStop = false;
            // 
            // myFavoritePostLabel
            // 
            this.myFavoritePostLabel.AutoSize = true;
            this.myFavoritePostLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.myFavoritePostLabel.Location = new System.Drawing.Point(200, 140);
            this.myFavoritePostLabel.Name = "myFavoritePostLabel";
            this.myFavoritePostLabel.Size = new System.Drawing.Size(147, 23);
            this.myFavoritePostLabel.TabIndex = 10;
            this.myFavoritePostLabel.Text = "My favorite Post:";
            // 
            // currentFavoritePostLabel
            // 
            this.currentFavoritePostLabel.AutoSize = true;
            this.currentFavoritePostLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.currentFavoritePostLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.currentFavoritePostLabel.Location = new System.Drawing.Point(360, 140);
            this.currentFavoritePostLabel.Name = "currentFavoritePostLabel";
            this.currentFavoritePostLabel.Size = new System.Drawing.Size(0, 23);
            this.currentFavoritePostLabel.TabIndex = 11;
            // 
            // postsComboBox
            // 
            this.postsComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.postsComboBox.FormattingEnabled = true;
            this.postsComboBox.Location = new System.Drawing.Point(204, 60);
            this.postsComboBox.Name = "postsComboBox";
            this.postsComboBox.Size = new System.Drawing.Size(400, 31);
            this.postsComboBox.TabIndex = 12;
            // 
            // myPostsLabel
            // 
            this.myPostsLabel.AutoSize = true;
            this.myPostsLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.myPostsLabel.Location = new System.Drawing.Point(200, 30);
            this.myPostsLabel.Name = "myPostsLabel";
            this.myPostsLabel.Size = new System.Drawing.Size(86, 23);
            this.myPostsLabel.TabIndex = 13;
            this.myPostsLabel.Text = "My Posts:";
            // 
            // selectPostBtn
            // 
            this.selectPostBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.selectPostBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectPostBtn.Enabled = false;
            this.selectPostBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectPostBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.selectPostBtn.ForeColor = System.Drawing.Color.White;
            this.selectPostBtn.Location = new System.Drawing.Point(620, 58);
            this.selectPostBtn.Name = "selectPostBtn";
            this.selectPostBtn.Size = new System.Drawing.Size(120, 35);
            this.selectPostBtn.TabIndex = 14;
            this.selectPostBtn.Text = "Set Favorite";
            this.selectPostBtn.UseVisualStyleBackColor = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 545);
            this.Controls.Add(this.facebookExperianceWindow);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OurFacebookApp";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.facebookExperianceWindow.ResumeLayout(false);
            this.loginPage.ResumeLayout(false);
            this.loginPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.facebookBasicExperiancePage.ResumeLayout(false);
            this.facebookBasicExperiancePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.friendsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusicPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonLogout;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabControl facebookExperianceWindow;
		private System.Windows.Forms.TabPage loginPage;
		private System.Windows.Forms.TabPage facebookBasicExperiancePage;
        private System.Windows.Forms.TextBox textBoxAppID;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Button buttonConnectAsDesig;
        private System.Windows.Forms.PictureBox friendsPictureBox;
        private System.Windows.Forms.PictureBox MusicPictureBox;
        private System.Windows.Forms.PictureBox GroupsPictureBox;
        private System.Windows.Forms.ListBox likedFriendsListBox;
        private System.Windows.Forms.ListBox likedMusicListBox;
        private System.Windows.Forms.ListBox likedGroupsListBox;
        private System.Windows.Forms.Button buttonMostPhotogenicYear;
        private System.Windows.Forms.Button higherOrLowerBtn;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.Label currentFavoritePostLabel;
        private System.Windows.Forms.Label myFavoritePostLabel;
        private System.Windows.Forms.Button selectPostBtn;
        private System.Windows.Forms.Label myPostsLabel;
        private System.Windows.Forms.ComboBox postsComboBox;
    }
}

