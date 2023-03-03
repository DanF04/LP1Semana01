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
            
        }
    }
}
