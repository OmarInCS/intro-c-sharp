using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20221106.Week3.Day1 {
    internal class MyMethods {

        public static double GetBMI(double weight, double height) {
            return weight / Math.Pow(height / 100, 2);
        }

        public static string GetStatus(double bmi) {
            if (bmi < 18.5) return "Underweight";
            else if (bmi < 25) return "Normal";
            else if (bmi < 30) return "Overweight";
            else return "Obese";
        }


        public static double GetPercent(double m = 30, int fm = 30) {
            return m / fm * 100;
        }

        public static void GetPercent(ref double pct, double m = 30, int fm = 30) {
            Console.WriteLine(pct);
            pct =  m / fm * 100;
        }

    }
}
