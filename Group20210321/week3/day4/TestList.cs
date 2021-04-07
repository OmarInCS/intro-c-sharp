using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20210321.week3.day4 {
    class TestList {
        //static void Main(string[] args) {
        //    //int[] marks = new int[5];
        //    List<int> marks = new List<int>();
        //    marks.Add(23);
        //    marks.Add(17);
        //    marks.Add(20);
        //    marks.Add(13);

        //    PrintList(marks);
        //    Console.WriteLine(marks[0]);
        //    Console.WriteLine(marks.Count);

        //    marks.Insert(0, 25);
        //    PrintList(marks);

        //    marks.Remove(13);
        //    marks.RemoveAt(2);
        //    PrintList(marks);

        //    marks.Sort();
        //    PrintList(marks);
        //    marks.Reverse();
        //    PrintList(marks);

        //    Console.WriteLine(marks.Contains(23));
        //}

        public static void PrintList(List<int> lst) {
            Console.Write("[");
            foreach (int e in lst) {
                Console.Write(e + ", ");
            }
            Console.WriteLine("]");
        }
    }
}
