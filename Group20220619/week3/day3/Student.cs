using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20220619.week3.day3 {
    internal class Student {

        public string name;
        private List<double> marks;
        public static int fullMark;


        public Student(string name) {
            this.name = name;
            this.marks = new List<double>();
        }

        public void AddMark(double m) {
            marks.Add(m);
        }

        public void DropMark(int i) {
            marks.RemoveAt(i);
        }

        public double GetPercent => marks.Average() / fullMark * 100;

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
