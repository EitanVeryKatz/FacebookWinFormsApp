using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class LoadingTaskRunner
    {
        private static readonly Dictionary<Label,object> sr_LabelLocks = new Dictionary<Label,object>();
        private readonly object r_LockDictLock = new object();
        public Action LoadingStrategy {private get; set; }
        public Action AfterLoadingStrategy { private get; set; }
        public string BaseLoadingText { get; set; }
        
        public void RunLoadingTask(Label i_LoadingLabel)
        {
            if (LoadingStrategy == null)
            {
                throw new InvalidOperationException("Loading strategy must be set before running the loading task.");
            }

            lock (r_LockDictLock)
            {
                if (!sr_LabelLocks.ContainsKey(i_LoadingLabel))
                {
                    sr_LabelLocks.Add(i_LoadingLabel, new object());
                }

            }

            new Thread(() => runTaskWithLabelLock(i_LoadingLabel)).Start();
        }

        private void runTaskWithLabelLock(Label i_LoadingLabel)
        {
            lock (sr_LabelLocks[i_LoadingLabel])
            {
                LoadingTextAnimator loadingTextAnimator = new LoadingTextAnimator(i_LoadingLabel, BaseLoadingText);

                i_LoadingLabel.SafelyInvoke(() => loadingTextAnimator.Start());

                try
                {
                    LoadingStrategy.Invoke();
                }
                finally
                {
                    i_LoadingLabel.SafelyInvoke(() => loadingTextAnimator.Stop());
                    AfterLoadingStrategy?.Invoke();
                }
            }
        }

    }
}
