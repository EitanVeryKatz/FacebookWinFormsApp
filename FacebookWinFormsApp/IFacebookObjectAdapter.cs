using System;

namespace BasicFacebookFeatures
{
    public interface IFacebookObjectAdapter
    {
        String Text { get; }
        String ImageUrl { get; }
        long LikesCount { get; }
        bool HasDefaultValue {  get; }
    }
}
