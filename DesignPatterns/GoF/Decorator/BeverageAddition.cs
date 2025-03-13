using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPrimer.DesignPatterns.GoF.Decorator
{
    internal abstract class BeverageAddition : Beverage
    {
        public abstract Beverage? Beverage { get; }
    }
}
