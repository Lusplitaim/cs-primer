namespace CSPrimer.Concurrency
{
    internal class ParallelPrimer
    {
        public void TaskFromFactoryEx()
        {
            var tasks = new Task[10];

            for (int i = 0; i < 10; i++)
            {
                tasks[i] = Task.Factory.StartNew(obj =>
                {
                    var customObj = obj as CustomData;
                    customObj!.TaskId = Task.CurrentId!.Value;
                }, new CustomData(Environment.CurrentManagedThreadId));
            }

            Task.WhenAll(tasks);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine((tasks[i].AsyncState as CustomData)!.TaskId);
            }
        }

        public async Task ContinuationEx()
        {
            var taskA = Task.Run(() => DateTime.Now);

            await taskA.ContinueWith(antecedent => Console.WriteLine($"Datetime is {antecedent.Result}"));
        }

        private class CustomData(int ThreadId)
        {
            public int TaskId { get; set; }
        }
    }
}
