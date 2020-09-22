using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Reflection;
using LibTestCM1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
List<string> videogames = new List<string>
{
    "Starcraft",
    "Halo",
    "Legend of Zelda"
};

string json = JsonConvert.SerializeObject(videogames);

Console.WriteLine(json);

            var newton = Assembly.GetAssembly(typeof(JsonConvert));
            //var vers = newton.ImageRuntimeVersion;
            Console.WriteLine($"Newton In Project {newton.FullName}");


            var c = new LibTestCM1.Class1();
           

            Console.WriteLine($"Newton in package {c.test()}");

        }
    }
}
