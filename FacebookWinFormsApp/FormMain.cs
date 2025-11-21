using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
        }

        FacebookWrapper.LoginResult m_LoginResult;

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns");

            if (m_LoginResult == null)
            {
                login();
            }
        }

        private void login()
        {
            m_LoginResult = FacebookService.Login(
                /// (This is Desig Patter's App ID. replace it with your own)
                textBoxAppID.Text,
                /// requested permissions:
                "email",
                "public_profile"
                /// add any relevant permissions
                , "user_friends",
                "user_likes"
                );

            if (string.IsNullOrEmpty(m_LoginResult.ErrorMessage))
            {
                afterLogin();
            }
        }


        private void buttonConnectAsDesig_Click(object sender, EventArgs e)
        {
            try
            {
                m_LoginResult = FacebookService.Connect("EAAUm6cZC4eUEBPZCFs9rJRpwlUmdHcPvU1tUNkIyP37zRZCjSvfdHaW5t3xsOnUL0bEKHL8Snjk6AZC3O32KWEbaItglEnXWQ2zEMXHqsdfdv0ecXNs3hO69juHrZCfRN9FGvfuJZAXhP4Pm57DRRoDeB8De6ZABnfrRflh6zgPwnavpyHS3ZCYX1E6K1QLTHff5sAZDZD");

                afterLogin();
            }
            catch (Exception ex)
            {
                MessageBox.Show(m_LoginResult.ErrorMessage, "Login Failed");
            }
        }

        private void afterLogin()
        {

            buttonLogin.Text = $"Logged in as {m_LoginResult.LoggedInUser.Name}";
            buttonLogin.BackColor = Color.LightGreen;
            pictureBoxProfile.ImageLocation = m_LoginResult.LoggedInUser.PictureNormalURL;
            buttonLogin.Enabled = false;
            buttonLogout.Enabled = true;

            setUpUserInformationDisplay();
        }

        private void setUpUserInformationDisplay()
        {
            if (m_LoginResult == null)
            {
                throw new Exception("User is not logged in");
            }
            User user = m_LoginResult.LoggedInUser;
            likedGroupsListBox.Items.Clear();
            likedGroupsListBox.DataSource = user.LikedPages;
            likedGroupsListBox.DisplayMember = "Name";
            
            likedMusicListBox.Items.Clear();
            likedMusicListBox.DataSource = user.Music;
            likedMusicListBox.DisplayMember = "Name";

            likedFriendsListBox.Items.Clear();
            likedFriendsListBox.DataSource = user.Friends;
            likedFriendsListBox.DisplayMember = "Name";

        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            buttonLogin.Text = "Login";
            buttonLogin.BackColor = buttonLogout.BackColor;
            m_LoginResult = null;
            buttonLogin.Enabled = true;
            buttonLogout.Enabled = false;
        }

        private void textBoxAppID_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void likedMusicListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MusicPictureBox.ImageLocation = (likedMusicListBox.SelectedItem as Page).PictureNormalURL;
        }

        private void likedGroupsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GroupsPictureBox.ImageLocation = (likedGroupsListBox.SelectedItem as Page).PictureNormalURL;
        }

        private void likedFriendsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            friendsPictureBox.ImageLocation = (likedFriendsListBox.SelectedItem as Page).PictureNormalURL;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ComparingPagesWindow comparingPagesWindow = new ComparingPagesWindow(m_LoginResult.LoggedInUser);
            comparingPagesWindow.ShowDialog();
        }
    }
}
