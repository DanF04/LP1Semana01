using System;

namespace VariousTypes
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //Variables for whole numbers
            sbyte I = 111;
            short A = 4444;
            int B = 888888888;
            long S = 5555555555555555555;

            //Printing the respective variables
            Console.WriteLine (I);
            Console.WriteLine (A);
            Console.WriteLine (B);
            Console.WriteLine (S);

            //Variables for characters
            char heart = '\u10E6';
            char star = '\u2730';
            char comma = '\u275B';
            
            //Printing the respective characters
            Console.WriteLine (heart);
            Console.WriteLine (star);
            Console.WriteLine (comma);
        }
    }
}
