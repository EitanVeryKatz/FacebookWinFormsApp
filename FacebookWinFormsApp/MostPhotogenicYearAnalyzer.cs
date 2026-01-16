using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicFacebookFeatures
{
    public class MostPhotogenicYearAnalyzer
    {
        private readonly User r_LoggedInUser;
        private readonly Dictionary<int, long> r_PhotosLikesPerYear = new Dictionary<int, long>();
        private readonly Dictionary<int, FbPhotoAdapter> r_MostLikedPhotoPerYear = new Dictionary<int, FbPhotoAdapter>();

        public List<YearLikesInfo> YearStatisticsList { get; private set; }
        public long TotalPhotosLikes { get; private set; } = 0;
        public int BestYear { get; private set; } = 0;
        public long BestYearLikes
        {
            get
            {
                return r_PhotosLikesPerYear.ContainsKey(BestYear) ? r_PhotosLikesPerYear[BestYear] : 0;
            }

            private set { }
        }
        public int TotalPhotos { get; private set; } = 0;


        public MostPhotogenicYearAnalyzer(User i_LoggedInUser)
        {
            r_LoggedInUser = i_LoggedInUser;
        }

        public void Analyze()
        {
            buildPhotosLikesPerYearDict();
            BuildYearStatisticsProps();
            BestYearLikes = GetLikesOfYear(BestYear);
            TotalPhotosLikes = r_PhotosLikesPerYear.Values.Sum();
        }

        private void buildPhotosLikesPerYearDict()
        {
            foreach (Album album in r_LoggedInUser.Albums)
            {
                try
                {
                    foreach (Photo photo in album.Photos)
                    {
                        int year = photo.CreatedTime.Value.Year;
                        FbPhotoAdapter photoAdapter = new FbPhotoAdapter(photo);

                        if (!r_PhotosLikesPerYear.ContainsKey(year))
                        {
                            r_PhotosLikesPerYear[year] = 0;
                        }

                        r_PhotosLikesPerYear[year] += photoAdapter.LikesCount;
                        TotalPhotos++;
                        updateMostLikedPhotoPerYearDict(r_MostLikedPhotoPerYear, year, photoAdapter);
                    }
                }
                catch (KeyNotFoundException)
                {
                    continue;
                }
            }
        }

        private void updateMostLikedPhotoPerYearDict(
            Dictionary<int, FbPhotoAdapter> i_MostLikedPhotoPerYear, int i_CurrentYear, FbPhotoAdapter i_PhotoAdapter)
        {
            if (!i_MostLikedPhotoPerYear.ContainsKey(i_CurrentYear))
            {
                i_MostLikedPhotoPerYear[i_CurrentYear] = i_PhotoAdapter;
            }
            else
            {
                long currentLikesCount = i_MostLikedPhotoPerYear[i_CurrentYear].LikesCount;
                long candidateLikesCount = i_PhotoAdapter.LikesCount;

                if (candidateLikesCount > currentLikesCount)
                {
                    i_MostLikedPhotoPerYear[i_CurrentYear] = i_PhotoAdapter;
                }
            }
        }

        private void BuildYearStatisticsProps()
        {
            YearStatisticsList = new List<YearLikesInfo>();

            List<int> orderedYears = r_PhotosLikesPerYear
                .OrderByDescending(pair => pair.Value)
                .Select(pair => pair.Key)
                .ToList();

            foreach (int year in orderedYears)
            {
                YearStatisticsList.Add(new YearLikesInfo(year, r_PhotosLikesPerYear[year]));
            }

            BestYear = orderedYears.Count > 0 ? orderedYears.First() : 0;
        }

        public long GetLikesOfYear(int i_Year)
        {
            return r_PhotosLikesPerYear.ContainsKey(i_Year) ? r_PhotosLikesPerYear[i_Year] : 0;
        }

        public FbPhotoAdapter GetTopPhotoOfYear(int i_Year)
        {
            return r_MostLikedPhotoPerYear.ContainsKey(i_Year) ? r_MostLikedPhotoPerYear[i_Year] : null;
        }
    }
}
