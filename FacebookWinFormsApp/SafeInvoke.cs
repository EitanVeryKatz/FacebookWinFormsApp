using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public static class SafeInvoke
    {
        public static void SafelyInvoke(this Control i_Control, Action i_Action)
        {
            if (i_Control == null)
            {
                return;
            }

            if (i_Control.IsDisposed)
            {
                return;
            }

            if (!i_Control.IsHandleCreated)
            {
                return;
            }

            try
            {
                i_Control.Invoke(i_Action);
            }
            catch (ObjectDisposedException)
            {
                return;
            }
            catch (InvalidOperationException)
            {
                return;
            }
        }
    }
}
