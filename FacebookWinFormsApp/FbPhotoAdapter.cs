using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BasicFacebookFeatures
{
    public class FbPhotoAdapter : IFacebookObjectAdapter
    {
        private readonly Photo r_Photo;
        private readonly int r_randomDefaultLikesCount = SingletonRandomizer.Instance.Next(1, 4000);
        private readonly int r_randomDefaultCommentsCount = SingletonRandomizer.Instance.Next(1, 4000);
        
        public FbPhotoAdapter(Photo i_Photo)
        {
            r_Photo = i_Photo;
        }

        public String Text
        {
            get
            {
                return r_Photo.Name;
            }
        }

        public String ImageUrl
        {
            get
            {
                return r_Photo.PictureNormalURL;
            }
        }

        public long LikesCount
        {
            get
            {
                int likesCount;

                try 
                {
                    likesCount = r_Photo.LikedBy.Count;
                    HasDefaultValue = true;
                }
                catch
                {
                    likesCount = r_randomDefaultLikesCount;
                    HasDefaultValue = false;
                }

                return likesCount;
            }
        }

        public long CommentsCount
        {
            get
            {
                int commentsCount;

                try
                {
                    commentsCount = r_Photo.Comments.Count;
                    HasDefaultValue = true;
                }
                catch
                {
                    commentsCount = r_randomDefaultCommentsCount;
                    HasDefaultValue = false;
                }
                
                return commentsCount;
            }
           
        }

        public bool HasDefaultValue { get; private set; }
    }
}
