using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20220619.week2.day3 {
    internal class MyMethods {

        //public static double CalcBMI(double weight, double height) {
        //    return weight / Math.Pow(height / 100, 2);
        //}

        public static double CalcBMI(double weight, double height) => weight / Math.Pow(height / 100, 2);

        public static double GetPercent(double m=20, double fm=20) {
            return m / fm * 100;
        }

        public static void GetPercent(ref double pct, double m = 20, double fm = 20) {
            Console.WriteLine(pct);
            pct = m / fm * 100;
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

        public static void WriteArray(int[] arr) {
            Console.Write("[ ");
            foreach (int n in arr) {
                Console.Write(n + ", ");
            }
            Console.WriteLine("]");
        }

        public static void WriteList(List<double> lst) {
            Console.Write("[ ");
            foreach (int n in lst) {
                Console.Write(n + ", ");
            }
            Console.WriteLine("]");
        }

        public static void WriteDict(Dictionary<string, string> dict) {
            Console.Write("[ ");
            foreach (var n in dict) {
                Console.Write(n.Key + ": " + n.Value + ", ");
            }
            Console.WriteLine("]");
        }
    }
}
