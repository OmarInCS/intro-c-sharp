using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20210524.week2.day2 {
    class MyMethods {

        public static double GetBMI(double weight, double height) {
            return weight / Math.Pow(height / 100, 2);
        }

        public static string GetStatus(double bmi) {
            if (bmi < 18.5) {
                return "Underweight";
            }
            else if (bmi < 25) {
                return "Normal";
            }
            else if (bmi < 30) {
                return "Overweight";
            }
            else {
                return "Obese";
            }
        }
    }
}
