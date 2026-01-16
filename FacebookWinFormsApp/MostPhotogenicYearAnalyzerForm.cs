using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace BasicFacebookFeatures
{
    public partial class MostPhotogenicYearAnalyzerForm : Form
    {
        private readonly User r_LoggedInUser;
        private readonly MostPhotogenicYearAnalyzer r_MostPhotogenicYearAnalyzer;
        private LoadingTextAnimator m_LoadingTextAnimator;

        public MostPhotogenicYearAnalyzerForm(User i_LoggedInUser)                         
        {                                                                                  
            InitializeComponent();                                                         
            r_LoggedInUser = i_LoggedInUser;
            r_MostPhotogenicYearAnalyzer = new MostPhotogenicYearAnalyzer(r_LoggedInUser);
            m_LoadingTextAnimator = new LoadingTextAnimator(labelTopYear, "Loading photo stats");
            m_LoadingTextAnimator.Start();
            listBoxYearStats.Enabled = false;

            new Thread(() => loadPhotoStats()).Start();
        }

        private void loadPhotoStats()
        {
            try
            {
                r_MostPhotogenicYearAnalyzer.Analyze();
            }
            catch (Exception ex)
            {
                showError("An error occurred while initializing the analyzer: " + ex.Message);

                return;
            }

            if (r_MostPhotogenicYearAnalyzer.TotalPhotos == 0)
            {
                setTopYearText("No photos were found.");
                this.SafelyInvoke(new Action(stopLoadingUi));

                return;
            }

            setYearStatisticsDisplayLines(r_MostPhotogenicYearAnalyzer.YearStatisticsList);

            this.SafelyInvoke(
                new Action(() => labelTopYear.Text = 
                $"Your most photogenic year: {r_MostPhotogenicYearAnalyzer.BestYear} " +
                $"({r_MostPhotogenicYearAnalyzer.BestYearLikes} likes)"));

            this.SafelyInvoke(new Action(stopLoadingUi));
        }

        private void stopLoadingUi()
        {
            m_LoadingTextAnimator.Stop();
            listBoxYearStats.Enabled = true;
        }

        private void setYearStatisticsDisplayLines(List<YearLikesInfo> i_YearStatistics)
        {
            if (listBoxYearStats.IsDisposed || !listBoxYearStats.IsHandleCreated)
            {
                return;
            }

            List<string> i_YearStatisticsDisplayLines = new List<string>();

            foreach(YearLikesInfo yearLikesInfo in i_YearStatistics)
            {
                i_YearStatisticsDisplayLines.
                    Add(string.Format("{0} - {1} likes", yearLikesInfo.Year, yearLikesInfo.Likes));
            }

            this.SafelyInvoke(
                new Action(() => applyYearStatisticsDisplayLines(i_YearStatisticsDisplayLines)));
        }

        private void applyYearStatisticsDisplayLines(List<string> i_YearStatisticsDisplayLines)
        {
            listBoxYearStats.Items.Clear();

            foreach (string displayLine in i_YearStatisticsDisplayLines)
            {
                listBoxYearStats.Items.Add(displayLine);
            }
        }


        private void setTopYearText(string i_Text)
        {
            this.SafelyInvoke(new Action(() => labelTopYear.Text = i_Text));
        }

        private void showError(string i_Text)
        {
            this.SafelyInvoke(new Action(() => MessageBox.Show(i_Text)));
        }
                                                                                
        private void listBoxYearStats_SelectedIndexChanged(object sender, EventArgs e)        
        {                                                                                     
            if (listBoxYearStats.SelectedItem == null)                                        
            {                                                                                 
                return;                                                                       
            }                                                                                 
                                                                                              
            String itemText = listBoxYearStats.SelectedItem.ToString();                       
            int year = int.Parse(itemText.Split('-')[0].Trim());                              
                                                                                             
            updateYearDetails(year);                                                          
        }                                                                                     
                                                                                              
        private void updateYearDetails(int i_CurrentYear)                                            
        {                                                                                                                                                      
                                                                                              
            long LikesCountPerYear = r_MostPhotogenicYearAnalyzer.GetLikesOfYear(i_CurrentYear);                                       
            double percentageOfYear = 0;                                                      
                                                                                              
            if(r_MostPhotogenicYearAnalyzer.TotalPhotosLikes != 0)                                                       
            {                                                                                 
                percentageOfYear = (LikesCountPerYear * 100.0) / r_MostPhotogenicYearAnalyzer.TotalPhotosLikes;               
            }                                                                                 
                                                                                              
            labelYearDetails.Text = $"In {i_CurrentYear} you have {LikesCountPerYear} likes " +          
                $"({percentageOfYear:F1}% of all your overall photo's likes)";      
            
            FbPhotoAdapter topPhoto = r_MostPhotogenicYearAnalyzer.GetTopPhotoOfYear(i_CurrentYear);

            if (topPhoto != null)                                                             
            {                                                                                 
                pictureBoxTopPhoto.ImageLocation = topPhoto.ImageUrl;                 
            }                                                                                 
            else                                                                              
            {                                                                                 
                pictureBoxTopPhoto.Image = null;                                              
            }                                                                                 
        }
    }
}
