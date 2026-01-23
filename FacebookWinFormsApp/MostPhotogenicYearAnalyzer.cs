using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicFacebookFeatures
{
    public class MostPhotogenicYearAnalyzer
    {
        private readonly User r_LoggedInUser;
        private readonly Dictionary<int, long> r_PhotoMetricSumPerYear = new Dictionary<int, long>();
        private readonly Dictionary<int, FbPhotoAdapter> r_MostPhotogenicPhotoPerYear = new Dictionary<int, FbPhotoAdapter>();
        private readonly IPhotoMetricStrategy r_PhotoMetricStrategy;

        public List<YearMetricInfo> YearStatisticsList { get; private set; }
        public long TotalPhotosMetricValue { get; private set; } = 0;
        public int BestYear { get; private set; } = 0;
        public long BestYearMetricValue
        {
            get
            {
                return r_PhotoMetricSumPerYear.ContainsKey(BestYear) ? r_PhotoMetricSumPerYear[BestYear] : 0;
            }
        }
        public int TotalPhotos { get; private set; } = 0;


        public MostPhotogenicYearAnalyzer(User i_LoggedInUser, IPhotoMetricStrategy i_PhotoMetricStrategy)
        {
            r_LoggedInUser = i_LoggedInUser ?? 
                throw new ArgumentNullException(nameof(i_LoggedInUser));

            r_PhotoMetricStrategy = i_PhotoMetricStrategy ?? 
                throw new ArgumentNullException(nameof(i_PhotoMetricStrategy));
        }

        public void Analyze()
        {
            buildPhotoMetricsPerYearDict();
            BuildYearStatisticsProps();
            TotalPhotosMetricValue = r_PhotoMetricSumPerYear.Values.Sum();
        }

        private void buildPhotoMetricsPerYearDict()
        {
            foreach (Album album in r_LoggedInUser.Albums)
            {
                try
                {
                    foreach (Photo photo in album.Photos)
                    {
                        if (photo.CreatedTime == null)
                        {
                            continue;
                        }

                        int year = photo.CreatedTime.Value.Year;
                        FbPhotoAdapter photoAdapter = new FbPhotoAdapter(photo);

                        if (!r_PhotoMetricSumPerYear.ContainsKey(year))
                        {
                            r_PhotoMetricSumPerYear[year] = 0;
                        }

                        r_PhotoMetricSumPerYear[year] += r_PhotoMetricStrategy.GetMetric(photoAdapter);
                        TotalPhotos++;
                        updateMostPhotogenicPhotoPerYearDict(year, photoAdapter);
                    }
                }
                catch (KeyNotFoundException)
                {
                    continue;
                }
            }
        }

        private void updateMostPhotogenicPhotoPerYearDict(int i_CurrentYear, FbPhotoAdapter i_PhotoAdapter)
        {
            if (!r_MostPhotogenicPhotoPerYear.ContainsKey(i_CurrentYear))
            {
                r_MostPhotogenicPhotoPerYear[i_CurrentYear] = i_PhotoAdapter;
            }
            else
            {
                long bestMetricValueOfYear = r_PhotoMetricStrategy.GetMetric(r_MostPhotogenicPhotoPerYear[i_CurrentYear]);
                long candidateMetricValue = r_PhotoMetricStrategy.GetMetric(i_PhotoAdapter);

                if (r_PhotoMetricStrategy.IsBetter(candidateMetricValue, bestMetricValueOfYear))
                {
                    r_MostPhotogenicPhotoPerYear[i_CurrentYear] = i_PhotoAdapter;
                }
            }
        }

        private void BuildYearStatisticsProps()
        {
            YearStatisticsList = new List<YearMetricInfo>();

            List<int> orderedYears = r_PhotoMetricSumPerYear
                .OrderByDescending(pair => pair.Value)
                .Select(pair => pair.Key)
                .ToList();

            foreach (int year in orderedYears)
            {
                YearStatisticsList.Add(new YearMetricInfo(year, r_PhotoMetricSumPerYear[year]));
            }

            BestYear = orderedYears.Count > 0 ? orderedYears.First() : 0;
        }

        public long GetMetricValueOfYear(int i_Year)
        {
            return r_PhotoMetricSumPerYear.ContainsKey(i_Year) ? r_PhotoMetricSumPerYear[i_Year] : 0;
        }

        public FbPhotoAdapter GetTopPhotoOfYear(int i_Year)
        {
            return r_MostPhotogenicPhotoPerYear.ContainsKey(i_Year) ? r_MostPhotogenicPhotoPerYear[i_Year] : null;
        }
    }
}
