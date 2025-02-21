using System;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //Variables for strings
            string notifier = "strings";
            string hidden = "He is \"hidden\" among us...";
            string ismoney = "this \u20AC is money";
            string evenmorestrings = "this" + "adds" + 4 + "more" + notifier;
            string x = "x" + "\u00B2";
            string mathematics =  $"x times x is equal to {x}";

            //Printing the respective strings
            Console.WriteLine (notifier);
            Console.WriteLine (hidden);
            Console.WriteLine (ismoney);
            Console.WriteLine (evenmorestrings);
            Console.WriteLine (mathematics);
        }
    }
}
