namespace SuperMarketCheckouts.Queue
{
    internal abstract class QueueHandler<T> : IQueueHandler<T> where T : class
    {
        public Queue<T> Queue { get; }

        public QueueHandler() => Queue = new Queue<T>();

        public void Enqueue(T item) => Queue.Enqueue(item);

        public T? Dequeue() => Queue.Count > 0 ? Queue.Dequeue() : default;
    }
}
