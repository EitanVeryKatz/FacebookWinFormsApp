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
        private FacebookWrapper.LoginResult m_LoginResult;
        private readonly List<string> r_userPosts = new List<string>();

        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
        }
        
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText("design.patterns");

                if (m_LoginResult == null)
                {
                    login();
                }
            }catch(Exception)
            {
                MessageBox.Show("Failed to connect to Facebook.\nCheck your connection...");
            }
        }

        private void login()
        {
            m_LoginResult = FacebookService.Login(
                /// (This is Desig Patter's App ID. replace it with your own)
                textBoxAppID.Text,
                /// requested permissions:
                "email",
                "public_profile",
                /// add any relevant permissions
                "user_friends",
                "user_likes",
                "user_photos",
                "user_posts"
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
            catch (Exception)
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
            
            r_userPosts.Clear();
            foreach (Post post in user.Posts)
            {
                string postStatus = post.Message;
            
                if (!string.IsNullOrEmpty(postStatus))
                {
                    r_userPosts.Add(post.Message);
                }
            }

            likedGroupsListBox.Items.Clear();
            likedGroupsListBox.DataSource = user.LikedPages;
            likedGroupsListBox.DisplayMember = "Name";
            
            likedMusicListBox.Items.Clear();
            likedMusicListBox.DataSource = user.Music;
            likedMusicListBox.DisplayMember = "Name";

            likedFriendsListBox.Items.Clear();
            likedFriendsListBox.DataSource = user.Friends;
            likedFriendsListBox.DisplayMember = "Name";

            profilePictureBox.ImageLocation = user.PictureNormalURL;
            postsComboBox.DataSource = r_userPosts;
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
            if (m_LoginResult == null || m_LoginResult.LoggedInUser == null)
            {
                MessageBox.Show("Please login first.");
                return;
            }

            //            ComparingPagesWindow comparingPagesWindow = new ComparingPagesWindow(m_LoginResult.LoggedInUser);
            //            comparingPagesWindow.ShowDialog();

            HigherOrLowerForm higherOrLowerForm = new HigherOrLowerForm(m_LoginResult.LoggedInUser);
            higherOrLowerForm.ShowDialog();
        }

        private void buttonMostPhotogenicYear_Click(object sender, EventArgs e)
        {
            if (m_LoginResult == null || m_LoginResult.LoggedInUser == null)
            {
                MessageBox.Show("Please login first.");
                return;
            }

            MostPhotogenicYearAnalyzer mostPhotogenicYearAnalyzer = new MostPhotogenicYearAnalyzer(m_LoginResult.LoggedInUser);
            {
                mostPhotogenicYearAnalyzer.ShowDialog();
            }
        }

        private void selectPostBtn_Click(object sender, EventArgs e)
        {
            string chosenPost = postsComboBox.Items[postsComboBox.SelectedIndex] as string;
            currentFavoritePostLabel.Text = chosenPost;
        }

        private void postsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectPostBtn.Enabled = true;
        }
    }
}
