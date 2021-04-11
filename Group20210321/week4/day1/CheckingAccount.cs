using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20210321.week4.day1 {
    class CheckingAccount : Account {
        public int Limit { get; set; }

        public CheckingAccount(string name, double balance, int limit) : base(name, balance) {
            this.Limit = limit;
        }

        public override void Withdraw(double amount) {
            if (Balance - amount >= -Limit) {
                base.Withdraw(amount);
            }
        }
    }
}
