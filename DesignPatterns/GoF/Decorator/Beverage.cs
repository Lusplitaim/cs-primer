namespace CSPrimer.DesignPatterns.GoF.Decorator
{
    internal abstract class Beverage
    {
        public abstract double CalculateCost();
        public abstract string Description { get; }
    }
}
