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
        private readonly Dictionary<int, int> r_PhotosPerYear = new Dictionary<int, int>();
        private readonly Dictionary<int, Photo> r_MostRecentPhotoPerYear = new Dictionary<int, Photo>();
        private int m_TotalPhotosCount;
        private LoadingTextAnimator m_LoadingTextAnimator;

        public MostPhotogenicYearAnalyzerForm(User i_LoggedInUser)                         
        {                                                                                  
            InitializeComponent();                                                         
            r_LoggedInUser = i_LoggedInUser;

            m_LoadingTextAnimator = new LoadingTextAnimator(labelTopYear, "Loading photo stats");
            m_LoadingTextAnimator.Start();
            listBoxYearStats.Enabled = false;

            new Thread(() => loadPhotoStats()).Start();
        }

        private void loadPhotoStats()
        {
            r_PhotosPerYear.Clear();
            buildPhotosPerYearDict(r_PhotosPerYear, r_MostRecentPhotoPerYear);
            if (r_PhotosPerYear.Count == 0)
            {
                setTopYearText("No photos with a valid date were found.");
                this.SafelyInvoke(new Action(stopLoadingUi));
                return;
            }

            m_TotalPhotosCount = r_PhotosPerYear.Values.Sum();
            List<int> orderedYears = r_PhotosPerYear
                .OrderByDescending(pair => pair.Value)
                .Select(pair => pair.Key)
                .ToList();

            List<string> yearStatisticsDisplayLines = new List<string>();
            foreach (int year in orderedYears)
            {
                yearStatisticsDisplayLines.Add(string.Format("{0} - {1} photos", year, r_PhotosPerYear[year]));
            }

            setYearStatisticsDisplayLines(yearStatisticsDisplayLines);

            int bestYear = orderedYears[0];
            int bestCount = r_PhotosPerYear[bestYear];

            this.SafelyInvoke(
                new Action(() => labelTopYear.Text = $"Your most photogenic year: {bestYear} ({bestCount} photos)"));

            this.SafelyInvoke(new Action(stopLoadingUi));
        }

        private void stopLoadingUi()
        {
            m_LoadingTextAnimator.Stop();
            listBoxYearStats.Enabled = true;
        }

        private void setYearStatisticsDisplayLines(List<string> i_YearStatisticsDisplayLines)
        {
            if (listBoxYearStats.IsDisposed || !listBoxYearStats.IsHandleCreated)
            {
                return;
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

        private void updateMostRecentPhotoPerYearDict(
            Dictionary<int, Photo> i_MostRecentPhotoPerYear, int year, Photo photo)
        {
            if (!i_MostRecentPhotoPerYear.ContainsKey(year))
            {
                i_MostRecentPhotoPerYear[year] = photo;
            }
            else
            {
                DateTime currentLatestTime = i_MostRecentPhotoPerYear[year].CreatedTime.Value;
                DateTime candidateTime = photo.CreatedTime.Value;

                if (candidateTime > currentLatestTime)
                {
                    i_MostRecentPhotoPerYear[year] = photo;
                }
            }
        }

        private void buildPhotosPerYearDict(Dictionary<int, int> i_PhotosPerYear, 
                                            Dictionary<int, Photo> i_MostRecentPhotoPerYear)
        {                                                                                     
            try                                                                               
            {                                                                                 
                foreach (Album album in r_LoggedInUser.Albums)                                
                {                                                                             
                    try                                                                       
                    {                                                                         
                        foreach (Photo photo in album.Photos)                                 
                        {                                                                     
                            int year = photo.CreatedTime.Value.Year;                          
                                                                                              
                            if (!i_PhotosPerYear.ContainsKey(year))                           
                            {                                                                 
                                i_PhotosPerYear[year] = 0;                                    
                            }                                                                 
                                                                                              
                            i_PhotosPerYear[year]++;
                            updateMostRecentPhotoPerYearDict(i_MostRecentPhotoPerYear, year, photo);
                        }
                    }                                                                         
                    catch (KeyNotFoundException)                                              
                    {                                                                         
                        continue;                                                             
                    }                                                                         
                }                                                                             
            }                                                                                 
            catch (Exception ex)                                                              
            {
                showError("An error occurred while retrieving photos: " + ex.Message);
            }                                                                                 
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
                                                                                              
        private void updateYearDetails(int i_Year)                                            
        {                                                                                     
            if (r_PhotosPerYear == null || !r_PhotosPerYear.ContainsKey(i_Year))              
            {                                                                                 
                labelYearDetails.Text = string.Empty;                                         
                return;                                                                       
            }                                                                                 
                                                                                              
            int countPerYear = r_PhotosPerYear[i_Year];                                       
            double percentageOfYear = 0;                                                      
                                                                                              
            if(m_TotalPhotosCount != 0)                                                       
            {                                                                                 
                percentageOfYear = (countPerYear * 100.0) / m_TotalPhotosCount;               
            }                                                                                 
                                                                                              
            labelYearDetails.Text = $"In {i_Year} you have {countPerYear} photos " +          
                $"({percentageOfYear:F1}% of all your dated photos)";      
            
            Photo topPhoto = null;

            if (r_MostRecentPhotoPerYear.ContainsKey(i_Year))
            {
                topPhoto = r_MostRecentPhotoPerYear[i_Year];
            }

            if (topPhoto != null)                                                             
            {                                                                                 
                pictureBoxTopPhoto.ImageLocation = topPhoto.PictureNormalURL;                 
            }                                                                                 
            else                                                                              
            {                                                                                 
                pictureBoxTopPhoto.Image = null;                                              
            }                                                                                 
        }
    }
}
