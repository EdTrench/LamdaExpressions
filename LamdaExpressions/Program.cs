using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LamdaExpressions
{
    class Program
    {
        delegate int Multiply(int x, int y);

        static void Main(string[] args)
        {
            //named method
            Console.WriteLine("//named method");
            Multiply multiplyxy;
            multiplyxy = new Multiply(MultiplyNamed);
            Console.WriteLine(multiplyxy(5, 20));

            //anonymous
            Console.WriteLine("//anonymous method");
            Multiply multiply;
            multiply = delegate(int x, int y)
                { return (x * y); };
            Console.WriteLine(multiply(5, 20));

            //lambda
            Console.WriteLine("//lambda expression");
            Func<int, int, string> func = (x, y) => (x * y).ToString();
            Console.WriteLine(func(5, 20));
            
            Console.ReadKey();
        }

        static int MultiplyNamed(int x, int y)
        {
            return x * y;
        }
    }
}
