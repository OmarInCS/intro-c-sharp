using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20220619.week4.day2 {
    internal class TestInterface {

        public static void ShowEmpDetails(IEmployeeTotalSalary e) {

            Console.WriteLine(e.GetTotalSalary());


            Console.WriteLine("---------------------");
        }
    }
}
