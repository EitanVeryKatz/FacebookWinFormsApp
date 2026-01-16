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
                return r_randomDefaultLikesCount;
            }
        }

        public bool HasDefaultValue { get { return true; } }
    }
}
