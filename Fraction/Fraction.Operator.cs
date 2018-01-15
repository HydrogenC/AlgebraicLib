using System;
using System.Numerics;

namespace Fraction{
    public paritial class Fraction{
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
        
        public static Boolean operator ==(Fraction a, Fraction b)
        {
            if(a.ToString==b.ToString){
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public static Boolean operator !=(Fraction a, Fraction b){
            if(a==b){
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
