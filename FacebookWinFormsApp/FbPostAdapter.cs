using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    internal class FbPostAdapter: IFacebookObjectAdapter
    {
        private readonly Post r_Post;
        private readonly User r_User;

        public FbPostAdapter(Post i_Post,User i_user)
        {
            r_Post = i_Post;
            r_User = i_user;
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
                return r_User.PictureNormalURL;
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
