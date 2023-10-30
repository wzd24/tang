using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;

using Scorpio.Conventional;

namespace Scorpio.Bougainvillea.States
{
    internal class ConventionalStateEventHandlersRegisterAction : ConventionalActionBase
    {
        public ConventionalStateEventHandlersRegisterAction(IConventionalConfiguration configuration) : base(configuration)
        {
        }

        protected override void Action(IConventionalContext context)
        {

            context.Types.ForEach(t =>
            {
                context.Services.AddSingleton(t);
                context.Services.Configure<StateEventHandlerOptions>(opt => opt.Types.AddOrUpdate(t.GetGenericArguments()[1], (_)=>t,(_,_)=>t));
            });
        }
    }
}
