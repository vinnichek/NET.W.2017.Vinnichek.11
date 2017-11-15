using System;
namespace ImitationWatches.Logic
{
    public sealed class ImitationWatchesEventArgs : EventArgs
    {
        private int time;
        private string message;

        public int Time
        {
            get => time;
            set
            {
                if (value <= 0)
                    throw new ArgumentException($"{nameof(value)} not valid input.");
                time = value;
            }
        }

        public string Message => message;

        public ImitationWatchesEventArgs(int time, string message)
        {
            Time = time;
            this.message = message;
        }
    }
}
