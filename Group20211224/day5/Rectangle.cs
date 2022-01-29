using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20211224.day5 {
    class Rectangle {
        public double width;
        public double length;

        public Rectangle(double w, double l) {
            width = w;
            length = l;
        }

        public double GetArea() {
            return this.width * this.length;
        }
    }
}
