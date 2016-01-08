using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi_WCF.Spelregels
{
    public interface ISpelregel
    {
        Tamagotchi ExecuteSpelregel(Tamagotchi tmg);
    }
}
