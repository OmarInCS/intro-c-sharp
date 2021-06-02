using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20210524.week2.day4 {
    class Rectangle : Shape {
        public double width;
        public double length;

        public Rectangle(double w, double l, ConsoleColor color) : base(color) {
            width = w;
            length = l;
        }

        public double GetArea() {
            return width * length;
        }

        public override string ToString() {
            return $"Rectangle: {width}, {length}, area: {GetArea()}";
        }
    }
}
