using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    internal class GroupComperator
    {
        private readonly User r_LoggedInUser;

        public GroupComperator(User i_LoggedInUser)
        {
            r_LoggedInUser = i_LoggedInUser;
        }
        public Page comparePages(Page i_PageToCompare1, Page i_PageToCompare2)
        {
            Page winnerPage;
            //TODO : add more comparison criteria
            if (i_PageToCompare1.Statuses.Count > i_PageToCompare2.Statuses.Count)
            {
                winnerPage = i_PageToCompare1;
            }
            else
            {
                winnerPage = i_PageToCompare2;
            }

            return winnerPage;
        }

        

    }
}
