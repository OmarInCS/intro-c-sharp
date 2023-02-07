using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20221106.Week4.Day1 {
    internal class Student {

        public string name;
        private double mark;
        public static int fullMark;


        public double Mark {
            get {
                return mark;
            }

            set {
                if (value >= 0) {
                    mark = value;
                }
                else {
                    Console.WriteLine("Invalid mark");
                }
            }
        }


        public Student(string name, double mark) {
            this.name = name;
            this.mark = mark;
        }

        public Student() : this("Unknown", 25) {

        }

        //public Student() {
        //    name = "Unknown";
        //    mark = 25;
        //}

        public double Percent => mark / fullMark * 100;

        public string Grade {
            get {
                double pct = Percent;
                if (pct > 85) return "Excellent";
                else if (pct > 75) return "V. Good";
                else if (pct > 65) return "Good";
                else if (pct >= 50) return "Pass";
                else return "Fail";
            }
        }
    }
}
