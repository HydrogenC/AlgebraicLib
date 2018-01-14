using System;
using System.Collections.Generic;

namespace AlgebraicLib
{
    public class Monomial
    {
        private readonly List<Char> moLetters = new List<Char>();
        private Int64 moCoefficient;

        public Monomial()
        {
        }

        public Monomial(String monomial)
        {
            if (monomial.Length > 0)
            {
                moCoefficient = Functions.OutputNumbers(monomial, moLetters);
            }
            else
            {
                throw new Exception("Try to use Monomial()! ");
            }
        }

        public Monomial(Int64 coefficient, String letters)
        {
            moCoefficient = coefficient;
            foreach (Char i in letters)
            {
                moLetters.Add(i);
            }
        }

        public Monomial(Int64 coefficient, List<Char> letters)
        {
            moCoefficient = coefficient;
            moLetters = letters;
        }

        public Monomial(Int64 coefficient, Char[] letters)
        {
            moCoefficient = coefficient;
            moLetters = new List<Char>(letters);
        }

        public Int64 AbsCoefficient
        {
            get => Math.Abs(moCoefficient);
        }

        public Int64 Coefficient
        {
            get => moCoefficient;
            set => moCoefficient = value;
        }

        public Char Operator
        {
            get
            {
                if (moCoefficient < 0)
                {
                    return '-';
                }
                else
                {
                    return '+';
                }
            }
            set
            {
                switch (value)
                {
                    case '+':
                        moCoefficient = Math.Abs(moCoefficient);
                        break;
                    case '-':
                        moCoefficient = -Math.Abs(moCoefficient);
                        break;
                    default:
                        throw new Exception("Invaild operator! ");
                }
            }
        }

        public String Value
        {
            get
            {
                String m = moCoefficient.ToString();
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

        public Boolean ContainsLetter
        {
            get
            {
                if (moLetters.Count == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}