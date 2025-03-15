namespace CSPrimer.DesignPatterns.GoF.Adapter
{
    internal class ExcavatorDiggerAdapter : IDigger
    {
        private Excavator _excavator;
        public ExcavatorDiggerAdapter(Excavator excavator)
        {
            _excavator = excavator;
        }

        public void Dig()
        {
            _excavator.Excavate();
        }
    }
}
