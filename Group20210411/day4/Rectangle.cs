using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20210411.day4 {
    class Rectangle {
        public double width;
        public double height;

        public Rectangle() {
            Random rand = new Random();
            width = Math.Round(rand.NextDouble() * 10, 2);
            height = Math.Round(rand.NextDouble() * 10, 2);
        }

        public Rectangle(double width, double height) {
            this.width = width;
            this.height = height;
        }

        public double GetArea() => this.width * this.height;
        
    }
}
