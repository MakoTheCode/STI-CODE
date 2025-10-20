using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace Queueing_Program
{
    
    public partial class CashierWindowQueue : Form
    {
        ManageQueue delegateDelete;
        public int secondsCount;
        public CashierWindowQueue()
        {
            InitializeComponent();

            delegateDelete = new ManageQueue(CashierClass.finishedCashierNumber);
            Timer timer = new Timer();
            timer.Interval = (1 * 1000);
            timer.Tick += new EventHandler(timer1_tick);
            timer.Start();
        }

        public void timer1_tick(object sender, EventArgs e) {
            secondsCount++;
            if (secondsCount == 5) {
                secondsCount = 0;
                DisplayCashierQueue(CashierClass.CashierQueue);
            }
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
            delegateDelete();
            DisplayCashierQueue(CashierClass.CashierQueue);
            
        }
    }
}
