
//Console.Write("Enter a new password: ");
//string password = Console.ReadLine();

//if (password.Length < 8) {
//    Console.WriteLine("Weak Password");
//}
//else {
//    int upperCount = 0;
//    int digitCount = 0;

//    #region oldfor
//    //for (int i = 0; i < password.Length; i++) {
//    //    char c = password[i];
//    //    if (char.IsUpper(c)) {
//    //        upperCount++;
//    //    }
//    //    else if (char.IsDigit(c)) {
//    //        digitCount++;
//    //    }
//    //}
//    #endregion

//    foreach (char c in password) {
//        if (char.IsUpper(c)) {
//            upperCount++;
//        }
//        else if (char.IsDigit(c)) {
//            digitCount++;
//        }
//    }

//    if (upperCount < 2 || digitCount < 2) {
//        Console.WriteLine("Weak Password");
//    }
//    else {
//        Console.WriteLine("Strong Password");
//    }
//}