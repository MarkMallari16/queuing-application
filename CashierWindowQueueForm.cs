using System.Collections;
namespace QueuingApplication
{
    public partial class CashierWindowQueue : Form
    {
        private System.Windows.Forms.Timer timer1;
        private CustomerView cv = new CustomerView();
        public CashierWindowQueue()
        {
            InitializeComponent();
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;
            timer1.Start();

            cv.Show();
        }

        private void Timer1_Tick(object? sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();

            foreach (Object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CashierClass.CashierQueue.Count > 0)
            {
                cv.Show();
                cv.DisplayCashierQueue();

                CashierClass.CashierQueue.Dequeue();
                DisplayCashierQueue(CashierClass.CashierQueue);

            }
            else
            {
                MessageBox.Show("The queue is empty.");
            }
        }
    }
}
