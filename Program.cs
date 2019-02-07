using System;

namespace Anagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string a = "fcrxzwscanmligyxyvym";
            string b = "jxwtrhvujlmrpdoqbisbwhmgpmeoke";

            // Loop through each char in a and each char in b.
            // If there is a match, remove that char in both strings.
            // Print the sum of the remaining chars in a and b to get
            // the minimum number of deletions.
            foreach (var itemA in a)
            {
                foreach (var itemB in b)
                {
                    if (itemA == itemB)
                    {
                        a = a.Remove(a.IndexOf(itemA), 1);
                        b = b.Remove(b.IndexOf(itemB), 1);
                        break;
                    }
                }
            }

            Console.WriteLine("Must delete {0} chars.", a.Length + b.Length);
        }
    }
}
