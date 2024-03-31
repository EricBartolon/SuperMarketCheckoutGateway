namespace SuperMarketCheckouts.Queue
{
    internal abstract class LoadBalancer<T> where T : class
    {
        public List<IQueueHandler<T>> Queues { get; }

        public LoadBalancer(List<IQueueHandler<T>> queues) => Queues = queues;

        protected IQueueHandler<T> GetAvailableQueue(T item)
        {
            return Queues
                .Where(x => IsAvailable(x, item))
                .Aggregate((min, x) => x.Queue.Count < min.Queue.Count ? x : min);
        }

        protected virtual bool IsAvailable(IQueueHandler<T> queueHandler, T item) => true;

        public void Enqueue(T item) => GetAvailableQueue(item).Enqueue(item);

        public T? Dequeue(int index) => Queues[index].Dequeue();
    }
}
