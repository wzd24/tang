using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scorpio.Tang.Core
{
    public interface ICharacter:IGrainWithIntegerKey
    {
        ValueTask<int> NewCommand(object command);
    }

   
}
