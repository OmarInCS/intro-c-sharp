using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20210411.day4 {
    class Student {
        public string Name { get; set; }
        public static int FullMark { get; set; } = 25;

        private double mark;
        public double Mark {
            get => mark;
            set {
                if (value >= 0 && value <= FullMark) {
                    mark = value;
                }
            }
        }
        
        public Student(string name, double mark) {
            this.Name = name;
            this.Mark = mark;
        }
        
        public double Percentage => Mark / FullMark * 100;
        
        public string Status {
            get {
                if (Percentage > 85) return "Excellent";
                else if (Percentage > 75) return "V. Good";
                else if (Percentage > 65) return "Good";
                else if (Percentage >= 50) return "Pass";
                else return "Fail";
            }
        }
    }
}
