using Discord.WebSocket;
using System.Threading.Tasks;


namespace FTPbox
{
    interface IDiscordService
    {
        Task<bool> Ready();
        SocketTextChannel GetSocketTextChannel(ulong channelId);
    }
}
