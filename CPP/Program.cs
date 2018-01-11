using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgebraicLib;

namespace CPP
{
    class Program
    {
        static void Main(string[] args)
        {
            Expression e = new Expression(Console.ReadLine());
            e.OutputElement();
            Console.WriteLine(e.Length);
            Console.ReadKey();
        }
    }
}
