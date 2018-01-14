using System;
using System.Collections.Generic;

namespace AlgebraicLib
{
    public class Pylonomial
    {
        private List<Monomial> moList=new List<Monomial>();

        public Pylonomial()
        {
            
        }

        public Pylonomial(String pylonomial)
        {
            if (!(pylonomial.StartsWith("+") || pylonomial.StartsWith("-")))
            {
                pylonomial = "+" + pylonomial;
            }
            List<String> temp=new List<String>();
            Int64 previousOperator = 0;
            for (Int64 i = 1; i < pylonomial.Length; i += 1)
            {
                if (pylonomial[(Int16) i].Equals('+')||pylonomial[(Int16) i].Equals('-'))
                {
                    if (i - previousOperator >= 2)
                    {
                        
                    }
                    temp.Add(pylonomial.Substring((Int16) previousOperator, (Int16) i - (Int16) previousOperator));
                }
            }
        }
    }
}