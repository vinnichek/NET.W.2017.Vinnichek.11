using System;
namespace ImitationWatches.Logic
{
    sealed class Listener
    {
        public Listener(ImitationWatches watches)
        {
            watches.TimeIsOver += Message;
        }

        public void Register(ImitationWatches watches)
        {
            watches.TimeIsOver += Message;
        }

        public void Unregister(ImitationWatches watches)
        {
            watches.TimeIsOver -= Message;
        }

        private void Message(object sender, ImitationWatchesEventArgs eventArgs)
        {
            Console.WriteLine("New message.");
            Console.WriteLine("Topic: '{0}' for time {1}", eventArgs.Message, eventArgs.Time);
        }
    }
}
