using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20210411.day4 {
    class Employee {
        //private string name;
        public double salary;
        private int hireYear; // instance field

        //private static int count;
        public static int Count { get; private set; }

        public int HireYear {   // instance property
            get {
                return hireYear;
            }
            set {
                if (value >= 2005 && value < DateTime.Today.Year) {
                    hireYear = value;
                }
            }
        }
        public string Name { get; set; }

        public Employee(string name, double salary, int hireYear) {
            this.Name = name;
            this.salary = salary;
            this.hireYear = hireYear;
            Count++;
        }

        public double GetAnnualSalary() => salary * 12;

        //public double AnnualSalary {
        //    get {
        //        return salary * 12;
        //    }
        //}

        public double AnnualSalary => salary * 12;

        public int GetServicePeriod() => DateTime.Today.Year - hireYear;
    }
}
