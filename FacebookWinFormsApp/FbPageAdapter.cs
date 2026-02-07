using System;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class FbPageAdapter : IFacebookObjectAdapter
    {
        private readonly Page r_Page;
        private readonly int r_randomDefaultLikesCount = SingletonRandomizer.Instance.Next(1, 4000);
        
        public FbPageAdapter(Page i_Page)
        {
            r_Page = i_Page;
        }

        public String Text
        {
            get
            {
                return r_Page.Name;
            }
        }

        public String ImageUrl
        {
            get
            {
                return r_Page.PictureNormalURL;
            }
        }

        public long LikesCount
        {
            get
            {
                return r_Page.LikesCount ?? r_randomDefaultLikesCount;
            }
        }

        public bool HasDefaultValue { get { return r_Page.LikesCount == null; } }
    }
}
