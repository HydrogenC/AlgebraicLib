using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgebraicLib;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Monomial b=new Monomial();
            b=new Monomial("-1234yv");
            Console.WriteLine(b.Operator);
            Console.WriteLine(b.Coefficient);
            foreach (var i in b.Letters)
            {
                Console.WriteLine(i);
            }
        }
    }
}
