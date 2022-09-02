using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20220619.week4.day1 {
    internal class Trainer : Employee {

        public double Overtime { get; set; }

        public Trainer(int empId, string empName, double salary, double overtime) : base(empId, empName, salary) {
            Overtime = overtime;
        }

        public override double GetTotalSalary() {
            return Salary + Overtime;
        }

    }
}
