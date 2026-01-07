using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class FacebookObjectAdapterFactory
    {
        public User UploadingUser { get; set; }
        private object m_FacebookObjectCollectionLock = new object();
        public IFacebookObjectAdapter CreateFacebookObjectAdapter(FacebookObject i_FacebookObject)
        {
            IFacebookObjectAdapter facebookObjectAdapter = null;

            if (i_FacebookObject is Post)
            {
                facebookObjectAdapter = new FbPostAdapter(i_FacebookObject as Post,UploadingUser);
            }
            else if (i_FacebookObject is Page)
            {
                facebookObjectAdapter = new FbPageAdapter(i_FacebookObject as Page);
            }
            else if (i_FacebookObject is Group)
            {
                facebookObjectAdapter = new FbGroupAdapter(i_FacebookObject as Group);
            }

            return facebookObjectAdapter;
        }

        public Collection<IFacebookObjectAdapter> CreateFacebookObjectAdapterList<T>(FacebookObjectCollection<T> i_FacebookObject)
            where T : FacebookObject
        {
            Collection<IFacebookObjectAdapter> facebookObjectAdapterList = new Collection<IFacebookObjectAdapter>();
            foreach (T facebookObject in i_FacebookObject)
            {
                try
                {
                    IFacebookObjectAdapter facebookObjectAdapter = CreateFacebookObjectAdapter(facebookObject);
                    if (facebookObjectAdapter != null)
                    {
                        lock (m_FacebookObjectCollectionLock)
                        {
                            facebookObjectAdapterList.Add(facebookObjectAdapter);
                        }
                    }
                }
                catch
                { }
            }
            return facebookObjectAdapterList;
        }
    }
}
