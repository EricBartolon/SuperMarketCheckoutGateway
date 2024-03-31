using SuperMarketCheckouts.Queue;

namespace SuperMarketCheckouts {
    public partial class frmCheckouts : Form {
        private CheckoutBalancer balancer;
        private int cartNumber;
        private Random random;

        public frmCheckouts() {
            InitializeComponent();
            balancer = new CheckoutBalancer(InitializeCheckouts());
            UpdateCartNumber();
            random = new Random();
        }

        private List<IQueueHandler<Cart>> InitializeCheckouts() {
            var checkouts = new List<IQueueHandler<Cart>> {
                new Checkout<Cart>(12),
                new Checkout<Cart>(12),
                new Checkout<Cart>(12)
            };

            for (int i = 0; i < 7; i++)
                checkouts.Add(new Checkout<Cart>());

            return checkouts;
        }

        private void btnEnqueue_Click(object sender, EventArgs e)
            => Enqueue(txtCartNumber.Text, int.Parse(ntxtCartSize.Text));

        private void btnAutoFill_Click(object sender, EventArgs e) {
            for (int i = 0; i < 30; i++)
                Enqueue(cartNumber.ToString(), random.Next(100));
        }

        private void Enqueue(string number, int quantity) {
            balancer.Enqueue(new Cart() { Number = number, Quantity = quantity });
            UpdateDataGrid();
            UpdateCartNumber();
        }

        private void UpdateCartNumber() => txtCartNumber.Text = cartNumber++.ToString();

        private void btnDequeue_Click(object sender, EventArgs e) {
            balancer.Dequeue(int.Parse(ntxtCheckoutToDequeue.Text));
            UpdateDataGrid();
        }

        private void UpdateDataGrid() {
            for (int i = 0; i < balancer.Queues.Count; i++) {
                var dgv = GetDataGridViewById(i);
                dgv.DataSource = balancer.Queues[i].Queue.ToList();
                dgv.Refresh();
            }
        }

        private DataGridView GetDataGridViewById(int index) => index switch {
            0 => dgvCheckout1,
            1 => dgvCheckout2,
            2 => dgvCheckout3,
            3 => dgvCheckout4,
            4 => dgvCheckout5,
            5 => dgvCheckout6,
            6 => dgvCheckout7,
            7 => dgvCheckout8,
            8 => dgvCheckout9,
            _ => dgvCheckout10,
        };
    }
}
