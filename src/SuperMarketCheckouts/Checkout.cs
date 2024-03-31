using SuperMarketCheckouts.Queue;

namespace SuperMarketCheckouts {
    internal class Checkout<T> : QueueHandler<T>, IQueueHandler<T> where T : class  {
        public int MaxProducts { get; set; }
        public Checkout(int maxProducts = int.MaxValue) : base() {
            MaxProducts = maxProducts;
        }
    }
}
