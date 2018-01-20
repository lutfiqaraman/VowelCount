using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "ababceerdt";
            int result = GetVowelCount(str);

            Console.WriteLine("Count of vowels = {0}", result);
            Console.ReadKey();
        }

        public static int GetVowelCount(string str)
        {
            int VowelCount = 0;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            foreach (char c in str)
            {
                if (vowels.Contains(c))
                    VowelCount += 1;
            }

            return VowelCount;
        }
    }
}
