using System;
using System.Collections.Generic;

namespace AlgebraicLib
{
    public class Functions
    {
        public static Int64 OutputNumbers(String input, List<Char> output)
        {
            String list = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            String temp = input;
            foreach (Char i in list)
            {
                if (temp.Contains(i.ToString()))
                {
                    output.Add(i);
                    temp=temp.Replace(i.ToString(), "");
                }
            }

            return Int64.Parse(temp);
        }
    }
}
