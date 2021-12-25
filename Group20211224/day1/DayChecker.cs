using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20211224.day1 { // 0599888921
    class DayChecker {
        static void Main(string[] args) {
            Console.WriteLine("Enter a day number: ");
            int day = Convert.ToInt32(Console.ReadLine());

            if (day >= 1 && day <= 5) {
                Console.WriteLine("Work-day");
            }
            else if (day == 6 || day == 7) {
                Console.WriteLine("Off-day");
            }
            else {
                Console.WriteLine("Invalid day number");
            }

            switch(day) {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
            }
        }
    }
}
