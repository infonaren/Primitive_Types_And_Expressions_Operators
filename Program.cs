using System;


namespace Primitive_Types_And_Expressions_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 3;

            var c = 1;
            var d = 2;
            var e = 3;

            Console.WriteLine("Addition: " + (a + b));
            Console.WriteLine("Division: " + (a / b));
            Console.WriteLine("Float Division: " + ((float)(a) / (float)(b)));

            Console.WriteLine(c + d * e);
            Console.WriteLine((c + d) * e);
            Console.WriteLine(c > d);
            Console.WriteLine(c == d);
            Console.WriteLine(c != d);
            Console.WriteLine(!(c != d));
            Console.WriteLine(e > c && e > d);
            Console.WriteLine(e > c && e == d);
            Console.WriteLine(e > c || e == d);
            Console.WriteLine(! (e > c || e == d));

            byte number = 255;
            number += 2;

            Console.WriteLine(number);

            int i = 1;
            int j = i++;

            Console.WriteLine("Postfix increment: {0} {1}" ,(i),(j));

            int k = 1;
            int l = ++k;

            Console.WriteLine("Prefix increment: {0} {1}", (k), (l));

            /*

             byte number = 1000;
             Console.WriteLine(number);

               int number1 = 257;
               byte number2 = number1;
               Console.WriteLine(number2);

            */

        }
    }
}
