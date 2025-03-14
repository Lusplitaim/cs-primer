namespace CSPrimer.DesignPatterns.GoF.Strategy
{
    internal interface IWeaponUsageBehavior
    {
        public bool IsWorking { get; }
        public void Use();
    }
}