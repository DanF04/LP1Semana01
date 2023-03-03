using System;

namespace TiposVarios
{
    class Program
    {
    
        static void Main(string[] args)
        {
            sbyte x1 = 127;
            short x2 = 32767;
            byte x3 = 255;
            Console.WriteLine("x1 = "+ x1.ToString());
            Console.WriteLine("x2 = "+ x2.ToString());
            Console.WriteLine("x3 = "+ x3.ToString());


            char y1 = '\u270d';
            char y2 = '\u240e';
            char y3 = '\u270f';
            Console.WriteLine("y1 = "+ y1);
            Console.WriteLine("y2 = "+ y2);
            Console.WriteLine("y3 = "+ y3);

            float z1 = (float)Math.PI;
            double z2 = Math.PI;
            decimal z3 = (decimal)Math.PI;
            Console.WriteLine("z1 = "+ z1.ToString());
            Console.WriteLine("z2 = "+ z2.ToString());
            Console.WriteLine("z3 = "+ z3.ToString());

            bool w1 = false;
            bool w2 = !w1;
            Console.WriteLine("w1 = "+ w1.ToString());
            Console.WriteLine("w2 = "+ w2.ToString());

            
            
        }
    }
}
