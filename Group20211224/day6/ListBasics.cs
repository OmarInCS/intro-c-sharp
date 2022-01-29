using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20211224.day6 {
    class ListBasics {
        //static void Main(string[] args) {
        //    //int[] x = new int[5];
        //    var marks = new List<int>();
        //    marks.Add(70);
        //    marks.Add(66);
        //    marks.Add(48);
        //    marks.Add(35);

        //    WriteList(marks);
        //    marks.Insert(0, 55);

        //    WriteList(marks);

        //    Console.WriteLine(marks[1]);
        //    Console.WriteLine(marks.Count);
        //    Console.WriteLine(marks.Max());

        //    marks.RemoveAt(1);
        //    WriteList(marks);
        //    marks.Remove(66);
        //    WriteList(marks);
        //}

        static void WriteList(List<int> lst) {
            Console.Write("[ ");
            foreach (var n in lst) {
                Console.Write(n + ", ");
            }
            Console.WriteLine(" ]");
        }
    }
}
