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

        public MostPhotogenicYearAnalyzer(User i_LoggedInUser)
        {
            InitializeComponent();
            r_LoggedInUser = i_LoggedInUser;
            loadPhotoStats();
        }

        private void loadPhotoStats()
        {
            Dictionary<int, int> photosPerYear = new Dictionary<int, int>();

            buildPhotosPerYearDict(photosPerYear);
            if (photosPerYear.Count == 0)
            {
                labelTopYear.Text = "No photos with a valid date were found.";
                return;
            }

            var orderedStats = photosPerYear
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

        private void buildPhotosPerYearDict(Dictionary<int, int> photosPerYear)
        {
            try
            {
                foreach (Album album in r_LoggedInUser.Albums)
                {
                    try
                    {
                        foreach (Photo photo in album.Photos)
                        {
                            if (photo.CreatedTime.HasValue)
                            {
                                int year = photo.CreatedTime.Value.Year;

                                if (!photosPerYear.ContainsKey(year))
                                {
                                    photosPerYear[year] = 0;
                                }

                                photosPerYear[year]++;
                            }
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

    }
}
