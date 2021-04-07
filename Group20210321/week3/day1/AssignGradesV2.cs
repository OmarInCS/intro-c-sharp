using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20210321.week3.day1 {
    class AssignGradesV2 {

        //static void Main(string[] args) {
        //    Console.Write("Enter num. of std.: ");
        //    int n = int.Parse(Console.ReadLine());

        //    double[] marks = ReadMarks(n);

        //    double best = marks.Max();

        //    PrintGrades(marks, best);
        //}

        public static double[] ReadMarks(int n) {
            double[] marks = new double[n];
            for (int i = 0; i < n; i++) {
                Console.Write("Enter std. mark: ");
                marks[i] = double.Parse(Console.ReadLine());
            }

            return marks;
        }

        public static void PrintGrades(double[] marks, double best) {
            foreach (double m in marks) {
                if (m >= best - 10) {
                    Console.WriteLine(m + " => A");
                }
                else if (m >= best - 20) {
                    Console.WriteLine(m + " => B");
                }
                else if (m >= best - 30) {
                    Console.WriteLine(m + " => C");
                }
                else if (m >= best - 40) {
                    Console.WriteLine(m + " => D");
                }
                else {
                    Console.WriteLine(m + " => F");
                }

            }
        }
    }
}
