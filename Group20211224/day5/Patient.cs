using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20211224.day5 {
    class Patient {
        public string name;
        public double weight;
        public double height;

        public Patient(string n, double w, double h) {
            name = n;
            weight = w;
            height = h;
        }

        public Patient(Patient obj) {
            name = obj.name;
            weight = obj.weight;
            height = obj.height;
        }

        public double GetBMI() {
            return weight / Math.Pow(height / 100, 2);
        }

        public string GetStatus() {
            double bmi = GetBMI();
            if (bmi < 18.5) return "Underweight";
            else if (bmi < 25) return "Normal";
            else if (bmi < 30) return "Overweight";
            else return "Obese";
        }
    }
}
