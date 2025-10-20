using System;
using System.Windows.Forms;

namespace OrganizationProfile
{
    public partial class FrmStudentRecord : Form
    {
        public FrmStudentRecord(string studentNo, string fullName, string program, string gender, string age, string birthday, string contactNo)
        {
            InitializeComponent();

            // Display the passed data in the form labels
            lblStudentNo.Text = studentNo;
            lblFullName.Text = fullName;
            lblProgram.Text = program;
            lblGender.Text = gender;
            lblAge.Text = age;
            lblBirthday.Text = birthday;
            lblContactNo.Text = contactNo;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
