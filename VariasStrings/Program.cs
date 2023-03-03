using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            double xx = 0.12345;
            int ii = 18;

            string sxx = $"xx={xx:f2}";
            string sxx2 = $"xx={xx:p1}";
            string sii = $"ii={ii:x}";
            string sii2 = $"ii={ii:c}";

            Console.WriteLine(sxx);      
            Console.WriteLine(sxx2);
            Console.WriteLine(sii); 
            Console.WriteLine(sii2);    

            string s1 = "|\u266a\t|\u250b\t|\u263c\t|\n|u266a\t|u250b\t|u263c\t|";
            string s2 = @"|\u266a\t|\u250b\t|\u263c\t|\n|u266a\t|u250b\t|u263c\t|";
            Console.WriteLine(s1);
            Console.WriteLine(s2);



            int x = 3;
            int y = 5;
            string s3 = "Tac" + "o" + "caT";
            string s4 = "Um" + "+" + "um" + "=" + "dois";
            string s5 = $"{x} vezes {y} e' {x*y}";
            string s6 = $"{x*y} e' {x} vezes {y}";
            string s7 = String.Format("x e' {3}, y e' {5}",0,1,2,3,4,5);
            Console.WriteLine("Valor de x vezes y e' {0}", x*y );
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);
        }
    }
}
