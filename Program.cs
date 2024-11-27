using CSPrimer.Collections.Concurrent;

namespace CSPrimer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var signalingPrimer = new BlockingCollectionPrimer();
            signalingPrimer.ProducerConsumerEx();
        }
    }
}
