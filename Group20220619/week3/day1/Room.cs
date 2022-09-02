using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20220619.week3.day1 {
    internal class Room {
        public double width;
        public double length;

        public Room(double w, double l) {
            width = w;
            length = l;
        }

        public double GetArea() {
            return width * length;
        }
    }
}
