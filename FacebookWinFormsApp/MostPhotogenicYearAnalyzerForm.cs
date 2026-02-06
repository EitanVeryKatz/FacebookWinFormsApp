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
        private LoadingTaskRunner m_LoadingTaskRunner = new LoadingTaskRunner();

        public MostPhotogenicYearAnalyzerForm(User i_LoggedInUser)                         
        {                                                                                  
            InitializeComponent();                                                         
            r_LoggedInUser = i_LoggedInUser;
            r_MostPhotogenicYearAnalyzer = new MostPhotogenicYearAnalyzer(r_LoggedInUser, new LikesMetricStrategy());  
            listBoxYearStats.Enabled = false;
        }

        private void loadPhotoStats()
        {
            this.SafelyInvoke(new Action(() => loadStatsBtn.Enabled = false));
            this.SafelyInvoke(new Action(() => listBoxYearStats.Enabled = false));

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
                return;
            }

            setYearStatisticsDisplayLines();
        }

        private void doAfterLoadingStats()
        {
            if (r_MostPhotogenicYearAnalyzer.TotalPhotos == 0)
            {
                setTopYearText("No photos were found.");
            }
            else 
            {
                setTopYearText($"Your most photogenic year: {r_MostPhotogenicYearAnalyzer.BestYear} " +
                               $"({r_MostPhotogenicYearAnalyzer.BestYearMetricValue} likes)");
            }
           
            this.SafelyInvoke(new Action(() => listBoxYearStats.Enabled = true));
            this.SafelyInvoke(new Action(() => loadStatsBtn.Enabled = true));
        }

        private void setYearStatisticsDisplayLines()
        {
            if (listBoxYearStats.IsDisposed || !listBoxYearStats.IsHandleCreated)
            {
                return;
            }

            List<string> i_YearStatisticsDisplayLines = new List<string>();

            foreach(YearMetricInfo yearLikesInfo in r_MostPhotogenicYearAnalyzer)
            {
                i_YearStatisticsDisplayLines.
                    Add(string.Format("{0} - {1} likes", yearLikesInfo.Year, yearLikesInfo.MetricValue));
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
                                                                                              
            long LikesCountPerYear = r_MostPhotogenicYearAnalyzer.GetMetricValueOfYear(i_CurrentYear);                                       
            double percentageOfYear = 0;                                                      
                                                                                              
            if(r_MostPhotogenicYearAnalyzer.TotalPhotosMetricValue != 0)                                                       
            {                                                                                 
                percentageOfYear = (LikesCountPerYear * 100.0) / r_MostPhotogenicYearAnalyzer.TotalPhotosMetricValue;               
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

        private void loadStatsBtn_Click(object sender, EventArgs e)
        {
            m_LoadingTaskRunner.BaseLoadingText = "Loading photo stats";
            m_LoadingTaskRunner.LoadingStrategy = loadPhotoStats;
            m_LoadingTaskRunner.AfterLoadingStrategy = doAfterLoadingStats;
            m_LoadingTaskRunner.RunLoadingTask(labelTopYear);
        }
    }
}
