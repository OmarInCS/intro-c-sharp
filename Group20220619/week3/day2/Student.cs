using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20220619.week3.day2 {
    internal class Student {

        public string name;
        private double mark;
        public static int fullMark;

        public double Mark {
            set {
                if (value >= 0) {
                    mark = value;
                }
                else {
                    Console.WriteLine("Invalid new mark");
                }
            }

            get {
                return mark;
            }
        }


        public Student(string name, double mark) {
            this.name = name;
            this.mark = mark;
        }

        public double GetPercent => mark / fullMark * 100;

        public string GetGrade {
            get {
                double pct = GetPercent;
                if (pct > 85) return "Excellent";
                else if (pct > 75) return "V. Good";
                else if (pct > 65) return "Good";
                else if (pct >= 50) return "Pass";
                else return "Fail";
            }
        }

    }
}
