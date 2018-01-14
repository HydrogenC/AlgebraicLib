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
            BigInteger gcd = GCD.GCD.GetGCD(numerator,denominator).GCD;
            numerator = numer / gcd;
            denominator = deno / gcd;
        }
        public Fraction(Fraction numer, Fraction deno)
        {
            BigInteger lcm = GCD.GCD.GetGCD(numer.Denominator, deno.Denominator).LCM;
            numerator = lcm / numer.Denominator;
        }
        public Fraction(Fraction numer, BigInteger deno)
        {

        }
        public Fraction(BigInteger numer, Fraction deno)
        {

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
    }
}
