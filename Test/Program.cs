using System;
using AlgebraicLib;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Pylonomial b=new Pylonomial("-6.5c+3e");
            Int64 rnd = b.Round();
            foreach (var i in b.Monomials)
            {
                Console.WriteLine(i.Value);
            }
            Console.WriteLine(rnd);
            Console.ReadKey();
        }
    }
}
