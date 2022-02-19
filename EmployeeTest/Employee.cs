using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTest
{
    internal class Employee
    {
        private string firstName;
        private string lastName;
        private int age;
        private long employeeID;
        private string department;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public long EmployeeID { get { return employeeID; } set { employeeID = value; } }
        public string Department { get; set; }

        public Employee(string firstName, string lastName, int age, long employeeID, string department)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.EmployeeID = employeeID;
            this.Department = department;
        }

        public string getEmployeeLocation()
        {
            if (this.Department == "Technology" || this.Department == "HR")
                return "Work from Home";
            else if (this.Department == "NSS" || this.Department == "ISS")
                return "Office";
            else
                return "Yet to be decided";
        }

        public string getEmployeeInfo()
        {
            return FirstName + " " + LastName + ", " + EmployeeID;
        }

        public override string ToString()
        {
            return "Employee ID - " + EmployeeID + 
                "\nName - " + FirstName + " " + LastName + 
                "\nDepartment - " + Department;
        }
    }
}
