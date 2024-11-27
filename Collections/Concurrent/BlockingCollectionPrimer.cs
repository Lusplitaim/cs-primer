using System.Collections.Concurrent;

namespace CSPrimer.Collections.Concurrent
{
    internal class BlockingCollectionPrimer
    {
        public void ProducerConsumerEx()
        {
            BlockingCollection<int> blockingCollection = [];

            var producerTask = Task.Factory.StartNew(() =>
            {
                for (var i = 0; i < 10; i++)
                    blockingCollection.Add(i);

                blockingCollection.CompleteAdding();
            });

            var consumerTask = Task.Factory.StartNew(() =>
            {
                while (!blockingCollection.IsCompleted)
                {
                    var item = blockingCollection.Take();
                    Console.Write($"{item} ");
                }
            });

            Task.WaitAll(producerTask, consumerTask);
        }
    }
}
