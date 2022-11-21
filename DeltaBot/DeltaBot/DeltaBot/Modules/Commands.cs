using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;

namespace DeltaBot.Modules
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        [Command("ping")]
        public async Task Ping()
        {
            await ReplyAsync("Pong!");
        }

        [Command("hello")]
        public async Task Hello()
        {
            await ReplyAsync("Hello!");
        }

        [Command("chukai")]

        public async Task Chukai()
        {
            await ReplyAsync("CHUKAI KURVATA BRATLE!");
        }
    }
}
