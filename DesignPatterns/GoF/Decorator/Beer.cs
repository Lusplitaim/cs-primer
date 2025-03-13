using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPrimer.DesignPatterns.GoF.Decorator
{
    internal class Beer : Beverage
    {
        public override string Description => "Beer";

        public override double CalculateCost()
        {
            return 5.05;
        }
    }
}
