using System;

namespace AskForInput
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //Variables to ask for input from the user
            string ask = Console.ReadLine();
            string askreal = Console.ReadLine();

            //Variable that converts the user input into a whole number
            int number = int.Parse(ask);

            //Variable that converts the user input into a real number
            float realnumber = float.Parse(askreal);


        }
    }
}
