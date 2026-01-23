namespace BasicFacebookFeatures
{
    public interface IPhotoMetricStrategy
    {
        long GetMetric(FbPhotoAdapter i_Photo);
        bool IsBetter(long i_CandidateMetricValue, long i_BestMetricValue);
    }
}
