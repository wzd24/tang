using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scorpio.Bougainvillea.States
{
    public interface IStateEventHandlerFactory
    {
        IStateEventHandler<TState> GetHandler<TState, TEvent>(TState state, TEvent @event);
        IStateEventHandler<TState> GetHandler<TState>(TState state, object @event);
    }


}
