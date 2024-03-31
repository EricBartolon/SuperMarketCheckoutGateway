namespace SuperMarketCheckouts.Queue
{
    internal interface IQueueHandler<T> where T : class
    {
        public Queue<T> Queue { get; }

        public void Enqueue(T item);
        public T? Dequeue();
    }
}
