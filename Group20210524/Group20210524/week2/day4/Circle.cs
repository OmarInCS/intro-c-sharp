using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20210524.week2.day4 {
    class Circle : Shape {
        public double Radius { get; set; }

        public Circle(double radius, ConsoleColor color) : base(color) {
            Radius = radius;
        }

        public double GetArea() {
            return Math.PI * Radius * Radius;
        }

        public override string ToString() {
            return $"Circle: {Radius}, area: {GetArea()}";
        }
    }
}
