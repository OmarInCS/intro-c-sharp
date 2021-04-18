using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20210411.day6 {
    class Course {
        public string Title { get; set; }
        public double Price { get; set; }
        public List<string> Students { get; }

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
        
        public static bool operator >(Course c1, Course c2) {
            return c1.Price > c2.Price;
        }

        public static bool operator <(Course c1, Course c2) {
            return c1.Price < c2.Price;
        }

        public static Course operator +(Course c, string name) {
            c.Students.Add(name);
            return c;
        }
    }
}
