using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class HigherOrLowerForm : Form
    {
        private readonly User r_LoggedInUser;
        private readonly HigherLowerGameLogic r_HigherLowerGameLogic = new HigherLowerGameLogic();
        public HigherOrLowerForm(User i_LoggedInUser)
        {
            InitializeComponent();
            r_LoggedInUser = i_LoggedInUser;
        }

        private void startNewGameBtn_Click(object sender, EventArgs e)
        {
            List<FacebookObject> gameItems = new List<FacebookObject>();
            try { gameItems.AddRange(r_LoggedInUser.Groups); }
            catch (Exception) { }
            //  try{gameItems.AddRange(r_LoggedInUser.LikedPages);}
            //catch (Exception) { }
            try { gameItems.AddRange(r_LoggedInUser.Posts); }
            catch (Exception) { }
            try 
            {
                r_HigherLowerGameLogic.SetupNewGame(gameItems);
                updateControllsForNewRound();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void updateControllsForNewRound()
        {
            FacebookObject currentItem = r_HigherLowerGameLogic.CurrentItem;
            FacebookObject nextItem = r_HigherLowerGameLogic.NextItem;

            updatePictureBox(currentGroupOrProfilePictureBox, currentPostOrGroupNameLabel, currentItem);
            updatePictureBox(nextGroupOrProfilePictureBox, nextPostOrGroupNameLabel, nextItem);

            scoreLabel.Text = $"Score: {r_HigherLowerGameLogic.Score}";
            higherBtn.Enabled = true;
            lowerBtn.Enabled = true;
            startNewGameBtn.Enabled = false;
        }

        private void updatePictureBox(PictureBox i_GroupOrProfilePictureBox,Label i_Label, FacebookObject i_Item)
        {
            if (i_Item is Group)
            {

                i_Label.Text = (i_Item as Group).Name;
                i_GroupOrProfilePictureBox.Load((i_Item as Group).PictureNormalURL);
            }
            else if (i_Item is Page)
            {
                i_Label.Text = (i_Item as Page).Name;
                i_GroupOrProfilePictureBox.Load((i_Item as Page).PictureNormalURL);
            }
            else if (i_Item is Post)
            {
                i_Label.Text = (i_Item as Post).Message;
                i_GroupOrProfilePictureBox.Load(r_LoggedInUser.PictureNormalURL);
            }
        }

        private void higherBtn_Click(object sender, EventArgs e)
        {
            r_HigherLowerGameLogic.MakeGuessCurrentIsHigher();
            checkWin();
        }

        private void endGame()
        {
            lowerBtn.Enabled = false;
            higherBtn.Enabled = false;
            startNewGameBtn.Enabled = true;
        }

        private void lowerBtn_Click(object sender, EventArgs e)
        {
            r_HigherLowerGameLogic.MakeGuessCurrentIsLower();
            checkWin();
        }

        private void checkWin()
        {
            if (r_HigherLowerGameLogic.GameIsRunning)
            {
                updateControllsForNewRound();
            }
            else
            {
                endGame();
            }
        }
    }
}
