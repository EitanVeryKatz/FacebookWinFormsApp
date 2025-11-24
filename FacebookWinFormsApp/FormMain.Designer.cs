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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonConnectAsDesig = new System.Windows.Forms.Button();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.textBoxAppID = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonMostPhotogenicYear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.friendsPictureBox = new System.Windows.Forms.PictureBox();
            this.MusicPictureBox = new System.Windows.Forms.PictureBox();
            this.GroupsPictureBox = new System.Windows.Forms.PictureBox();
            this.likedFriendsListBox = new System.Windows.Forms.ListBox();
            this.likedMusicListBox = new System.Windows.Forms.ListBox();
            this.likedGroupsListBox = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.friendsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusicPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(18, 17);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(268, 44);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Enabled = false;
            this.buttonLogout.Location = new System.Drawing.Point(18, 121);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(268, 43);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 54);
            this.label1.TabIndex = 53;
            this.label1.Text = "This is the AppID of \"Design Patterns App 2.4\".\r\nThe grader will use it to test y" +
    "our app.\r\nType here your own AppID to test it:\r\n";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(862, 370);
            this.tabControl1.TabIndex = 54;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonConnectAsDesig);
            this.tabPage1.Controls.Add(this.pictureBoxProfile);
            this.tabPage1.Controls.Add(this.textBoxAppID);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.buttonLogout);
            this.tabPage1.Controls.Add(this.buttonLogin);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(854, 339);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonConnectAsDesig
            // 
            this.buttonConnectAsDesig.Location = new System.Drawing.Point(18, 69);
            this.buttonConnectAsDesig.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConnectAsDesig.Name = "buttonConnectAsDesig";
            this.buttonConnectAsDesig.Size = new System.Drawing.Size(268, 44);
            this.buttonConnectAsDesig.TabIndex = 56;
            this.buttonConnectAsDesig.Text = "Connect As Desig";
            this.buttonConnectAsDesig.UseVisualStyleBackColor = true;
            this.buttonConnectAsDesig.Click += new System.EventHandler(this.buttonConnectAsDesig_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(18, 171);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(79, 78);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 55;
            this.pictureBoxProfile.TabStop = false;
            // 
            // textBoxAppID
            // 
            this.textBoxAppID.Location = new System.Drawing.Point(319, 126);
            this.textBoxAppID.Name = "textBoxAppID";
            this.textBoxAppID.Size = new System.Drawing.Size(446, 24);
            this.textBoxAppID.TabIndex = 54;
            this.textBoxAppID.Text = "1153277586983935";
            this.textBoxAppID.TextChanged += new System.EventHandler(this.textBoxAppID_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonMostPhotogenicYear);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.friendsPictureBox);
            this.tabPage2.Controls.Add(this.MusicPictureBox);
            this.tabPage2.Controls.Add(this.GroupsPictureBox);
            this.tabPage2.Controls.Add(this.likedFriendsListBox);
            this.tabPage2.Controls.Add(this.likedMusicListBox);
            this.tabPage2.Controls.Add(this.likedGroupsListBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(854, 339);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonMostPhotogenicYear
            // 
            this.buttonMostPhotogenicYear.Location = new System.Drawing.Point(652, 195);
            this.buttonMostPhotogenicYear.Name = "buttonMostPhotogenicYear";
            this.buttonMostPhotogenicYear.Size = new System.Drawing.Size(129, 61);
            this.buttonMostPhotogenicYear.TabIndex = 7;
            this.buttonMostPhotogenicYear.Text = "Most Photogenic Year";
            this.buttonMostPhotogenicYear.UseVisualStyleBackColor = true;
            this.buttonMostPhotogenicYear.Click += new System.EventHandler(this.buttonMostPhotogenicYear_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(652, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 61);
            this.button1.TabIndex = 6;
            this.button1.Text = "ComparePagesFeatureBtn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // friendsPictureBox
            // 
            this.friendsPictureBox.Location = new System.Drawing.Point(515, 249);
            this.friendsPictureBox.Name = "friendsPictureBox";
            this.friendsPictureBox.Size = new System.Drawing.Size(55, 50);
            this.friendsPictureBox.TabIndex = 5;
            this.friendsPictureBox.TabStop = false;
            // 
            // MusicPictureBox
            // 
            this.MusicPictureBox.Location = new System.Drawing.Point(317, 249);
            this.MusicPictureBox.Name = "MusicPictureBox";
            this.MusicPictureBox.Size = new System.Drawing.Size(55, 50);
            this.MusicPictureBox.TabIndex = 4;
            this.MusicPictureBox.TabStop = false;
            // 
            // GroupsPictureBox
            // 
            this.GroupsPictureBox.Location = new System.Drawing.Point(132, 249);
            this.GroupsPictureBox.Name = "GroupsPictureBox";
            this.GroupsPictureBox.Size = new System.Drawing.Size(55, 50);
            this.GroupsPictureBox.TabIndex = 3;
            this.GroupsPictureBox.TabStop = false;
            // 
            // likedFriendsListBox
            // 
            this.likedFriendsListBox.FormattingEnabled = true;
            this.likedFriendsListBox.ItemHeight = 18;
            this.likedFriendsListBox.Location = new System.Drawing.Point(404, 163);
            this.likedFriendsListBox.Name = "likedFriendsListBox";
            this.likedFriendsListBox.Size = new System.Drawing.Size(166, 130);
            this.likedFriendsListBox.TabIndex = 2;
            this.likedFriendsListBox.SelectedIndexChanged += new System.EventHandler(this.likedFriendsListBox_SelectedIndexChanged);
            // 
            // likedMusicListBox
            // 
            this.likedMusicListBox.FormattingEnabled = true;
            this.likedMusicListBox.ItemHeight = 18;
            this.likedMusicListBox.Location = new System.Drawing.Point(220, 163);
            this.likedMusicListBox.Name = "likedMusicListBox";
            this.likedMusicListBox.Size = new System.Drawing.Size(152, 130);
            this.likedMusicListBox.TabIndex = 1;
            this.likedMusicListBox.SelectedIndexChanged += new System.EventHandler(this.likedMusicListBox_SelectedIndexChanged);
            // 
            // likedGroupsListBox
            // 
            this.likedGroupsListBox.FormattingEnabled = true;
            this.likedGroupsListBox.ItemHeight = 18;
            this.likedGroupsListBox.Location = new System.Drawing.Point(30, 163);
            this.likedGroupsListBox.Name = "likedGroupsListBox";
            this.likedGroupsListBox.Size = new System.Drawing.Size(157, 130);
            this.likedGroupsListBox.TabIndex = 0;
            this.likedGroupsListBox.SelectedIndexChanged += new System.EventHandler(this.likedGroupsListBox_SelectedIndexChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 370);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.friendsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusicPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupsPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonLogout;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
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
        private System.Windows.Forms.Button button1;
    }
}

