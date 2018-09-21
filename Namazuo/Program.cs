using NLog;

namespace Namazuo
{
    internal static class Program
    {
        private static readonly Logger Log = LogManager.GetCurrentClassLogger();

        private static void Main()
        {
            using (var bot = new Bot())
            {
                Log.Info("Namazuo bot started.");
                bot.RunAsync().Wait();
            }
        }
    }
}