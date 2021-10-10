

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;
using DiscordBot.Modules;

namespace DiscordBot.Modules
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        [Command("introduce yourself")]
        public async Task Introduction()
        {
            await ReplyAsync("Hello, I am Justin's Online Native Artifical Helper; but you can call me J.O.N.A.H.");
        }


    }
}
