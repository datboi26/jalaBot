using Discord;
using Discord.WebSocket;
using System;
using System.Threading.Tasks;

namespace jalaBot
{
    public class Program
    {
        public static void Main(string[] args)
            => new Program().MainAsync().GetAwaiter().GetResult();

        public async Task MainAsync()
        {
            var client = new DiscordSocketClient();

            client.Log += Log;

            string token = "MzMyMjUxODE0ODkwMTc2NTMz.DD7ZMQ.WXmzXFRYYMegSrEtTNKxmpM92gI"; 
            await client.LoginAsync(Discord.TokenType.Bot, token);
            await client.StartAsync();            
            await Task.Delay(-1);
        }

        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.FromResult(0);
        }
    }
}
