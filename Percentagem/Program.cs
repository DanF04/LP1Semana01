using System;

namespace Percentagem
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //Variables to ask for input from the user
            Console.WriteLine ("Write 4 real number between 0 and 1:");
            string n1 = Console.ReadLine();
            string n2 = Console.ReadLine();
            string n3 = Console.ReadLine();
            string n4 = Console.ReadLine();

            //Variables that convert the user input into a real number
            float number1 = float.Parse(n1);
            float number2 = float.Parse(n2);
            float number3 = float.Parse(n3);
            float number4 = float.Parse(n4);

            //Printing the respective numbers has percentages
            Console.WriteLine($"{number1,10:p2}");
            Console.WriteLine($"{number2,10:p2}");
            Console.WriteLine($"{number3,10:p2}");
            Console.WriteLine($"{number4,10:p2}");
        

            


        }
    }
}
