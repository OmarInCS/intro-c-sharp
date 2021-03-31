using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20210321.week2.day4 {
    class MyMethods {

        public static double GetBMI(double weight, double height) {
            
            return weight / Math.Pow(height / 100, 2);
        }

        public static double GetPercentage(double mark=25, double fullMark=25) {
            return mark / fullMark * 100;
        }

        public static string GetStatus(double bmi) {
            if (bmi < 18.5) return "Underweight";
            else if (bmi < 25) return "Normal";
            else if (bmi < 30) return "Overweight";
            else return "Obese";
        }

        public static void FindBMIAndStatus(double weight, double height, out double bmi, out string status) {
            bmi = GetBMI(weight, height);
            status = GetStatus(bmi);
        }

    }
}
