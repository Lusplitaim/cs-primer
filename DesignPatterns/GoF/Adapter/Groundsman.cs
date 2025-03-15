namespace CSPrimer.DesignPatterns.GoF.Adapter
{
    internal class Groundsman : IDigger
    {
        public void Dig()
        {
            Console.WriteLine("Groundsman is digging");
        }
    }
}
