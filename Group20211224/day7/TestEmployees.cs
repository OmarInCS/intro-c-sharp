using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20211224.day7 {
    class TestEmployees {
        //static void Main(string[] args) {
        //    Trainer t1 = new Trainer(101, "Ahmed", 8000);
        //    SalesPerson s1 = new SalesPerson(102, "Wael", 6000, 0.2);
        //    //Employee e1 = new Employee(103, "Ali", 10000);

        //    t1.overTime = 1000;


        //    //Console.WriteLine($"{t1.empName}: {t1.GetAnnualSalary()}, {t1.GetTotalSalary()}");
        //    //Console.WriteLine($"{s1.empName}: {s1.GetAnnualSalary()}, {s1.GetTotalSalary()}");
        //    WriteEmployee(t1);
        //    WriteEmployee(s1);
        //}

        static void WriteEmployee(Employee e) {
            //Console.WriteLine($"{e.empName}: {e.GetAnnualSalary()}, {e.GetTotalSalary()}");
            Console.WriteLine(e);

            //if (e is Trainer) {
            //    Console.WriteLine((e as Trainer).GetTotalSalary());
            //}
            //else if (e is SalesPerson) {
            //    Console.WriteLine((e as SalesPerson).GetTotalSalary());
            //}
        }
    }
}
