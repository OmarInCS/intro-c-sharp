using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20211224.day7 {
    class FileRW {
        static void Main(string[] args) {
            string path1 = "C:\\Users\\Mr Omar\\Desktop\\words.txt";
            //var content = File.ReadAllText(path1);
            var content = File.ReadAllLines(path1);
            Console.WriteLine(content[0]);
            Console.WriteLine(content[1]);
            Console.WriteLine(content.Length);


            string path2 = "C:\\Users\\Mr Omar\\Desktop\\marks.txt";
            string[] marks = {"23", "25", "13", "17"};
            File.WriteAllLines(path2, marks);
        }
    }
}
