using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20210411.day5 {
    class CheckingAccount : Account {
        public int Limit { get; set; }

        public CheckingAccount(string name, double balance, int limit) : base(name, balance) {
            Limit = limit;
        }

        public override void withdraw(int amount) {
            if (getBalance() - amount >= -Limit) {
                base.withdraw(amount);
            }
        }
    }
}
