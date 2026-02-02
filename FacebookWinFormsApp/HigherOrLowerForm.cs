using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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
        private const string k_GameObjectWithDefaultValueDetectedMessage = "A value for a game object was not loaded correctly..." +
            "\nSome game items might hold random default values";
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
            r_HigherLowerGameLogic.GameObjectWithDefaultValueDetected += new Action(()=>
                new Thread(() => 
                    MessageBox.Show(k_GameObjectWithDefaultValueDetectedMessage)).Start());
        }

        private void startNewGameBtn_Click(object sender, EventArgs e)
        {
            LoadingTextAnimator loadingTextAnimator = new LoadingTextAnimator(loadingLabel, "Starting new game");
            loadingTextAnimator.Start();
            new Thread(() => startNewGame(loadingTextAnimator)).Start();
        }


        private void startNewGame(LoadingTextAnimator i_LoadingTextAnimator)
        {
            List<IFacebookObjectAdapter> gameItems = new List<IFacebookObjectAdapter>();
            if (!r_HigherLowerGameLogic.ItemsAreLoaded)
            {
                setupGameItems(gameItems);
            }

            try
            {
                r_HigherLowerGameLogic.SetupNewGame(gameItems);
            }
            catch (Exception ex)
            {
                StringBuilder errorMessage = new StringBuilder(ex.Message);

                errorMessage.AppendLine("Starting game with dummy values...");
                new Thread(() => MessageBox.Show(errorMessage.ToString())).Start();
                r_HigherLowerGameLogic.SetupNewGameWithDummyValues(gameItems);
            }
            finally
            {
                updateControllsForNewRound();
                i_LoadingTextAnimator.Stop();
            }
        }

        private void setupGameItems(List<IFacebookObjectAdapter> i_GameItemCollection)                                                                              
        {
            try
            {
                i_GameItemCollection.AddRange(r_FacebookAdapterFactory.CreateFacebookObjectAdapterList(r_LoggedInUser.Groups));
            }
            catch (Exception) { }
            try
            {
                i_GameItemCollection.AddRange(r_FacebookAdapterFactory.CreateFacebookObjectAdapterList(r_LoggedInUser.LikedPages));
            }
            catch (Exception) { }
            try
            {
                i_GameItemCollection.AddRange(r_FacebookAdapterFactory.CreateFacebookObjectAdapterList(r_LoggedInUser.Posts));
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
            new Thread(processGuessHigher).Start();
        }

        private void processGuessHigher()
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
            highschoreValueLabel.Invoke(new Action(() => highschoreValueLabel.Text = r_HigherLowerGameLogic.MaxScore.ToString()));
        }                                                                                                          
                                                                                                                   
        private void lowerBtn_Click(object sender, EventArgs e)
        {
            disableAllGameButtons();
            new Thread(processGuessLower).Start();
        }

        private void processGuessLower()
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

        private void statisticsBtn_Click(object sender, EventArgs e)
        {
            LoadingTextAnimator loadingTextAnimator = new LoadingTextAnimator(loadingLabel, "Calculating statistics");
            loadingTextAnimator.Start();
            new Thread(()=>showStatistics(loadingTextAnimator)).Start();
        }

        private void showStatistics(LoadingTextAnimator i_LoadingTextAnimator)
        {
            try
            {
                float averageValue = 0;
                int propperlyLoadedItemsCount = 0;
                int totalItemValue = 0;
                long maximumItemValue = 0;
                long currentItemScore = r_HigherLowerGameLogic.CurrentItem.LikesCount;
                int itemsHigherThanCurrent = 0;
                int itemsLowerThanCurrent = 0;
                float bestMoveAccuracy = 0;

                StringBuilder statisticsMessage = new StringBuilder();
                foreach (IFacebookObjectAdapter gameItem in r_HigherLowerGameLogic)
                {
                    propperlyLoadedItemsCount++;
                    totalItemValue += (int)gameItem.LikesCount;
                    maximumItemValue = Math.Max(maximumItemValue, gameItem.LikesCount);
                    if (gameItem.LikesCount > currentItemScore)
                    {
                        itemsHigherThanCurrent++;
                    }

                    if (gameItem.LikesCount < currentItemScore)
                    {
                        itemsLowerThanCurrent++;
                    }
                }

                if (propperlyLoadedItemsCount > 0)
                {
                    averageValue = (float)totalItemValue / propperlyLoadedItemsCount;
                }

                bool bestMoveIsHigher = itemsLowerThanCurrent > itemsHigherThanCurrent;


                if (propperlyLoadedItemsCount > 0)
                {
                    int winningItemsCount = bestMoveIsHigher ? itemsHigherThanCurrent : itemsLowerThanCurrent;
                    bestMoveAccuracy = 100 - ((float)winningItemsCount / propperlyLoadedItemsCount) * 100;
                }

                statisticsMessage.AppendLine($"Total properly loaded items: {propperlyLoadedItemsCount}");
                statisticsMessage.AppendLine($"Average item value: {averageValue}");
                statisticsMessage.AppendLine($"Best move is to guess that the currtnt item is {(bestMoveIsHigher ? "HIGHER" : "LOWER")}");
                statisticsMessage.AppendLine($"Best move accuracy: {bestMoveAccuracy}%");
                new Thread(()=>MessageBox.Show(statisticsMessage.ToString())).Start();
            }
            catch (Exception)
            {
                new Thread(() => MessageBox.Show($"Error showing statistics: Game Not Loaded")).Start();
            }
            finally
            {
                i_LoadingTextAnimator.Stop();
            }
        }
    }                                                                                                              
}                                                                                                                  
