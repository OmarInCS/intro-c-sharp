using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20220619.week4.day2 {
    internal class Trainer : Employee, IEmployeeTotalSalary {

        public double Overtime { get; set; }

        public Trainer(int empId, string empName, double salary, double overtime) : base(empId, empName, salary) {
            Overtime = overtime;
        }

        public double GetTotalSalary() {
            return Salary + Overtime;
        }

    }
}
