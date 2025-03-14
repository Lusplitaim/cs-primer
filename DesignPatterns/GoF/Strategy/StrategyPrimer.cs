namespace CSPrimer.DesignPatterns.GoF.Strategy
{
    internal static class StrategyPrimer
    {
        public static void Do()
        {
            Character woman = new Woman()
            {
                Weapon = WeaponType.Saber,
                WeaponUsageBehaviour = new OldWeaponUsageBehavior(2),
            };

            woman.UseWeapon();
            woman.UseWeapon();
            woman.UseWeapon();
        }
    }
}
