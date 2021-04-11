using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20210321.week4.day1 {
    class Circle : Shape {

        public double Radius { get; set; }

        public Circle(double radius, ConsoleColor color) : base(color) {
            this.Radius = radius;
        }

        public double GetArea() {
            return Math.PI * Radius * Radius;
        }

        public override string ToString() {
            return $"Circle [Area: {GetArea()}]";
        }

    }
}
