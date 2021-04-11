using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20210411.day1 {
    class CheckInsurrance {
        static void Main(string[] args) {
            Console.Write("Enter the marital status: ");
            string status = Console.ReadLine().ToUpper();
            Console.Write("Enter the gender: ");
            string gender = Console.ReadLine().ToUpper();
            Console.Write("Enter the age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (status.StartsWith("M") || gender.StartsWith("M") && age > 30 || gender.StartsWith("F") && age > 25) {
                Console.WriteLine("Eligiable for Inssurance");
            }
            else {
                Console.WriteLine("Not eligiable for Inssurance");
            }

            //var emp = (status, gender, age);

            //switch (emp) {
            //    case (string, string, int) e when e.status.StartsWith("M"):
            //        Console.WriteLine("Inssurance");
            //        break;

            //}
        }
    }
}
