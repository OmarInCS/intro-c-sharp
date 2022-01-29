using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20211224.day7 {
    class Trainer : Employee {
        public double overTime;

        public Trainer(int empId, string empName, double salary) : base(empId, empName, salary) {
            this.overTime = 0;
        }

        public override double GetTotalSalary() {
            return base.salary + overTime;
        }
    }
}
