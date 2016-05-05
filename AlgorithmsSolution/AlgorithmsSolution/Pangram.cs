using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsSolution
{
        class Pangram
        {
            static void Main(string[] args)
            {
                string inputStr = Console.ReadLine();
                SortedDictionary<char, int> letterDict = new SortedDictionary<char, int>();

                inputStr = inputStr.Replace(" ", "");

                if (inputStr.Length < 26)
                {
                    Console.WriteLine("not pangram");

                }

                foreach (char c in inputStr.ToLower())
                {
                    if (letterDict.ContainsKey(c))
                    {
                        letterDict[c]++;
                    }
                    else
                    {
                        letterDict.Add(c, 1);
                    }
                }

                if (letterDict.Count == 26)
                {
                    Console.WriteLine("pangram");
                }
                else
                {
                    Console.WriteLine("not a pangram");
                }
            }
        }
    }
