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
            double xx = 1.23456;
            int ii = 19;

            string xx2 = $"xx = {xx:f2}";
            string xx3 = $"xx = {xx:p1}";
            string ii2 = $"ii = {ii:x}";
            string ii3 = $"ii = {ii:c}";

            //Printing the respective strings
            Console.WriteLine (notifier);
            Console.WriteLine (hidden);
            Console.WriteLine (ismoney);
            Console.WriteLine (evenmorestrings);
            Console.WriteLine (mathematics);
            Console.WriteLine (xx2);
            Console.WriteLine (xx3);
            Console.WriteLine (ii2);
            Console.WriteLine (ii3);
        }
    }
}
