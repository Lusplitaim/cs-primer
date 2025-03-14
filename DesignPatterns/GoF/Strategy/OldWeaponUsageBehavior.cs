namespace CSPrimer.DesignPatterns.GoF.Strategy
{
    internal class OldWeaponUsageBehavior : IWeaponUsageBehavior
    {
        public bool IsWorking => _limitUsage > 0;

        private int _limitUsage;

        public OldWeaponUsageBehavior(int limit)
        {
            _limitUsage = limit;
        }

        public void Use()
        {
            _limitUsage--;
        }
    }
}
