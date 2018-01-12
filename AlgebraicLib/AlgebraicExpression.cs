using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgebraicLib
{
    public class AlgebraicExpression
    {
        /*
        public String Value;
        public List<String> Items = new List<String>();
        public AlgebraicExpression(String theExpression)
        {
            Value = theExpression;
            String Temp = Value.Substring(0, 1);
            if ((Temp != "+") && (Temp != "-"))
            {
                Value = "+" + Value;
            }
            String Instructor = Value;
            Int32 FirstChar, SecondChar;
            for (Int32 indx = 0; ; indx += 1)
            {
                if (Instructor == "")
                {
                    break;
                }
                FirstChar = -1;
                SecondChar = -1;
                for (Int32 index = 0; index < Instructor.Length; index += 1)
                {
                    char tmp = Instructor[index];
                    if ((tmp == '+') || (tmp == '-'))
                    {
                        FirstChar = index;
                        for (Int32 Index = (index + 1); Index < Instructor.Length; Index += 1)
                        {
                            tmp = Instructor[Index];
                            if ((tmp == '+') || (tmp == '-'))
                            {
                                SecondChar = Index;
                                break;
                            }
                        }
                        break;
                    }
                }
                if (SecondChar > 0 && FirstChar >= 0)
                {
                    Items.Add(Instructor.Substring(FirstChar, (SecondChar - FirstChar)));
                    Instructor = Instructor.Replace(Items[indx], "");
                }
                else if (FirstChar >= 0 && SecondChar < 0)
                {
                    Items.Add(Instructor);
                    Instructor = "";
                }
                else
                {
                    Console.WriteLine("Nothing");
                }
            }
        }
        */
        
        
        public Int64 Length => 0;
    }
}
