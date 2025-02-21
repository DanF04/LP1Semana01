using System;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //Variables for strings
            string notifier = "Hello LP1";
            string hidden = "He is \"hidden\" among us...";
            string ismoney = "this \u20AC is money";

            //Printing the respective strings
            Console.WriteLine (notifier);
            Console.WriteLine (hidden);
            Console.WriteLine (ismoney);
        }
    }
}
