using System;
using System.IO;
using System.Windows.Forms;

namespace FrmRegistration
{
    public partial class FrmStudentRecord : Form
    {
        string path = @"E:\C#\FrmRegistration";

        public FrmStudentRecord()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
          
            lvShowInfo.Items.Clear();

            if (Directory.Exists(path))
            {
                var files = Directory.GetFiles(path, "*.txt");

                foreach (var file in files)
                {
                    using (StreamReader streamReader = new StreamReader(file))
                    {
                        string fileContent;
                        while ((fileContent = streamReader.ReadLine()) != null)
                        {
                            lvShowInfo.Items.Add(fileContent);
                        }
                        lvShowInfo.Items.Add("");
                    }
                }
            }
            else
            {
                MessageBox.Show("Directory not found!");
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully Uploaded!");
            lvShowInfo.Clear();
        }
    }
}
