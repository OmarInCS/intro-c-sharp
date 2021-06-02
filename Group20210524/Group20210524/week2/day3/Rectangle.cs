using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20210524.week2.day3 {
    class Rectangle {
        public double width;
        public double length;

        public Rectangle(double w, double l) {
            width = w;
            length = l;
        }

        public double GetArea() {
            return width * length;
        }
    }
}
