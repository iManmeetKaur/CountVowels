using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountVowels
{
    public class Program
    {
        static void Main(string[] args)
        {
            String word = "Extraordinary";
            Console.WriteLine(countVowels(word));
        }
        public static int countVowels(String str)
        {
            String word = str.ToLower();
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u')
                {
                    count++;
                }
            }
            return count;

        }
    }
}
