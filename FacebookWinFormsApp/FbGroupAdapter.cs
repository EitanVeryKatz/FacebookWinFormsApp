using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;


namespace BasicFacebookFeatures
{
    public class FbGroupAdapter : IFacebookObjectAdapter
    {
        private readonly Group r_Group;
        private readonly int r_randomDefaultLikesCount = SingletonRandomizer.Instance.Next(1, 4000);

        public FbGroupAdapter(Group i_Group)
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
                    HasDefaultValue = true;
                }
                catch
                {
                    HasDefaultValue = false;
                    result = r_randomDefaultLikesCount;
                }
                return result;
            }
        }

        public bool HasDefaultValue { get; private set; }
    }
}