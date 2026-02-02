using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class LoadingTextAnimator
    {
        private readonly Label r_TargetLabel;
        private readonly Timer r_Timer;
        private readonly string r_BaseText;
        private int m_DotsCount;

        public LoadingTextAnimator(Label i_TargetLabel, string i_BaseText)
        {
            r_TargetLabel = i_TargetLabel;
            r_BaseText = i_BaseText;
            r_Timer = new Timer();
            r_Timer.Interval = 300;
            r_Timer.Tick += onTimerTick;
        }

        public void Start()
        {
            m_DotsCount = 0;
            updateLabelText();
            r_Timer.Start();
        }

        public void Stop()
        {
            r_Timer.Stop();
        }

        private void onTimerTick(object sender, EventArgs e)
        {
            advanceDots();
            updateLabelText();
        }

        private void advanceDots()
        {
            m_DotsCount = (m_DotsCount + 1) % 4;
        }

        private void updateLabelText()
        {
            r_TargetLabel.SafelyInvoke(() => r_TargetLabel.Text = r_BaseText + new string('.', m_DotsCount));
            
        }
    }
}
