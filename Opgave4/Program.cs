using System;
using System.Collections.Generic;
using System.Linq;

namespace Opgave4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reversing 'Hello'");
            Console.WriteLine(ReverseString("Hello"));

            Console.WriteLine("Is palindrome 'Hello'?");
            Console.WriteLine(IsPalindrome("Hello"));

            Console.WriteLine("Is palindrome 'Anna'?");
            Console.WriteLine(IsPalindrome("Anna"));

            Console.WriteLine("Missing elements of [4, 6, 8, 10]");
            var missing = MissingElements(new int[] { 4, 6, 8, 10 });
            foreach (var i in missing)
                Console.Write(i);
        }

        public static string ReverseString(string s)
        {
            var reversed = "";
            for (int i = s.Length - 1; i >= 0; i--)
                reversed += s[i];
            return reversed;
        }

        public static bool IsPalindrome(string s)
        {
            s = s.ToLower();
            return s == ReverseString(s);
        }

        public static IEnumerable<int> MissingElements(int[] arr)
        {
            var sorted = arr.OrderBy(x => x).Distinct().ToArray();
            var missing = new List<int>();
            var index = 0;
            for (int i = sorted[0]; i <= sorted[sorted.Length - 1]; i++)
            {
                if (i == sorted[index])
                    index++;
                else
                    missing.Add(i);
            }
            return missing;
        }
    }
}
