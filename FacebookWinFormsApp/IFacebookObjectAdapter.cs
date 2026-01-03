using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public interface IFacebookObjectAdapter
    {
        String Text { get; }
        String ImageUrl { get; }
        int LikesCount { get; }
    }
}
