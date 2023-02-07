
//Console.Write("Enter number of students: ");
//int n = int.Parse(Console.ReadLine());

//double[] marks = new double[n];

//Console.Write("Enter the marks file path: ");
//var path = Console.ReadLine();
//var sr = new StreamReader(path);

//for (int i = 0; i < n; i++) {
//    marks[i] = double.Parse(sr.ReadLine());
//}
//sr.Close();

//var sw = new StreamWriter(path, true);

//double best = marks.Max();
//sw.WriteLine("The best mark: " + best);


//foreach (double m in marks) {
//    if (m >= best - 10) {
//        sw.WriteLine($"{m} => A");
//    }
//    else if (m >= best - 20) {
//        sw.WriteLine($"{m} => B");
//    }
//    else if (m >= best - 30) {
//        sw.WriteLine($"{m} => C");
//    }
//    else if (m >= best - 40) {
//        sw.WriteLine($"{m} => D");
//    }
//    else {
//        sw.WriteLine($"{m} => F");
//    }

//}

//sw.Close();
//Console.WriteLine("done");
