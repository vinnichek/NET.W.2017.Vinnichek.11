using System;
namespace ImitationWatches.Logic
{
    public class AnotherListener
    {
        public AnotherListener() { }

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
            Console.WriteLine("Message: '{0}'. Time {1} is over.", eventArgs.Message, eventArgs.Time);
        }
    }
}
