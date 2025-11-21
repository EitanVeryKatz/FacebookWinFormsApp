using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    internal class ComparingPagesWindow:Form
    {
        private ListBox likedPagesListBox1;
        private Button compareBtn;
        private CheckBox postCommentCheckbox;
        private TextBox postComparisonCommentTextbox;
        private PictureBox winnerPicturebox;
        private Label winnerLabel;
        private readonly User r_LoggedInUser;
        private Page m_PageToCompare1;
        private ListBox likedPagesListBox2;
        private Page m_PageToCompare2;

      




        public ComparingPagesWindow(User i_LoggedInUser)
        {
            r_LoggedInUser = i_LoggedInUser;

            InitializeComponent();
            BindingSource bindingSource1 = new BindingSource();
            BindingSource bindingSource2 = new BindingSource();

            bindingSource1.DataSource = r_LoggedInUser.LikedPages;
            bindingSource2.DataSource = r_LoggedInUser.LikedPages;

            likedPagesListBox1.DataSource = bindingSource1;
            likedPagesListBox2.DataSource = bindingSource2;

            likedPagesListBox1.DisplayMember = "Name";
            likedPagesListBox2.DisplayMember = "Name";
        }

        private void InitializeComponent()
        {
            this.likedPagesListBox1 = new System.Windows.Forms.ListBox();
            this.compareBtn = new System.Windows.Forms.Button();
            this.postCommentCheckbox = new System.Windows.Forms.CheckBox();
            this.postComparisonCommentTextbox = new System.Windows.Forms.TextBox();
            this.winnerPicturebox = new System.Windows.Forms.PictureBox();
            this.winnerLabel = new System.Windows.Forms.Label();
            this.likedPagesListBox2 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.winnerPicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // likedPagesListBox1
            // 
            this.likedPagesListBox1.FormattingEnabled = true;
            this.likedPagesListBox1.Location = new System.Drawing.Point(13, 96);
            this.likedPagesListBox1.Name = "likedPagesListBox1";
            this.likedPagesListBox1.Size = new System.Drawing.Size(157, 238);
            this.likedPagesListBox1.TabIndex = 0;
            this.likedPagesListBox1.SelectedIndexChanged += new System.EventHandler(this.likedPagesListBox1_SelectedIndexChanged);
            // 
            // compareBtn
            // 
            this.compareBtn.Enabled = false;
            this.compareBtn.Location = new System.Drawing.Point(247, 96);
            this.compareBtn.Name = "compareBtn";
            this.compareBtn.Size = new System.Drawing.Size(92, 57);
            this.compareBtn.TabIndex = 2;
            this.compareBtn.Text = "Compare!";
            this.compareBtn.UseVisualStyleBackColor = true;
            this.compareBtn.Click += new System.EventHandler(this.compareBtn_Click);
            // 
            // postCommentCheckbox
            // 
            this.postCommentCheckbox.AutoSize = true;
            this.postCommentCheckbox.Location = new System.Drawing.Point(13, 13);
            this.postCommentCheckbox.Name = "postCommentCheckbox";
            this.postCommentCheckbox.Size = new System.Drawing.Size(218, 19);
            this.postCommentCheckbox.TabIndex = 3;
            this.postCommentCheckbox.Text = "Post a Comment After Comparing?";
            this.postCommentCheckbox.UseVisualStyleBackColor = true;
            this.postCommentCheckbox.CheckedChanged += new System.EventHandler(this.postCommentCheckbox_CheckedChanged);
            // 
            // postComparisonCommentTextbox
            // 
            this.postComparisonCommentTextbox.Enabled = false;
            this.postComparisonCommentTextbox.Location = new System.Drawing.Point(12, 55);
            this.postComparisonCommentTextbox.Name = "postComparisonCommentTextbox";
            this.postComparisonCommentTextbox.Size = new System.Drawing.Size(189, 20);
            this.postComparisonCommentTextbox.TabIndex = 4;
            this.postComparisonCommentTextbox.Text = "Comment to post after comparing...";
            // 
            // winnerPicturebox
            // 
            this.winnerPicturebox.Location = new System.Drawing.Point(232, 215);
            this.winnerPicturebox.Name = "winnerPicturebox";
            this.winnerPicturebox.Size = new System.Drawing.Size(118, 119);
            this.winnerPicturebox.TabIndex = 5;
            this.winnerPicturebox.TabStop = false;
            // 
            // winnerLabel
            // 
            this.winnerLabel.AutoSize = true;
            this.winnerLabel.Location = new System.Drawing.Point(244, 197);
            this.winnerLabel.Name = "winnerLabel";
            this.winnerLabel.Size = new System.Drawing.Size(49, 15);
            this.winnerLabel.TabIndex = 6;
            this.winnerLabel.Text = "Winner:";
            // 
            // likedPagesListBox2
            // 
            this.likedPagesListBox2.FormattingEnabled = true;
            this.likedPagesListBox2.Location = new System.Drawing.Point(518, 96);
            this.likedPagesListBox2.Name = "likedPagesListBox2";
            this.likedPagesListBox2.Size = new System.Drawing.Size(157, 238);
            this.likedPagesListBox2.TabIndex = 7;
            this.likedPagesListBox2.SelectedIndexChanged += new System.EventHandler(this.likedPagesListBox2_SelectedIndexChanged_1);
            // 
            // ComparingPagesWindow
            // 
            this.ClientSize = new System.Drawing.Size(735, 361);
            this.Controls.Add(this.likedPagesListBox2);
            this.Controls.Add(this.winnerLabel);
            this.Controls.Add(this.winnerPicturebox);
            this.Controls.Add(this.postComparisonCommentTextbox);
            this.Controls.Add(this.postCommentCheckbox);
            this.Controls.Add(this.compareBtn);
            this.Controls.Add(this.likedPagesListBox1);
            this.Name = "ComparingPagesWindow";
            ((System.ComponentModel.ISupportInitialize)(this.winnerPicturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void postCommentCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (postCommentCheckbox.Checked)
            {
                enableCommenting();
            }
            else
            {
                disableCommenting();
            }
        }

        private void disableCommenting()
        {
            postComparisonCommentTextbox.Enabled = false;
        }

        private void enableCommenting()
        {
            postComparisonCommentTextbox.Enabled = true;
        }

        private void likedPagesListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_PageToCompare1 = likedPagesListBox1.SelectedItem as Page;
            tryEnableComparing();
        }

        private void tryEnableComparing()
        {
            if (m_PageToCompare1 != null && m_PageToCompare2 != null)
            {
                compareBtn.Enabled = true;
            }
            else
            {
                compareBtn.Enabled = false;
            }
        }

        private void likedPagesListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void compareBtn_Click(object sender, EventArgs e)
        {
            Page winnerPage = comparePages(m_PageToCompare1, m_PageToCompare2);
            winnerLabel.Text = $"Winner: {winnerPage.Name}";
            winnerPicturebox.ImageLocation = winnerPage.PictureNormalURL;
            if (postCommentCheckbox.Checked)
            {
                postComparisonComment(winnerPage);
            }
        }

        private void postComparisonComment(Page winnerPage)
        {
            throw new NotImplementedException();
        }

        private Page comparePages(Page i_PageToCompare1, Page i_PageToCompare2)
        {
            Page winnerPage;
            //TODO : add more comparison criteria
            if (i_PageToCompare1.LikesCount > i_PageToCompare2.LikesCount)
            {
                winnerPage = i_PageToCompare1;
            }
            else
            {
                winnerPage = i_PageToCompare2;
            }

            return winnerPage;
        }

        private void likedPagesListBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            m_PageToCompare2 = likedPagesListBox2.SelectedItem as Page;
            tryEnableComparing();
        }
    }
}