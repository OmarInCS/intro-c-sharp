using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20211224.day7 {
    abstract class Employee : object{
        public int empId;
        public string empName;
        public double salary;

        public Employee(int empId, string empName, double salary) {
            this.empId = empId;
            this.empName = empName;
            this.salary = salary;
        }

        public double GetAnnualSalary() {
            return salary * 12;
        }

        public abstract double GetTotalSalary();

        public override string ToString() {
            return $"{empName}: {GetAnnualSalary()}, {GetTotalSalary()}";
        }

    }
}
