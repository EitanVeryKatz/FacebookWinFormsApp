using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    internal class FbPostAdapter: IFacebookObjectAdapter
    {
        private readonly FacebookWrapper.ObjectModel.Post r_Post;

        public FbPostAdapter(FacebookWrapper.ObjectModel.Post i_Post)
        {
            r_Post = i_Post;
        }

        public String Text
        {
            get
            {
                return r_Post.Message;
            }
        }

        public String ImageUrl
        {
            get
            {
                return r_Post.PictureURL;
            }
        }

        public long LikesCount
        {
            get
            {
                return r_Post.LikedBy.Count;
            }
        }
    }
}
