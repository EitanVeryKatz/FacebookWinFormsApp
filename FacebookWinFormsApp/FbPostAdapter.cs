using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class FbPostAdapter: IFacebookObjectAdapter
    {
        private readonly Post r_Post;
        private readonly User r_User;
        private readonly int r_randomDefaultLikesCount = SingletonRandomizer.Instance.Next(1, 4000);


        public FbPostAdapter(Post i_Post,User i_user)
        {
            if (i_Post.Message == null)
            {
                throw new ArgumentNullException();
            }
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
                long result;
                try
                {

                    result = r_Post.LikedBy.Count;
                    HasDefaultValue = false;
                }
                catch
                {
                    HasDefaultValue = true;
                    result = r_randomDefaultLikesCount;
                }
                return result;
            }
        }

        public bool HasDefaultValue { get; private set; }
    }
}
