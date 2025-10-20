using System;
using System.Threading;
using System.Windows.Forms;

namespace BasicThreadApp
{
    public partial class FrmBasicThread : Form
    {

        Thread ThreadA;
        Thread ThreadB;

        public FrmBasicThread()
        {
            InitializeComponent();
            lblStatus.Text = "Press 'Run' to start threads...";
        }


        private void btnRun_Click(object sender, EventArgs e)
        {

            lblStatus.Text = "Threads Running...";
            ThreadA = new Thread(MyThreadClass.Thread1);
            ThreadB = new Thread(MyThreadClass.Thread1);

            ThreadA.Name = "Thread A";
            ThreadB.Name = "Thread B";

            Console.WriteLine("-Before starting Thread-");
            
            ThreadA.Start();
            ThreadB.Start();

            ThreadA.Join();
            ThreadB.Join();


            lblStatus.Text = "End Of Thread";
            Console.WriteLine("-End Of Thread-");
        }


        private void FrmBasicThread_Load(object sender, EventArgs e)
        {

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
