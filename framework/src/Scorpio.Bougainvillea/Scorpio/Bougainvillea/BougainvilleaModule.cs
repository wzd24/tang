using Microsoft.Extensions.DependencyInjection;

using Orleans.Runtime;

using Scorpio.Bougainvillea.States;
using Scorpio.Modularity;

namespace Scorpio.Bougainvillea;

[DependsOn<BougainvilleaAbstractionsModule>]
public class BougainvilleaModule : ScorpioModule
{
    public BougainvilleaModule()
    {

    }

    public override void PreConfigureServices(ConfigureServicesContext context)
    {
        context.Services.AddOptions<StateEventHandlerOptions>();
        context.AddConventionalRegistrar<ConventionRegistrar>();
    }

}
