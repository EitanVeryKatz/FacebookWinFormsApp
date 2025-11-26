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
        private readonly List<FacebookObject> r_gameItems = new List<FacebookObject>();
        public HigherOrLowerForm(User i_LoggedInUser)
        {
            InitializeComponent();
            r_LoggedInUser = i_LoggedInUser;
        }

        private void startNewGameBtn_Click(object sender, EventArgs e)
        {
            if(r_gameItems.Count == 0)
            {
                setupGameItems();
            }

            try
            {
                r_HigherLowerGameLogic.SetupNewGame(r_gameItems);
            }
            catch (Exception ex)
            {
                StringBuilder errorMessage = new StringBuilder(ex.Message);
                errorMessage.AppendLine("Starting game with dummy values...");
                MessageBox.Show(errorMessage.ToString());
                r_HigherLowerGameLogic.SetupNewGameWithDummyValues(r_gameItems);
            }
            finally
            {
                updateControllsForNewRound();
            }
        }

        private void setupGameItems()
        {
            try { r_gameItems.AddRange(r_LoggedInUser.Groups); }
            catch (Exception) { }
            try{r_gameItems.AddRange(r_LoggedInUser.LikedPages);}
            catch (Exception) { }
            try { r_gameItems.AddRange(r_LoggedInUser.Posts); }
            catch (Exception) { }
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
            currentGameItemValueLabel.Text = $"Current Value: {r_HigherLowerGameLogic.CurrentItemValue}";
            this.BackColor = SystemColors.Control;
        }

        private void updateHighScoreLabel()
        {
            highscoreLabel.Text = $"Highscore: {r_HigherLowerGameLogic.MaxScore}";
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
            this.BackColor = Color.Red;
            updateHighScoreLabel();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void HigherOrLowerForm_Load(object sender, EventArgs e)
        {

        }

        private void rulesBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("every turn you must guess whether" +
                " the next item's value is higher or lower" +
                " than the current item's value." +
                " If you guess correctly, you earn a point and" +
                " continue to the next round." +
                " The game continues until you make" +
                " an incorrect guess." +
                " Try to achieve the highest score possible!");
        }
    }
}
