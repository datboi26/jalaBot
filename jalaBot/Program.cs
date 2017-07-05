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

            client.MessageReceived += MessageReceived;

            string token = ""; 
            await client.LoginAsync(Discord.TokenType.Bot, token);
            await client.StartAsync();            
            await Task.Delay(-1);
        }

        private async Task MessageReceived(SocketMessage message)
        {
            if (message.Content == "!ping")
            {
                await message.Channel.SendMessageAsync("Pong!");
            }
        }

        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.FromResult(0);
        }
    }
}
