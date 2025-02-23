﻿using System;

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

            //Printing the respective whole numbers
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

            //Variables for real numbers
            float PieOfNumbers = 3.1415f;
            double DoubleReal = 1.23456;

            //Printing the respective real numbers
            Console.WriteLine (PieOfNumbers);
            Console.WriteLine (DoubleReal);

            //Variables for booleans
            bool mightbe = true;
            bool mightnotbe = false;

            //Printing the respective booleans
            Console.WriteLine (mightbe);
            Console.WriteLine (mightnotbe);
        }
    }
}
