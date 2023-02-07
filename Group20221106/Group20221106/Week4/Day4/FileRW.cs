

var path1 = "C:\\Users\\Mr Omar\\Desktop\\words.txt";
//var content = File.ReadAllText(path1);
var content = File.ReadAllLines(path1);

Console.WriteLine(content[0]);
Console.WriteLine(content.Length);

var sr = new StreamReader(path1);
var line = sr.ReadLine();
Console.WriteLine(line);
line = sr.ReadLine();
Console.WriteLine(line);
while (line != null) {
    line = sr.ReadLine();
    Console.WriteLine(line);
}
sr.Close();

//----------------------------------

var path2 = "C:\\Users\\Mr Omar\\Desktop\\data.txt";
var names = new string[] { "Ahmed", "Wael", "Ali", "Yasser" };

File.WriteAllText(path2, "This is students names: \n");
//File.WriteAllLines(path2, names);

var sw = new StreamWriter(path2, true);
foreach (var name in names) {
    sw.WriteLine(name);
}
sw.Close();
