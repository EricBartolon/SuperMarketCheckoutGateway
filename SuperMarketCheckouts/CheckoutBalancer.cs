using SuperMarketCheckouts.Queue;

namespace SuperMarketCheckouts {
    internal class CheckoutBalancer : LoadBalancer<Cart> {
        public CheckoutBalancer(List<IQueueHandler<Cart>> queues) : base(queues) {
        }

        protected override bool IsAvailable(IQueueHandler<Cart> queueHandler, Cart item) 
            => item.Quantity <= ((Checkout<Cart>)queueHandler).MaxProducts;
    }
}
