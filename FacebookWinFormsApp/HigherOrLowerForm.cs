using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class HigherOrLowerForm : Form
    {
        private readonly User r_LoggedInUser;
        private readonly FacebookObjectAdapterFactory r_FacebookAdapterFactory = new FacebookObjectAdapterFactory();
        private readonly HigherLowerGameLogic r_HigherLowerGameLogic = new HigherLowerGameLogic();
        private readonly List<IFacebookObjectAdapter> r_gameItems = new List<IFacebookObjectAdapter>();           
        private const string k_RulesMessage = "every turn you must guess whether" +               
                " the next item's value is higher or lower" +                                     
                " than the current item's value." +                                               
                " If you guess correctly, you earn a point and" +                                 
                " continue to the next round." +                                                  
                " The game continues until you make" +                                            
                " an incorrect guess." +                                                          
                " Try to achieve the highest score possible!";                                    
                                                                                                  
        public HigherOrLowerForm(User i_LoggedInUser)                                             
        {                                                                                         
            InitializeComponent();                                                                
            r_LoggedInUser = i_LoggedInUser;
            r_FacebookAdapterFactory.UploadingUser = r_LoggedInUser;
            HigherLowerDataSource.DataSource = r_HigherLowerGameLogic;
        }                                                                                         
                                                                                                  
        private void startNewGameBtn_Click(object sender, EventArgs e)                            
        {                                                                                         
            if(r_gameItems.Count == 0)                                                            
            {                                                                                     
                setupGameItems();                                                                 
            }                                                                                     
                                                                                                  
            try                                                                                   
            {                                                                                     
                new Thread(() => MessageBox.Show("Game is loading...\nPlease wait...")).Start();
                                                                                                                   
                r_HigherLowerGameLogic.SetupNewGame(r_gameItems);                                                  
            }                                                                                                      
            catch (Exception ex)                                                                                   
            {                                                                                                      
                StringBuilder errorMessage = new StringBuilder(ex.Message);                                        
                                                                                                                   
                errorMessage.AppendLine("Starting game with dummy values...");                           
                new Thread(() => MessageBox.Show(errorMessage.ToString())).Start();       
                                                                                                                   
                r_HigherLowerGameLogic.SetupNewGameWithDummyValues(r_gameItems);                                   
            }                                                                                                      
            finally                                                                                                
            {                                                                                                      
                updateControllsForNewRound();                                                                      
            }                                                                                                      
        }                                                                                                          
                                                                                                                   
        private void setupGameItems()                                                                              
        {

            try
            {
                r_gameItems.AddRange(r_FacebookAdapterFactory.CreateFacebookObjectAdapterList(r_LoggedInUser.Groups));
            }
            catch (Exception) { }
            try
            {
                r_gameItems.AddRange(r_FacebookAdapterFactory.CreateFacebookObjectAdapterList(r_LoggedInUser.LikedPages));
            }
            catch (Exception) { }
            try
            {
                r_gameItems.AddRange(r_FacebookAdapterFactory.CreateFacebookObjectAdapterList(r_LoggedInUser.Posts));
            }
            catch (Exception) { }                                                                         
        }                                                                                                          
                                                                                                                   
        private void updateControllsForNewRound()                                                                  
        {                                                                                                          
            IFacebookObjectAdapter currentItem = r_HigherLowerGameLogic.CurrentItem;                                       
            IFacebookObjectAdapter nextItem = r_HigherLowerGameLogic.NextItem;                                             
                                                                                                                   
            updatePictureBox(currentGroupOrProfilePictureBox, currentPostOrGroupNameLabel, currentItem);           
            updatePictureBox(nextGroupOrProfilePictureBox, nextPostOrGroupNameLabel, nextItem);                    
            scoreLabel.Invoke(new Action(() => scoreLabel.Text = $"Score: {r_HigherLowerGameLogic.Score}"));                                            
            higherBtn.Invoke(new Action(() => higherBtn.Enabled = true));                                                                              
            lowerBtn.Invoke(new Action(() => lowerBtn.Enabled = true));                                                                               
            startNewGameBtn.Invoke(new Action(() => startNewGameBtn.Enabled = false));                                                                       
            currentGameItemValueLabel.Invoke(new Action(() => currentGameItemValueLabel.Text = $"Current Value: {r_HigherLowerGameLogic.CurrentItemValue}"));          
            this.BackColor = SystemColors.Control;                                                                 
            thanLabel.Invoke(new Action(() => thanLabel.Text = "than"));                                                                               
            isLabel.Invoke(new Action(() => isLabel.Text = "is"));                                                                                   
        }                                                                                                          
                                                                                                                   
        private void updatePictureBox(PictureBox i_GroupOrProfilePictureBox, Label i_Label, IFacebookObjectAdapter i_Item) 
        {                                                                                                          
                i_Label.Invoke(new Action(() => i_Label.Text = i_Item.Text));                                                           
                i_GroupOrProfilePictureBox.Load(i_Item.ImageUrl);                               
        }                                                                                                          
                                                                                                                   
        private void higherBtn_Click(object sender, EventArgs e)
        {
            disableAllGameButtons();
            new Thread(ProcessGuessHigher).Start();
        }

        private void ProcessGuessHigher()
        {
            r_HigherLowerGameLogic.MakeGuessCurrentIsHigher();
            checkWin();
        }

        private void disableAllGameButtons()
        {
            higherBtn.Invoke(new Action(() => higherBtn.Enabled = false));
            lowerBtn.Invoke(new Action(() => lowerBtn.Enabled = false));
            startNewGameBtn.Invoke(new Action(() => startNewGameBtn.Enabled = false));
        }

        private void endGame()                                                                                     
        {                                                                                                          
            lowerBtn.Invoke(new Action(() => lowerBtn.Enabled = false));                                                                              
            higherBtn.Invoke(new Action(() => higherBtn.Enabled = false));                                                                             
            startNewGameBtn.Invoke(new Action(() => startNewGameBtn.Enabled = true));                                                                        
            this.BackColor = Color.Red;                                                                            
        }                                                                                                          
                                                                                                                   
        private void lowerBtn_Click(object sender, EventArgs e)
        {
            disableAllGameButtons();
            new Thread(peocessGuessLower).Start();
        }

        private void peocessGuessLower()
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
                                                                                                                   
        private void rulesBtn_Click(object sender, EventArgs e)                                                    
        {                                                                                                          
            MessageBox.Show(k_RulesMessage);                                                                       
        }                                                                                                          
    }                                                                                                              
}                                                                                                                  
