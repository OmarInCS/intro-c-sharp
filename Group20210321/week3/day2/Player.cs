using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20210321.week3.day2 {
    class Player {
        public string name;
        public double weight;
        public double height;

        public Player() {

        }

        public Player(string name, double weight, double height) {
            this.name = name;
            this.weight = weight;
            this.height = height;
        }

        public Player(Player p) {
            this.name = p.name;
            this.weight = p.weight;
            this.height = p.height;
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
