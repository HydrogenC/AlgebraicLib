using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MathFunctions
{
    public class Get_GCD_LCM
    {
        public struct Result
        {
            public BigInteger GCD;
            public BigInteger LCM;
        }

        public static Result GetGCDLCM(BigInteger a, BigInteger b)
        {
            BigInteger min = a < b ? a : b;
            BigInteger max = a > b ? a : b;
            Result result = new Result();
            for (BigInteger i = 1; ; i += 1)
            {
                if ((max * i) % min == 0)
                {
                    result.LCM = max * i;
                    break;
                }
            }
            result.GCD = a / (result.LCM / b);
            return result;
        }

        public static BigInteger GetLCM(BigInteger a, BigInteger b,Boolean gcd)
        {
            BigInteger min = a < b ? a : b;
            BigInteger max = a > b ? a : b;
            Result result = new Result();
            for (BigInteger i = 1; ; i += 1)
            {
                if ((max * i) % min == 0)
                {
                    result.LCM = max * i;
                    break;
                }
            }
            result.GCD = a / (result.LCM / b);
            if (gcd)
            {
                return result.GCD;
            }
            else
            {
                return result.LCM;
            }
        }
    }
}
