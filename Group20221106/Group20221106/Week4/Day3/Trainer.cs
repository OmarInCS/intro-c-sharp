using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20221106.Week4.Day3 {
    internal class Trainer : Employee {

        public double Overtime { get; set; }

        public Trainer(int empId, string empName, double salary) : base(empId, empName, salary) {
            Overtime = 0;
        }

        public override double TotalSalary() {
            return Salary + Overtime;
        }

    }
}
