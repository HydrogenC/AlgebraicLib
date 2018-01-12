using System;
using System.Collections.Generic;

namespace AlgebraicLib
{
    public class Functions
    {
        public static String OutputNumbers(String input, List<Char> output)
        {
            String list = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            foreach (var i in list)
            {
                if (input.Contains(i.ToString()))
                {
                    output.Add(i);
                    input.Replace(i.ToString(), "");
                }
            }

            return input;
        }
    }
}
