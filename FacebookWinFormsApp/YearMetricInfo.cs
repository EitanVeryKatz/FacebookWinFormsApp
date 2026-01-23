namespace BasicFacebookFeatures
{
    public class YearMetricInfo
    {
        public int Year { get; }
        public long MetricValue { get; }

        public YearMetricInfo(int i_Year, long i_MetricValue)
        {
            Year = i_Year;
            MetricValue = i_MetricValue;
        }
    }

}
