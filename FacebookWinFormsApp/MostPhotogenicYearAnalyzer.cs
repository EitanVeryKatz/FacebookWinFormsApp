using FacebookWrapper;
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
    public partial class MostPhotogenicYearAnalyzer : Form
    {
        private readonly User r_LoggedInUser;
        private Dictionary<int, int> m_PhotosPerYear;
        private int m_TotalPhotosCount;

        public MostPhotogenicYearAnalyzer(User i_LoggedInUser)
        {
            InitializeComponent();
            r_LoggedInUser = i_LoggedInUser;
            loadPhotoStats();
        }

        private void loadPhotoStats()
        {
            m_PhotosPerYear = new Dictionary<int, int>();

            buildPhotosPerYearDict(m_PhotosPerYear);
            if (m_PhotosPerYear.Count == 0)
            {
                labelTopYear.Text = "No photos with a valid date were found.";
                return;
            }

            m_TotalPhotosCount = m_PhotosPerYear.Values.Sum();
            var orderedStats = m_PhotosPerYear
                .OrderByDescending(yearStat => yearStat.Value)
                .ToList();

            listBoxYearStats.Items.Clear();
            foreach (var yearStat in orderedStats)
            {
                listBoxYearStats.Items.Add($"{yearStat.Key} - {yearStat.Value} photos");
            }

            int bestYear = orderedStats[0].Key;
            int bestCount = orderedStats[0].Value;
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
            if (m_PhotosPerYear == null || !m_PhotosPerYear.ContainsKey(i_Year))
            {
                labelYearDetails.Text = string.Empty;
                return;
            }

            int countPerYear = m_PhotosPerYear[i_Year];
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
