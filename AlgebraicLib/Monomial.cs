using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace AlgebraicLib
{
    public class Monomial
    {
        private String moValue="";
        public Char moOperator;
        private List<Char> moLetters=new List<Char>();
        public Int64 moCoefficient;

        public Monomial()
        {
            moValue = "";
        }

        public Monomial(String monomial)
        {
            if (monomial.Length > 0)
            {
                if (monomial.StartsWith("+"))
                {
                    moOperator = '+';
                    monomial = monomial.Substring(1);
                }
                else if(monomial.StartsWith("-"))
                {
                    moOperator = '-';
                    monomial = monomial.Substring(1);
                }
                else
                {
                    moOperator = '+';
                }
                monomial=Functions.OutputNumbers(monomial, moLetters);
                Int64.TryParse(monomial, out moCoefficient);
            }
            else
            {
                throw new Exception("Empty monomial! ");
            }
        }
    }
}