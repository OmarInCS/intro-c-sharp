using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20211224.day6 {
    class DictBasics {
        //static void Main(string[] args) {
        //    var countries = new Dictionary<string, string>();
        //    countries.Add("sa", "Saudi Arabia");
        //    countries.Add("ae", "Arab Emirates");
        //    countries.Add("eg", "Egypt");

        //    WriteDict(countries);

        //    Console.WriteLine(countries["ae"]);
        //    countries["eg"] = "Republic of Egypt";

        //    WriteDict(countries);

        //    Console.WriteLine(countries.ContainsKey("ae"));
        //    Console.WriteLine(countries.ContainsValue("Arab Emirates"));
        //    Console.WriteLine(countries.Count);

        //    countries.Remove("ae");
        //    WriteDict(countries);
        //}

        static void WriteDict(Dictionary<string, string> dict) {
            Console.WriteLine("[ ");
            foreach (var item in dict) {
                Console.WriteLine("\t" + item.Key + ": " + item.Value);
            }
            Console.WriteLine("]");
        }
    }
}
