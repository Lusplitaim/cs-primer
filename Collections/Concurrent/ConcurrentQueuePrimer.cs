using System.Collections.Concurrent;

namespace CSPrimer.Collections.Concurrent
{
    internal class ConcurrentQueuePrimer
    {
        public void EnqueueDequeueEx()
        {
            var queue = new ConcurrentQueue<int>();
            bool isStopped = false;
            var result = 0;

            var producerTask = Task.Factory.StartNew(() =>
            {
                for (int i = 0; i < 5000; i++)
                {
                    queue.Enqueue(i);
                }
                isStopped = true;
            });
            var consumerTask = Task.Factory.StartNew(() =>
            {
                while (!isStopped || queue.Count > 0)
                {
                    if (queue.TryDequeue(out int num))
                    {
                        Console.WriteLine(num);
                        result++;
                    }
                }
            });

            Task.WaitAll(producerTask, consumerTask);

            Console.WriteLine(result);
        }
    }
}
