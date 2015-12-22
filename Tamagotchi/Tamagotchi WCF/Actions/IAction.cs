using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi_WCF.Actions
{
    public interface IAction
    {

        int TimeSpan { get; }

        string Act();
    }
}
