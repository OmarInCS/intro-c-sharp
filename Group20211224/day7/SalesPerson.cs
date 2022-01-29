using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20211224.day7 {
    class SalesPerson : Employee {

        public double comm;

        public SalesPerson(int empId, string empName, double salary, double comm) : base(empId, empName, salary) {
            this.comm = comm;
        }

        public override double GetTotalSalary() {
            return salary + salary * comm;
        }
    }
}
