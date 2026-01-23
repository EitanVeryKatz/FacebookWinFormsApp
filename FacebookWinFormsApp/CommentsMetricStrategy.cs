using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class CommentsMetricStrategy : IPhotoMetricStrategy
    {
        public long GetMetric(FbPhotoAdapter i_Photo)
        {
            return i_Photo.CommentsCount;
        }
        public bool IsBetter(long i_CandidateMetricValue, long i_BestMetricValue)
        {
            return i_CandidateMetricValue > i_BestMetricValue;
        }
    }
}
