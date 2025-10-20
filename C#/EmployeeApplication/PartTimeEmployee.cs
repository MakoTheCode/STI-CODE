using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeInterface;
namespace EmployeeNamespace
{
    internal class PartTimeEmployee : IEmployee
    {

        private string first_name;
        private string last_name;
        private string department;
        private string job_title;
        private double basic_salary;

        public string FirstName
        {
            get { return this.first_name; }
            set { this.first_name = value; }
        }

        public string LastName
        {
            get { return this.last_name; }
            set { this.last_name = value; }
        }

        public string Department
        {
            get { return this.department; }
            set { this.department = value; }
        }

        public string JobTitle
        {
            get { return this.job_title; }
            set { this.job_title = value; }
        }

        public double BasicSalary
        {
            get { return this.basic_salary; }
            set { this.basic_salary = value; }
        }

        public PartTimeEmployee(string FName, string LName, string dept, string job)
        {
            this.first_name = FName;
            this.last_name = LName;
            this.department = dept;
            this.job_title = job;
        }

        public void computeSalary(int hoursWorked, double ratePerHour)
        {
            this.basic_salary = hoursWorked * ratePerHour;
        }

        public double getSalary()
        {
            return BasicSalary;
        }

    }
}