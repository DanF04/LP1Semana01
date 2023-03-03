using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "|\u266a\t|\u250b\t|\u263c\t|\n|u266a\t|u250b\t|u263c\t|";
            string s2 = @"|\u266a\t|\u250b\t|\u263c\t|\n|u266a\t|u250b\t|u263c\t|";
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
