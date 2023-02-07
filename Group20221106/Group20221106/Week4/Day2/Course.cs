using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20221106.Week4.Day2 {
    internal class Course {

        public string Title { get; set; }

        public double Price { get; set; }

        public List<string> Students { get; set; }

        public Course(string title, double price) {
            Title = title;
            Price = price;
            Students = new List<string>();
        }

        public void AddStudent(string name) {
            Students.Add(name);
        }

        public void DropStudent(string name) {
            Students.Remove(name);
        }

        public int NumOfStudents => Students.Count;

        public string StudentsList => $"[{string.Join(",", Students)}]";
    }
}
