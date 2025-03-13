using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPrimer.DesignPatterns.GoF.Decorator
{
    internal class Coffee : Beverage
    {
        public override string Description => "Coffee";

        public override double CalculateCost()
        {
            return 7;
        }
    }
}
