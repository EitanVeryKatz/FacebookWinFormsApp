using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    internal class FbPageAdapter : IFacebookObjectAdapter
    {
        private readonly FacebookWrapper.ObjectModel.Page r_Page;
        private readonly int r_randomDefaultLikesCount = SingletonRandomizer.Instance.Next(1, 4000);

        public FbPageAdapter(FacebookWrapper.ObjectModel.Page i_Page)
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
    }
}
