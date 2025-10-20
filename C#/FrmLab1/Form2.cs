using System;
using System.Windows.Forms;

namespace TextFileCreatorApp
{
    public partial class FrmFileName : Form
    {
        public static string SetFileName;

        public FrmFileName()
        {
            InitializeComponent();
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            SetFileName = txtFileName.Text + ".txt";
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
