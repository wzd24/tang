using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;

using Scorpio.Bougainvillea.States;
using Scorpio.Conventional;

namespace Scorpio.Bougainvillea
{
    internal class ConventionRegistrar : IConventionalRegistrar
    {
        public void Register(IConventionalRegistrationContext context) => context.Services.DoConventionalAction<ConventionalStateEventHandlersRegisterAction>(context.Types, config => config.Where(t => t.IsStandardType()).Where(t => t.IsAssignableToGenericType(typeof(IStateEventHandler<>))));
    }
}
