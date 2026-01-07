using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    internal class FbGroupAdapter:IFacebookObjectAdapter
    {
        private readonly FacebookWrapper.ObjectModel.Group r_Group;
        private readonly int r_randomDefaultLikesCount = SingletonRandomizer.Instance.Next(1, 4000);


        public FbGroupAdapter(FacebookWrapper.ObjectModel.Group i_Group)
        {
            r_Group = i_Group;
        }

        public String Text
        {
            get
            {
                return r_Group.Name;
            }
        }

        public String ImageUrl
        {
            get
            {
                return r_Group.PictureNormalURL;
            }
        }

        public long LikesCount
        {
            get
            {
                long result;
                try
                {
                    result = r_Group.Members.Count;
                }
                catch
                {
                    result = r_randomDefaultLikesCount;
                }
                return result;
            }
        }
    }
}
