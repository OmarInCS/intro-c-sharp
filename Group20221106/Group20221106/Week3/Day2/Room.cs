using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20221106.Week3.Day2 {
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
