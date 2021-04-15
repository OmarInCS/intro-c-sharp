using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20210411.day4 {
    class TestStudent {
        static void Main(string[] args) {
            Student s1 = new Student("Omar", 19);
            Student s2 = new Student("Ahmed", 25);
            Student s3 = s2;

            //Student.FullMark = 30;
            s3.Mark = 15;

            Console.WriteLine($"{s1.Name}: {s1.Percentage}, {s1.Status}");
            Console.WriteLine($"{s2.Name}: {s2.Percentage}, {s2.Status}");
        }
    }
}
