using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace AlgebraicLib
{
    public class Monomial
    {
        private Char moOperator;
        private readonly List<Char> moLetters=new List<Char>();
        private Int64 moCoefficient;

        public Monomial()
        {
            
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
                return;
            }
            if (monomial.StartsWith("+") || monomial.StartsWith("-"))
            {
                throw new Exception("Try to use Monomial(String: monomial)! ");
                return;
            }
            moCoefficient=Functions.OutputNumbers(monomial, moLetters);
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
                moCoefficient=Functions.OutputNumbers(monomial, moLetters);
            }
            else
            {
                throw new Exception("Try to use Monomial()! ");
                return;
            }
        }
        
        public Monomial(Int64 coefficient, String letters)
        {
            if (coefficient < 0)
            {
                moOperator = '-';
                moCoefficient = -coefficient;
            }
            else
            {
                moOperator = '+';
                moCoefficient = coefficient;
            }

            foreach (Char i in letters)
            {
                moLetters.Add(i);
            }
        }

        public Monomial(Char monoOperator, Int64 coefficient, String letters)
        {
            if (monoOperator.Equals('+') || monoOperator.Equals('-'))
            {
                moOperator = monoOperator;
            }
            else
            {
                throw new Exception("Invaild operator! ");
                return;
            }

            moCoefficient = coefficient;
            foreach (Char i in letters)
            {
                moLetters.Add(i);
            }
        }
        
        public Monomial(Char monoOperator, Int64 coefficient, List<Char> letters)
        {
            if (monoOperator.Equals('+') || monoOperator.Equals('-'))
            {
                moOperator = monoOperator;
            }
            else
            {
                throw new Exception("Invaild operator! ");
                return;
            }

            moCoefficient = coefficient;
            moLetters = letters;
        }
        
        public Monomial(Char monoOperator, Int64 coefficient, Char[] letters)
        {
            if (monoOperator.Equals('+') || monoOperator.Equals('-'))
            {
                moOperator = monoOperator;
            }
            else
            {
                throw new Exception("Invaild operator! ");
                return;
            }

            moCoefficient = coefficient;
            moLetters = new List<Char>(letters);
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

        public String Value { 
            get
            {
                String m = moOperator.ToString() + moCoefficient.ToString();
                foreach (var i in moLetters)
                {
                    m += i.ToString();
                }

                return m;
            }
        }

        public List<Char> Letters
        {
            get => moLetters;
        }
    }
}