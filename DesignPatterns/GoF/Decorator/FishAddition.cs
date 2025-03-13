using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPrimer.DesignPatterns.GoF.Decorator
{
    internal class FishAddition : BeverageAddition
    {
        public override string Description => Beverage?.Description ?? string.Empty;

        public override Beverage? Beverage { get; }

        public FishAddition(Beverage beverage)
        {
            Beverage = beverage;
        }

        public override double CalculateCost()
        {
            return 3.5 + Beverage?.CalculateCost() ?? 0;
        }
    }
}
