using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Queueing_Program
{
    public partial class QueueingForm : Form
    {
        private CashierClass cashier; 
        public QueueingForm()
        {
            InitializeComponent();
            cashier = new CashierClass();
            CashierWindowQueue cashierqueue = new CashierWindowQueue();
            cashierqueue.Show();
            CustomerView customerView = new CustomerView();
            customerView.Show();
        }


        private void btnCashier_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
        }
    }
}
