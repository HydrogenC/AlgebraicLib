using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace AlgebraicLib
{
    public class Monomial
    {
        private String moValue="";
        private Char moOperator;
        private readonly List<Char> moLetters=new List<Char>();
        private Int64 moCoefficient;

        public Monomial()
        {
            moValue = "";
        }

        public Monomial(Char monoOperator, String monomial)
        {
            if (monoOperator.Equals('-') || monoOperator.Equals('+'))
            {
                moOperator = monoOperator;
            }
            else
            {
                throw new Exception("Invaild operator");
            }

            if (monomial.StartsWith("+") || monomial.StartsWith("-"))
            {
                throw new Exception("Try to use Monomial(String: monomial)! ");
            }
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

                moValue = monomial;
                monomial=Functions.OutputNumbers(monomial, moLetters);
                Int64.TryParse(monomial, out moCoefficient);
            }
            else
            {
                throw new Exception("Try to use Monomial()! ");
            }
        }

        public Int64 Coefficient
        {
            get => moCoefficient;
            set => moCoefficient = value;
        }

        public Char Operator
        {
            get => moOperator;
            set
            {
                if (value.Equals('+')||value.Equals('-'))
                {
                    moOperator = value;
                }
                else
                {
                    throw new Exception("Invaild operator! ");
                }
            }
        }
    }
}