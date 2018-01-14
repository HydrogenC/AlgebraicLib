using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    partial class Fraction
    {
        public Fraction Reciprocal()
        {
            return new Fraction(denominator, numerator);
        }

        public Fraction Sqrt()
        {
            Double a = Double.Parse(numerator.ToString());
            Double b = Double.Parse(denominator.ToString());
            a = Math.Floor(Math.Sqrt(a));
            b = Math.Floor(Math.Sqrt(b));
            return new Fraction(BigInteger.Parse(a.ToString()), BigInteger.Parse(b.ToString()));
        }

        public Fraction Pow(Decimal times)
        {
            Double a = Double.Parse(numerator.ToString());
            Double b = Double.Parse(denominator.ToString());
            a = Math.Floor(Math.Pow(a, (Double)times));
            b = Math.Floor(Math.Pow(b, (Double)times));
            return new Fraction(BigInteger.Parse(a.ToString()), BigInteger.Parse(b.ToString()));
        }

        public static Tuple<BigInteger, BigInteger> Reduction(BigInteger numerator,BigInteger denominator)
        {
            BigInteger gcd = GCD.GCD.GetGCD(numerator, denominator).GCD;
            numerator = numerator / gcd;
            denominator = denominator / gcd;
            return new Tuple<BigInteger, BigInteger>(numerator,denominator);
        }

        public static Fraction operator *(Fraction a, Fraction b)
        {
            return new Fraction(a.Numerator * b.Numerator, a.Denominator * b.Denominator);
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            BigInteger lcm = GCD.GCD.GetGCD(a.Denominator, b.Denominator).LCM;
            return new Fraction(a.Numerator * (lcm / a.Denominator) + b.Numerator * (lcm / b.Denominator), lcm);
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            BigInteger lcm = GCD.GCD.GetGCD(a.Denominator, b.Denominator).LCM;
            return new Fraction(a.Numerator * (lcm / a.Denominator) - b.Numerator * (lcm / b.Denominator), lcm);
        }

        public static Fraction operator /(Fraction a, Fraction b)
        {
            return a * b.Reciprocal();
        }

        public static Fraction operator ^(Fraction a, Decimal b)
        {
            return a.Pow(b);
        }
    }
}
