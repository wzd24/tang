using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Scorpio.DependencyInjection;

namespace Scorpio.Bougainvillea.States
{
    public interface IStateEventHandler<TState>
    {
        void Apply(TState state, object @event);
    }


    public abstract class StateEventHandler<TState, TEvent> : IStateEventHandler<TState>
    {
        void IStateEventHandler<TState>.Apply(TState state, object @event) => Apply(state, (TEvent)@event);

        protected abstract void Apply(TState state, TEvent @event);
    }

}
