namespace CSPrimer.Concurrency
{
    internal class SyncPrimitivesPrimer
    {
        public void InterlockedEx()
        {
            int num = 0;

            var incTask = Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Interlocked.Increment(ref num);
                }
            });
            var decTask = Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Interlocked.Decrement(ref num);
                }
            });

            Task.WaitAll(incTask, decTask);

            Console.WriteLine($"Number equals {num}");
        }
    }
}
