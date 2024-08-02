using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Classes
{
    internal class Conditionfunc
    {
        public static bool CheckOdd(int num) { return num % 2 != 0; }
        public static bool CheckEven(int num) { return num % 2 == 0; }
        public static bool CheckLength(string names) { return names?.Length > 4; }

        public static bool Test(int num) { return num>0; }

        public static string cast(int num) { return num.ToString(); }
        public static void print() { Console.WriteLine("Hellow"); }
        public static void printName(string name) { Console.WriteLine( $"Hellow {name} ."); }
    }
}
