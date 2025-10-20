using EmployeeNamespace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeApplication
{
    public partial class frmComputeSalary : Form
    {
        public frmComputeSalary()
        {
            InitializeComponent();
        }
        private void computeSalary_Click(object sender, EventArgs e)
        {
            PartTimeEmployee partTimeEmploy = new PartTimeEmployee(firstNameBox.Text, lastNameBox.Text, departmentBox.Text, jobTitleBox.Text);
            if (int.TryParse(totalHoursBox.Text, out int totalHours) && Double.TryParse(rateHourBox.Text, out double rateHours))
            {

                partTimeEmploy.computeSalary(totalHours, rateHours);
                firstNameLabel.Text = partTimeEmploy.FirstName;
                lastNameLabel.Text = partTimeEmploy.LastName;
                basicSalaryLabel.Text = partTimeEmploy.getSalary().ToString("F2");

            }
            else
            {
                MessageBox.Show("Please enter correct input value.");
            }
        }

        private void frmComputeSalary_Load(object sender, EventArgs e)
        {

        }
    }
}
