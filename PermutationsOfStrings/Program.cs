using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermutationsOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> output = Permute("abc");

            foreach (string str in output)
            {
                Console.WriteLine(str);
            }
        }

        static List<string> Permute(string input)
        {
            if (input.Length == 1)
            {
                List<string> result = new List<string> { input };
                return result;
            }

            char last = input[input.Length - 1];

            string rest = input.Substring(0, input.Length - 1);

            List<string> subset = Permute(rest);

            List<string> fullResult = new List<string>();

            foreach (string str in subset)
            {
                for (int i = 0; i <= str.Length; i++)
                {
                    StringBuilder sb = new StringBuilder(str);
                    sb.Insert(i, last);
                    fullResult.Add(sb.ToString());
                }
            }

            return fullResult;
        }
    }
}
