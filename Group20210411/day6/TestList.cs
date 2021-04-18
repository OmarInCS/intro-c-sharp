using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20210411.day6 {
    class TestList {
        //static void Main(string[] args) {
        //    List<int> marks = new List<int>();
        //    marks.Add(23);
        //    marks.Add(17);
        //    marks.Add(25);
        //    marks.Add(13);

        //    Console.WriteLine(marks[0]);
        //    Console.WriteLine(marks.Count);
        //    Console.WriteLine(marks.Max());
        //    PrintList(marks);

        //    marks.Insert(0, 22);
        //    PrintList(marks);

        //    marks.Sort();
        //    PrintList(marks);

        //    marks.Remove(13);
        //    PrintList(marks);
        //    marks.RemoveAt(0);
        //    PrintList(marks);
        //}

        static void PrintList(List<int> lst) {
            Console.Write("[ ");
            foreach (int e in lst) {
                Console.Write(e + ", ");
            }
            Console.WriteLine("]");
        }
    }
}
