using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20220619.week4.day2 {
    internal class SalesPerson : Employee, IEmployeeTotalSalary {

        public double Comm { get; set; }

        public SalesPerson(int empId, string empName, double salary, double comm) 
            : base(empId, empName, salary) {
            Comm = comm;
        }

        public double GetTotalSalary() {
            return Salary + Salary * Comm;
        }
    }
}
