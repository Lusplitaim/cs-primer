namespace CSPrimer.DesignPatterns.GoF.Strategy
{
    internal abstract class Character
    {
        public string Name { get; set; }

        public WeaponType Weapon { get; set; }

        public IWeaponUsageBehavior WeaponUsageBehaviour { get; set; }

        public void UseWeapon()
        {
            if (WeaponUsageBehaviour.IsWorking)
            {
                WeaponUsageBehaviour.Use();
                Console.WriteLine($"Use {Weapon.ToString()}");
            }
            else
            {
                Console.WriteLine($"{Weapon.ToString()} not operational");
            }
        }
    }
}
