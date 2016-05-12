using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsSolution
{
    class Solution
    {
        static void Main(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            string s1 = Console.ReadLine();
            int n = Convert.ToInt16(s1);

            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                Console.WriteLine(BalanceParanthesis(s));
            }
        }

        public static string BalanceParanthesis(string s)
        {

            Stack stkPar = new Stack();
            string str = "";
            foreach (char c in s)
                {
                    if(c == '{' || c== '(' || c == '[')
                    {
                        stkPar.Push(c);
                    }

                    if(c == '}' && stkPar.Count != 0 )
                    {
                        str= stkPar.Pop().ToString();
                        if (str != "{")
                            return "FALSE";
                    }
                    else if (c == ')' && stkPar.Count != 0)
                    {
                        str = stkPar.Pop().ToString();
                        if (str != "(")
                            return "FALSE";
                    }
                    else if (c == ']' && stkPar.Count != 0)
                    {
                        str = stkPar.Pop().ToString();
                        if (str != "[")
                            return "FALSE";
                    }
                                       
                }

            if (stkPar.Count == 0)
                return "TRUE";
            else
                return "FALSE";
            
        }
    }
}
