using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20220619.week4.day2 {
    internal class Employee {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public double Salary { get; set; }

        public Employee(int empId, string empName, double salary) {
            EmpId = empId;
            EmpName = empName;
            Salary = salary;
        }

        public double GetAnnualSalary() {
            return Salary * 12;
        }
    }
}
