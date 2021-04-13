using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20210411.day3 {
    class MyMethods {

        public static double GetBMI(double weight, double height) {
            return weight / Math.Pow(height / 100, 2);
        }

        public static string GetStatus(double bmi) {
            if (bmi < 18.5) return "Underweight";
            else if (bmi < 25) return "Normal";
            else if (bmi < 30) return "Overweight";
            else return "Obese";
        }

        public static double GetPercentage(double mark=25, int fullMark=25) {
            return mark / fullMark * 100;
        }

        public static void GetPercentage(double mark, int fullMark, out double pct) {
            pct = mark / fullMark * 100;
        }

        public static string GetGrade(ref double pct) {
            //pct += 2;
            if (pct > 85) return "Excellent";
            else if (pct > 75) return "V. Good";
            else if (pct > 65) return "Good";
            else if (pct >= 50) return "Pass";
            else return "Fail";
        }

    }
}
