namespace CSPrimer.DesignPatterns.GoF.Adapter
{
    internal class AdapterPrimer
    {
        /*
         * Excavator and groundsman are objects with different interfaces,
         * but we want to work with them in uniformal manner.
         * For that we create a class that adds excavator through composition
         * and implements IDigger interface so that we can use groundsman and
         * excavator's functionality using one universal interface.
         */
        public void Do()
        {
            IDigger digger = new Groundsman();
            digger.Dig();

            digger = new ExcavatorDiggerAdapter(new Excavator());
            digger.Dig();
        }
    }
}
