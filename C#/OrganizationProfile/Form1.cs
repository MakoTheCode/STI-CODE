using OrganizationProfile;
using System;
using System.IO;
using System.Windows.Forms;

namespace OrganizationProfile
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, txtStudentNo.Text + ".txt")))
            {
                outputFile.WriteLine("Student No.: " + txtStudentNo.Text);
                outputFile.WriteLine("Full Name: " + txtLastName.Text + ", " + txtFirstName.Text + ", " + txtMI.Text);
                outputFile.WriteLine("Program: " + cbProgram.SelectedItem.ToString());
                outputFile.WriteLine("Gender: " + cbGender.SelectedItem.ToString());
                outputFile.WriteLine("Age: " + txtAge.Text);
                outputFile.WriteLine("Birthday: " + dtpBirthday.Text);
                outputFile.WriteLine("Contact No.: " + txtContactNo.Text);
            }
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            
            string studentNo = txtStudentNo.Text;
            string fullName = txtLastName.Text + ", " + txtFirstName.Text + ", " + txtMI.Text;
            string program = cbProgram.SelectedItem.ToString();
            string gender = cbGender.SelectedItem.ToString();
            string age = txtAge.Text;
            string birthday = dtpBirthday.Text;
            string contactNo = txtContactNo.Text;

            
            FrmStudentRecord record = new FrmStudentRecord(studentNo, fullName, program, gender, age, birthday, contactNo);
            record.ShowDialog();
        }
    }
}