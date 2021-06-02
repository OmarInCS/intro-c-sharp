using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20210524.week2.day3 {
    class Student {
        private string name; // instance variable
        private double mark; // instance variable
        public static int fullMark = 25;

        public string Name { get; set; }
        public double Mark {
            get {
                return mark;
            }

            set {
                if (value >= 0) {
                    mark = value;
                }
                else {
                    Console.WriteLine("negative values are not allowed!!");
                }
            }
        }

        public Student(string n, double m) {
            name = n;
            mark = m;
        }

        public double GetPercent() => mark / fullMark * 100;
            
        public string GetGrade() {
            double pct = GetPercent();
            if (pct > 85) return "Excellent";
            else if (pct > 75) return "V. Good";
            else if (pct > 65) return "Good";
            else if (pct >= 50) return "Pass";
            else  return "Fail";
        }
    }
}
