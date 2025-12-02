using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class MostPhotogenicYearAnalyzerForm : Form
    {
        private readonly User r_LoggedInUser;
        private readonly Dictionary<int, int> r_PhotosPerYear = new Dictionary<int, int>();
        private int m_TotalPhotosCount;                                                    
                                                                                           
        public MostPhotogenicYearAnalyzerForm(User i_LoggedInUser)                         
        {                                                                                  
            InitializeComponent();                                                         
            r_LoggedInUser = i_LoggedInUser;                                               
            loadPhotoStats();                                                              
        }                                                                                  
                                                                                           
        private void loadPhotoStats()                                                      
        {                                                                                  
            r_PhotosPerYear.Clear();                                                       
            buildPhotosPerYearDict(r_PhotosPerYear);                                       
            if (r_PhotosPerYear.Count == 0)                                                
            {                                                                              
                labelTopYear.Text = "No photos with a valid date were found.";             
                return;                                                                    
            }                                                                              
                                                                                           
            m_TotalPhotosCount = r_PhotosPerYear.Values.Sum();
            List<int> orderedYears = r_PhotosPerYear
                .OrderByDescending(pair => pair.Value)
                .Select(pair => pair.Key)
                .ToList();

            listBoxYearStats.Items.Clear();
            foreach (int year in orderedYears)
            {
                listBoxYearStats.Items.Add($"{year} - {r_PhotosPerYear[year]} photos");
            }

            int bestYear = orderedYears[0];
            int bestCount = r_PhotosPerYear[bestYear];
                                                                                           
            labelTopYear.Text = $"Your most photogenic year: {bestYear} ({bestCount} photos)";
        }                                                                                     
                                                                                              
        private void buildPhotosPerYearDict(Dictionary<int, int> i_PhotosPerYear)             
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
                MessageBox.Show("An error occurred while retrieving photos: " + ex.Message);  
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
            Photo topPhoto = findMostRecentPhotoForYear(i_Year);                              
                                                                                              
            if (topPhoto != null)                                                             
            {                                                                                 
                pictureBoxTopPhoto.ImageLocation = topPhoto.PictureNormalURL;                 
            }                                                                                 
            else                                                                              
            {                                                                                 
                pictureBoxTopPhoto.Image = null;                                              
            }                                                                                 
        }                                                                                     
                                                                                              
        private Photo findMostRecentPhotoForYear(int i_Year)                                  
        {                                                                                     
            Photo latestPhotoOfYear = null;                                                   
            DateTime latestTime = DateTime.MinValue;                                          
                                                                                              
            foreach (Album album in r_LoggedInUser.Albums)                                    
            {                                                                                 
                try                                                                           
                {                                                                             
                    foreach (Photo photo in album.Photos)                                     
                    {                                                                         
                        if (!photo.CreatedTime.HasValue)                                      
                        {                                                                     
                            continue;                                                         
                        }                                                                     
                                                                                              
                        if (photo.CreatedTime.Value.Year != i_Year)                           
                        {                                                                     
                            continue;                                                         
                        }                                                                     
                                                                                              
                        DateTime photoTime = photo.CreatedTime.Value;                         
                                                                                              
                        if (photoTime > latestTime)                                           
                        {                                                                     
                            latestTime = photoTime;                                           
                            latestPhotoOfYear = photo;                                        
                        }                                                                     
                    }                                                                         
                }                                                                             
                catch                                                                         
                {                                                                             
                    continue;                                                                 
                }                                                                             
            }                                                                                 
                                                                                              
            return latestPhotoOfYear;                                                         
        }                                                                                     
    }                                                                                         
}
