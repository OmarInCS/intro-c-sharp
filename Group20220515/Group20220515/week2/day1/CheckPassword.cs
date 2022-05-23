using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20220515.week2.day1 {
    class CheckPassword {
        static void Main(string[] args) {
            Console.Write("Enter a new password: ");
            string password = Console.ReadLine();

            if (password.Length < 8) {
                Console.WriteLine("Not accepted");
            }
            else {
                int upperCount = 0;
                int digitCount = 0;
                for (int i = 0; i < password.Length; i++) {
                    char c = password[i];
                    if (char.IsUpper(c)) {
                        upperCount++;
                    }
                    else if (char.IsDigit(c)) {
                        digitCount++;
                    }
                }

                if (upperCount < 2 || digitCount < 2) {
                    Console.WriteLine("Not accepted");
                }
                else {
                    Console.WriteLine("new password set");
                }
            }
        }
    }
}
