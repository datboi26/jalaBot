using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSharpPlus;

namespace jalaBot
{
    class Program
    {
        static void Main(string[] args)
        {
            Run().GetAwaiter().GetResult();
        }

        public static async Task Run()
        {
            var discord = new DiscordClient(new DiscordConfig
            {
                AutoReconnect = true,
                DiscordBranch = Branch.Stable,
                LargeThreshold = 250,
                LogLevel = LogLevel.Critical,
                Token = "MzMyMjUxODE0ODkwMTc2NTMz.DD7ZMQ.WXmzXFRYYMegSrEtTNKxmpM92gI",
                TokenType = TokenType.Bot,
                UseInternalLogHandler = false
            });

            await discord.ConnectAsync();

            await Task.Delay(-1);
        }
    }
}