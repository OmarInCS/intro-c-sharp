using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20220619.week4.day1 {
    internal class TestPolymorphism {

        public static void ShowEmpDetails(Employee e) {
            Console.WriteLine(e.EmpName);
            Console.WriteLine(e.Salary);
            Console.WriteLine(e.GetAnnualSalary());

            //if (e is Trainer) {
            //    Console.WriteLine((e as Trainer).GetTotalSalary());
            //}
            //else if (e is SalesPerson) {
            //    Console.WriteLine((e as SalesPerson).GetTotalSalary());
            //}

            //switch (e) {
            //    case Trainer t:
            //        Console.WriteLine(t.GetTotalSalary());
            //        break;
            //    case SalesPerson s:
            //        Console.WriteLine(s.GetTotalSalary());
            //        break;
            //}

            Console.WriteLine(e.GetTotalSalary());


            Console.WriteLine("---------------------");
        }
    }
}
