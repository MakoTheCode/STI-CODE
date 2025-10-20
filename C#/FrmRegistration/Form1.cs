using System;
using System.IO;
using System.Windows.Forms;

namespace FrmRegistration
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string savePath = @"E:\C#\FrmRegistration";
            Directory.CreateDirectory(savePath); 

            
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(savePath, txtStudentNo.Text + ".txt")))
            {
                outputFile.WriteLine("Student No.: " + txtStudentNo.Text);
                outputFile.WriteLine("Full Name: " + txtLastName.Text + ", " + txtFirstName.Text + ", " + txtMI.Text);
                outputFile.WriteLine("Program: " + cbProgram.SelectedItem.ToString());
                outputFile.WriteLine("Gender: " + cbGender.SelectedItem.ToString());
                outputFile.WriteLine("Age: " + txtAge.Text);
                outputFile.WriteLine("Birthday: " + dtpBirthday.Text);
                outputFile.WriteLine("Contact No.: " + txtContactNo.Text);
            }

            MessageBox.Show("Registration successful! Record saved to " + savePath);
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            FrmStudentRecord record = new FrmStudentRecord();
            record.ShowDialog();
        }
    }
}
