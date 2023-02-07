using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20221106.Week4.Day3 {
    internal abstract class Employee {

        public int EmpId { get; set; }

        public string EmpName { get; set; }

        public double Salary { get; set; }

        public Employee(int empId, string empName, double salary) {
            EmpId = empId;
            EmpName = empName;
            Salary = salary;
        }

        //public virtual double TotalSalary() {
        //    return Salary;
        //}
        public abstract double TotalSalary();

        public double AnnualSalary() {
            return TotalSalary() * 12;
        }
    }
}
