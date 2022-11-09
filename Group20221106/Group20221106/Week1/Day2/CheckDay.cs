
Console.Write("Enter a day number: ");
int day = int.Parse(Console.ReadLine());

if (day >= 1 && day <= 5) {
    Console.WriteLine("Work-day");
}
else if (day == 6 || day == 7) {
    Console.WriteLine("Off-day");
}
else {
    Console.WriteLine("Invalid day number!!");
}
