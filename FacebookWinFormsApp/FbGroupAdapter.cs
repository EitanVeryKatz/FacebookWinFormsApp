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
                return r_Group.Members.Count;
            }
        }
    }
}
