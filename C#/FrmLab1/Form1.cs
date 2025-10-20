using System;
using System.IO;
using System.Windows.Forms;

namespace TextFileCreatorApp
{
    public partial class FrmLab1 : Form
    {
        public FrmLab1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FrmFileName frmFileName = new FrmFileName();
            frmFileName.ShowDialog();

            string getInput = txtInput.Text;
            //local file
            string filePath = Path.Combine(@"E:\C#\FrmLab1", FrmFileName.SetFileName);

            using (StreamWriter outputFile = new StreamWriter(filePath))
            {
                outputFile.WriteLine(getInput);
                Console.WriteLine(getInput);
            }
        }

        private void FrmLab1_Load(object sender, EventArgs e)
        {

        }
    }
}
