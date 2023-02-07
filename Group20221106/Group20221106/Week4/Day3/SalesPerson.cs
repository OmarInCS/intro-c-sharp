using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20221106.Week4.Day3 {
    internal class SalesPerson : Employee {

        public double Comm { get; set; }

        public SalesPerson(int empId, string empName, double salary, double comm) : base(empId, empName, salary) {
            Comm = comm;
        }

        public override double TotalSalary() {
            return Salary + Salary * Comm;
        }


    }
}
