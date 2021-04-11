using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20210321.week4.day1 {
    class Account {
        public string name;
        private double balance;
        public static double annualRate = 0.04;

        public double Balance {
            get {
                return balance;
            }
            
        }


        public Account(string name, double balance) {
            this.name = name;
            this.balance = balance;
        }

        public static double GetMonthlyRate() {
            return annualRate / 12;
        }

        public double GetMonthlyInt() {
            return GetMonthlyRate() * balance;
        }

        public void Deposit(double amount) {
            balance += amount;
        }

        public virtual void Withdraw(double amount) {
            balance -= amount;
        }

        
    }
}
