using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Orleans.EventSourcing;
using Orleans.Runtime;

using Scorpio.Bougainvillea.States;
using Scorpio.Tang.Core.State.Character;
using Scorpio.Timing;

namespace Scorpio.Tang.Core
{
    public class Character : JournaledGrain<CharacterState>, ICharacter
    {
        public Character(IGrainContext context) {
            Context = context;
        }

        public IGrainContext Context { get; }

        public async ValueTask<int> NewCommand(object command)
        {
            RaiseEvent(command);
            return 0;
        }

    }


}
