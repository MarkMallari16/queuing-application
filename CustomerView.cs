namespace QueuingApplication
{
    public partial class CustomerView : Form
    {
        public CustomerView()
        {
            InitializeComponent();
            lblFirstServe.Text = "Empty.";
        }

        public void DisplayCashierQueue()
        {
            if (CashierClass.CashierQueue != null && CashierClass.CashierQueue.Contains(CashierClass.CashierQueue.Peek()))
            {
                lblFirstServe.Text = CashierClass.CashierQueue.Peek();
            }
            else
            {
                lblFirstServe.Text = "Empty.";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayCashierQueue();
        }
    }
}
