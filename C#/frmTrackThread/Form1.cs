using System;
using System.Threading;
using System.Windows.Forms;

namespace frmTrackThreadApp
{
    public partial class frmTrackThread : Form
    {
        public frmTrackThread()
        {
            InitializeComponent();
        }

        private void frmTrackThread_Load(object sender, EventArgs e)
        {
            lblStatus.Text = "-Thread Starts-";
            Console.WriteLine("-Thread Starts-");
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Thread threadA = new Thread(MyThreadClass.Thread1);
            Thread threadB = new Thread(MyThreadClass.Thread2); 
            Thread threadC = new Thread(MyThreadClass.Thread1);
            Thread threadD = new Thread(MyThreadClass.Thread2); 

            threadA.Name = "Thread A";
            threadB.Name = "Thread B"; 
            threadC.Name = "Thread C";
            threadD.Name = "Thread D"; 

            threadA.Priority = ThreadPriority.Highest;
            threadB.Priority = ThreadPriority.Normal;
            threadC.Priority = ThreadPriority.AboveNormal;
            threadD.Priority = ThreadPriority.BelowNormal;

            threadA.Start();
            threadB.Start();
            threadC.Start();
            threadD.Start();

            threadA.Join();
            threadB.Join();
            threadC.Join();
            threadD.Join();

            lblStatus.Text = "-End Of Thread-";
            Console.WriteLine("-End Of Thread-");
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {
            
        }
    }
}
