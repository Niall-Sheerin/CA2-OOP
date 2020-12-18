using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA2_S00200760
{
    public class Employee
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmployeeStatus { get; set; }


        public Employee(string firstname, string lastname, string employeestatus)
        {
            FirstName = firstname;
            LastName = lastname;
            EmployeeStatus = employeestatus;
          
        }

        public override string ToString()
        {
            LastName = LastName.ToUpper();
            return string.Format($"{LastName},{FirstName},{ EmployeeStatus}");

        }

    }

    class FullTimeEmployee : Employee
    {
        public decimal Salary { get; set; }

        public FullTimeEmployee(string firstname, string lastname, string employeestaus, decimal salary) : base(firstname, lastname, "Full Time")
        {
            Salary = salary;
        }

        


    }

    class PartTimeEmployee : Employee
    {
        public decimal HourlyRate { get; set; }

        public decimal Hoursworked { get; set; }

        public PartTimeEmployee(string firstname, string lastname, string employeestaus, decimal hourlyrate, decimal hoursworked) : base(firstname, lastname, "Part Time")
        {
            HourlyRate = hourlyrate;
            Hoursworked = hoursworked;

        }


    }


}
