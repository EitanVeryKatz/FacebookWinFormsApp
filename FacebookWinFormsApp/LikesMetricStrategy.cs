using System;

namespace BasicFacebookFeatures
{
    public class LikesMetricStrategy : IPhotoMetricStrategy
    {
        public long GetMetric(FbPhotoAdapter i_Photo)
        {
            if (i_Photo == null)
            {
                throw new ArgumentNullException(nameof(i_Photo));
            }

            return i_Photo.LikesCount;
        }

        public bool IsBetter(long i_CandidateMetricValue, long i_BestMetricValue)
        {
            return i_CandidateMetricValue > i_BestMetricValue;
        }
    }
}
