namespace CSPrimer.Concurrency
{
    internal class EventSignalingPrimer
    {
        /* A ManualResetEvent functions like an ordinary gate. Calling Set opens the gate, allowing any number of threads
        calling WaitOne to be let through. Calling Reset closes the gate. Threads that call WaitOne on a closed gate will block;
        when the gate is next opened, they will be released all at once. */
        public void ManualResetEventEx()
        {
            var waitHandle = new ManualResetEventSlim(false);

            var firstTask = Task.Run(() =>
            {
                Console.WriteLine("Started task 1, waiting...");
                waitHandle.Wait();
                Console.WriteLine("Task 1 is complete");
            });
            var secondTask = Task.Run(() =>
            {
                Console.WriteLine("Started task 2, waiting...");
                waitHandle.Wait();
                Console.WriteLine("Task 2 is complete");
            });

            Thread.Sleep(1000);
            waitHandle.Set(); // Releases all blocked threads.
            Thread.Sleep(1000);
            waitHandle.Dispose();
        }

        /* An AutoResetEvent is like a ticket turnstile: inserting a ticket lets exactly one person through. The “auto” in the class’s
        name refers to the fact that an open turnstile automatically closes or “resets” after someone steps through. A thread
        waits, or blocks, at the turnstile by calling WaitOne (wait at this “one” turnstile until it opens), and a ticket is inserted by
        calling the Set method. If a number of threads call WaitOne, a queue builds up behind the turnstile. (As with locks, the
        fairness of the queue can sometimes be violated due to nuances in the operating system). A ticket can come from any
        thread; in other words, any (unblocked) thread with access to the AutoResetEvent object can call Set on it to release
        one blocked thread. */
        public void AutoResetEventEx()
        {
            var waitHandle = new AutoResetEvent(false);

            var firstTask = Task.Run(() =>
            {
                Console.WriteLine("Started task 1, waiting...");
                waitHandle.WaitOne();
                Console.WriteLine("Task 1 is complete");
            });
            var secondTask = Task.Run(() =>
            {
                Console.WriteLine("Started task 2, waiting...");
                waitHandle.WaitOne();
                Console.WriteLine("Task 2 is complete");
            });

            Thread.Sleep(1000);
            waitHandle.Set();
            Thread.Sleep(1000);
            waitHandle.Set();
            Thread.Sleep(1000);
            waitHandle.Close();
        }

        public void CountdownEventEx()
        {
            var countdown = new CountdownEvent(2);

            var firstTask = Task.Run(() =>
            {
                Console.WriteLine("Task 1, do work");
                Thread.Sleep(1000);
                countdown.Signal();
            });
            var secondTask = Task.Run(() =>
            {
                Console.WriteLine("Task 2, do work");
                Thread.Sleep(1000);
                countdown.Signal();
            });

            countdown.Wait();
            Console.WriteLine("Work done");
        }
    }
}
