using Discord;
using Discord.WebSocket;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;

namespace FTPbox
{

    public class DiscordServiceOptions
    {
        public string BotToken { get; set; }
    }

    public class DiscordService : IDiscordService
    {
        private readonly ILogger _logger;
        private readonly DiscordSocketClient _client;
        private TaskCompletionSource<bool> _ready = new TaskCompletionSource<bool>();

        public DiscordService(IOptions<DiscordServiceOptions> options, ILogger<DiscordService> logger)
        {
            _logger = logger;
            _client = new DiscordSocketClient();
            _client.Log += LogDiscord;
            _client.Ready += OnReady;
            _client.LoginAsync(TokenType.Bot, options.Value.BotToken);
            _client.StartAsync();
        }

        public SocketTextChannel GetSocketTextChannel(ulong channelId) => _client.GetChannel(channelId) as SocketTextChannel;

        public async Task<bool> Ready()
        {
            await _ready.Task;
            return _ready.Task.Result;
        }

        private Task OnReady()
        {
            _ready.SetResult(true);
            return Task.CompletedTask;
        }

        private Task LogDiscord(LogMessage msg)
        {
            _logger.LogInformation(msg.ToString());
            return Task.CompletedTask;
        }
    }
}
