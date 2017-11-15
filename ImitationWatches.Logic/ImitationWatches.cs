using System;
using System.Threading;

namespace ImitationWatches.Logic
{
    public class ImitationWatches
    {
        public delegate void ImitationWatchesEventHandler(object sender, ImitationWatchesEventArgs e);

        public event ImitationWatchesEventHandler TimeIsOver;

        public virtual void OnTimeIsOver(object sender, ImitationWatchesEventArgs e)
        {
            if (TimeIsOver != null)
            {
                Thread.Sleep(e.Time);
                TimeIsOver(sender, e);
            }
        }

        public void SimulateImitationWatches(string message, int time)
        {
            OnTimeIsOver(this, new ImitationWatchesEventArgs(time, message));
        }
    }
}

