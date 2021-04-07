using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20210321.week3.day3 {
    class Student {
        public string name;
        private double mark;    // field
        public static int fullMark = 25;
        public static int count = 0;

        public double Mark {    // property
            set {
                if (value >= 0) {
                    mark = value;
                }
            }
            get {
                return mark;
            }
        }

        public Student(string name, double mark) {
            this.name = name;
            this.mark = mark;
            count++;
        }

        public double GetPercentage() {
            return mark / fullMark * 100;
        }

        public string GetGrade() {
            double pct = GetPercentage();
            if (pct > 85) return "Excellent";
            else if (pct > 75) return "V. Good";
            else if (pct > 65) return "Good";
            else if (pct >= 50) return "Pass";
            else return "Fail";
        }

        public override String ToString() {
            return $"Student: {name}, {mark}\n";
        }
    }
}
