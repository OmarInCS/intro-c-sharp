using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20211224.day5 {
    class Student {
        public string name;
        private double mark;    // instance variable/field
        public static int fullMark = 25;

        // property
        public double Mark {
            get {
                return mark;
            }

            set {
                if (value >= 0) {
                    mark = value;
                }
                else {
                    Console.WriteLine("Invalid Input");
                }
            }
        }

        public Student(string name, double mark) {
            this.name = name;
            this.mark = mark;
        }

        public double GetPercent() {
            return mark / fullMark * 100;
        }

        public string GetGrade() {
            double pct = GetPercent();
            if (pct > 85) return "Excellent";
            else if (pct > 75) return "V. Good";
            else if (pct > 65) return "Good";
            else if (pct >= 50) return "Pass";
            else return "Fail";
        }
    }
}
