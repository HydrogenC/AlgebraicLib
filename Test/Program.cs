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
            Monomial b=new Monomial("12e");
            Console.WriteLine(b.Operator+", "+b.Coefficient);
        }
    }
}
