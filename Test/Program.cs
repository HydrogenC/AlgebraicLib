using System;
using AlgebraicLib;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Pylonomial b=new Pylonomial("6c+3e");
            foreach (var i in b.Monomials)
            {
                Console.WriteLine(i.Value);
            }
            Console.ReadKey();
        }
    }
}
