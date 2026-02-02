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
        public Action LoadingStrategy {private get; set; }
        public Action AfterLoadingStrategy { private get; set; }
        public string BaseLoadingText { get; set; }
        public Label LoadingLabel { get; set; }

        public LoadingTaskRunner(Label i_Label)
        {
            BaseLoadingText = "Loading";
            LoadingLabel = i_Label;
        }

        public void RunLoadingTask()
        {
            if(LoadingStrategy == null)
            {
                throw new InvalidOperationException("Loading strategy must be set before running the loading task.");
            }
            LoadingTextAnimator loadingTextAnimator = new LoadingTextAnimator(LoadingLabel,BaseLoadingText);
            loadingTextAnimator.Start();
            new Thread(()=>executeTask(loadingTextAnimator)).Start();
        }

        private void executeTask(LoadingTextAnimator i_LoadingTextAnimator)
        {
            LoadingStrategy.Invoke();
            i_LoadingTextAnimator.Stop();
            AfterLoadingStrategy?.Invoke();
        }
    }
}
