using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20210524.week2.day4 {
    class Course {
        public string Title { get; set; }
        public List<string> Students { get; set; }

        public Course(string title) {
            Title = title;
            Students = new List<string>();
        }

        public void AddStudent(string name) {
            Students.Add(name);
        }

        public void DropStudent(string name) {
            Students.Remove(name);
        }

        public void ShowStudents() {
            foreach (string name in Students) {
                Console.WriteLine("* " + name);
            }
            Console.WriteLine("----------------");
        }

        public int GetNumOfStudents() {
            return Students.Count;
        }

        public static bool operator >(Course c1, Course c2) {
            return c1.GetNumOfStudents() > c2.GetNumOfStudents();
        }

        public static bool operator <(Course c1, Course c2) {
            return c1.GetNumOfStudents() < c2.GetNumOfStudents();
        }

        public static Course operator +(Course c, string name) {
            c.AddStudent(name);
            return c;
        }
    }
}
