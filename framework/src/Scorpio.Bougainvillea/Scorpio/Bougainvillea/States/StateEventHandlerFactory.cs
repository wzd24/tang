using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.Options;

using Scorpio.DependencyInjection;

namespace Scorpio.Bougainvillea.States
{
    internal class StateEventHandlerFactory : IStateEventHandlerFactory,ISingletonDependency
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly StateEventHandlerOptions _options;

        public StateEventHandlerFactory(IServiceProvider serviceProvider, IOptions<StateEventHandlerOptions> options)
        {
            _serviceProvider = serviceProvider;
            _options = options.Value;
        }
        public IStateEventHandler<TState> GetHandler<TState, TEvent>(TState state, TEvent @event)
        {
            var type = _options.Types.GetOrDefault<TEvent>() ?? throw new NotSupportedException();
            return _serviceProvider.GetService(type) as IStateEventHandler<TState> ?? throw new NotSupportedException();
        }

        public IStateEventHandler<TState> GetHandler<TState>(TState state, object @event)
        {
            var type = _options.Types.GetOrDefault(@event.GetType()) ?? throw new NotSupportedException();
            return _serviceProvider.GetService(type) as IStateEventHandler<TState> ?? throw new NotSupportedException();
        }
    }

    internal class StateEventHandlerOptions
    {
        public ITypeDictionary Types { get; } = new TypeDictionary();

    }

}
