using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using GCD;

namespace Fraction
{
    public partial class Fraction
    {
        private BigInteger denominator;
        //The sign symbol is only stored in Numerator
        private BigInteger numerator;
        public Fraction()
        {

        }
        public Fraction(BigInteger numer, BigInteger deno)
        {
            if (deno == 0)
            {
                throw new DivideByZeroException();
            }
            if (deno < 0)
            {
                numer = -numer;
                deno = -deno;
            }
            Reduct();
        }
        public Fraction(Fraction numer, Fraction deno)
        {
            //BigInteger lcm = GCD.GCD.GetGCD(numer.Denominator, deno.Denominator).LCM;
            //numerator = lcm / numer.Denominator;
            Reduct();
        }
        public Fraction(Fraction numer, BigInteger deno)
        {
            Reduct();
        }
        public Fraction(BigInteger numer, Fraction deno)
        {
            Reduct();
        }

        public Fraction(String frac)
        {
            for(Int64 i = 0; i < frac.Length;i+=1)
            {
                if (frac[(Int16)i] == '/')
                {
                    numerator = BigInteger.Parse(frac.Substring(0, (Int16)i));
                    denominator = BigInteger.Parse(frac.Substring((Int16)i + 1));
                    if (denominator == 0)
                    {
                        throw new DivideByZeroException();
                    }
                    break;
                }
            }
            Reduct();
        }

        public override String ToString()
        {
            return numerator + "/" + denominator;
        }

        public Decimal ToDecimal()
        {
            return (Decimal)numerator / (Decimal)denominator;
        }

        public BigInteger Numerator {
            get => numerator;
            set => numerator = value;
        }
        public BigInteger Denominator {
            get => denominator;
            set => denominator = value;
        }

        public void Reduct()
        {
            Tuple<BigInteger, BigInteger> temp = Reduction(numerator, denominator);
            numerator = temp.Item1;
            denominator = temp.Item2;
        }
    }
}
