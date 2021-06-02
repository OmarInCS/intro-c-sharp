using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20210524.week2.day4 {
    class Account {
        public string Name { get; set; }
        public double Balance { get; private set; }
        public static double AnnualRate { get; set; } = 0.04;

        public Account(string name, double balance) {
            Name = name;
            Balance = balance;
        }

        public static double GetMonthlyRate() {
            return AnnualRate / 12;
        }

        public double GetMonthlyInt() {
            return Balance * GetMonthlyRate();
        }

        public void Deposit(double amount) {
            Balance += amount;
        }

        public void Withdraw(double amount) {
            Balance -= amount;
        }
    }
}
