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

            //Variable that adds the two inputs together
            float AddInputs = number + realnumber;
            

            Console.WriteLine ("Write a whole number:"+ ask);
            Console.WriteLine ("Write a real number:"+ askreal);
            Console.WriteLine ($"{number} + {realnumber} = {AddInputs}");




        }
    }
}
