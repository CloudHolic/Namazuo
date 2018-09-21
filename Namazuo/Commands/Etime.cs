using System;
using System.Globalization;
using System.Threading.Tasks;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using Namazuo.Utils;
using NLog;

namespace Namazuo.Commands
{
    internal class Etime
    {
        private static readonly Logger Log = LogManager.GetCurrentClassLogger();

        [Command("etime"), Aliases("t")]
        [Description("Get the current Eorzea time.")]
        public async Task EorzeaTime(CommandContext ctx)
        {
            Log.Info($"Check Etime command - {ctx.Message.Content}");

            await ctx.TriggerTypingAsync();

            var result = string.Format(CultureInfo.GetCultureInfo("en-US"), @"{0:tt h:mm:ss}", TimeUtil.RealTimeToEorzeaTime(DateTime.Now));
            
            await ctx.RespondAsync(result);
        }
    }
}
