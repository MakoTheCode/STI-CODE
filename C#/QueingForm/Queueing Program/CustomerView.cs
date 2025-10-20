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
    public partial class CustomerView : Form
    {
        public CustomerView()
        {
            Timer timer = new Timer();
            timer.Interval = (1 * 500); // Timer will tick every 500 milliseconds (0.5 seconds)
            timer.Tick += new EventHandler(timer2_tick);
            timer.Start();
            InitializeComponent();
        }

        public void timer2_tick(object sender, EventArgs e)
        {
            // Make sure the queue isn't empty before calling Peek()
            if (CashierClass.CashierQueue.Count > 0)
            {
                numberServing.Text = CashierClass.CashierQueue.Peek().ToString(); // Convert Peek() to string
            }
            else
            {
                numberServing.Text = "No customers in queue"; // Provide fallback if queue is empty
            }
        }
    }
}
