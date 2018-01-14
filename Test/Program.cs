using System;
using AlgebraicLib;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Monomial b=new Monomial();
            b=new Monomial("-1234");
            Console.WriteLine(b.Operator);
            Console.WriteLine(b.Coefficient);
            foreach (var i in b.Letters)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
