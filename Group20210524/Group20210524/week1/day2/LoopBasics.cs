using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20210524.week1.day2 {
    class LoopBasics {
        static void Main(string[] args) {
            int x = 10;
            while (x <= 100) {
                Console.Write(x + "\t");
                x += 10;
            }
            Console.WriteLine();
            Console.WriteLine("----------------------");

            int y = 1;
            do {
                Console.Write(y + "\t");
                y++;
            } while (y <= 10);
            Console.WriteLine();
            Console.WriteLine("----------------------");

            for (int z = 1; z <= 10; z++) {
                Console.Write(z + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("----------------------");
        }
    }
}
