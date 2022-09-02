
var path = "C:\\Users\\Mr Omar\\Desktop\\marks.txt";
var data = File.ReadAllLines(path);
var marks = data.Select(m => int.Parse(m)).ToArray();

var outPath = "C:\\Users\\Mr Omar\\Desktop\\report.txt";

using (var sw = new StreamWriter(outPath)) {

    int best = marks.Max();
    sw.WriteLine("The best mark: " + best);

    foreach (int m in marks) {
        if (m > best - 10) {
            sw.WriteLine(m + " => A");
        }
        else if (m > best - 20) {
            sw.WriteLine(m + " => B");
        }
        else if (m > best - 30) {
            sw.WriteLine(m + " => C");
        }
        else if (m > best - 40) {
            sw.WriteLine(m + " => D");
        }
        else {
            sw.WriteLine(m + " => F");
        }
    }
}