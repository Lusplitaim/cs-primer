namespace CSPrimer.Concurrency
{
    internal class BarrierPrimer
    {
        private Barrier _barrier = new(4, barrier => Console.WriteLine());

        /*Instantiating Barrier with a value of 3 causes SignalAndWait to block until that method has been called three times.
        But unlike a CountdownEvent, it then automatically starts over: calling SignalAndWait again blocks until called
        another three times. This allows you to keep several threads “in step” with each other as they process a series of tasks.*/
        public void BarrierEx()
        {
            Parallel.Invoke([PrintInt, PrintInt, PrintInt, PrintInt]);
        }

        private void PrintInt()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write(i);
                _barrier.SignalAndWait();
            }
        }
    }
}
