using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Builder.Middleware;
using Microsoft.Bot.Schema;

namespace BracketsMiddleware
{
    public class Brackets : IMiddleware, IReceiveActivity, ISendActivity
    {
        public async Task ReceiveActivity(IBotContext context, MiddlewareSet.NextDelegate next)
        {
            context.Reply("{");
            await next();
        }

        public async Task SendActivity(IBotContext context, IList<IActivity> activities, MiddlewareSet.NextDelegate next)
        {
            await next();
            context.Reply("}");
        }
    }
}
