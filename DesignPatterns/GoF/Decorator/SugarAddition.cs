namespace CSPrimer.DesignPatterns.GoF.Decorator
{
    internal class SugarAddition : BeverageAddition
    {
        public override string Description => Beverage?.Description ?? string.Empty;

        public override Beverage? Beverage { get; }

        public SugarAddition(Beverage beverage)
        {
            Beverage = beverage;
        }

        public override double CalculateCost()
        {
            return 0.7 + Beverage?.CalculateCost() ?? 0;
        }
    }
}
