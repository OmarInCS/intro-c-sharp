using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20210321.week3.day2 {
    class Rectangle {
        public double width;
        public double length;

        public Rectangle() {

        }

        public Rectangle(double width, double length) {
            this.width = width;
            this.length = length;
        }

        public double GetArea() {
            return this.width * this.length;
        }
    }
}
