using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Lab6
{
    class Program
    {
        private const string Pattern = @"\b[\w]+\b";
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите строку");

                var input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))
                {
                    var matches = Regex.Matches(input, Pattern, RegexOptions.Compiled);
                    var lastMatch = matches.Cast<Match>().Last();
                    input = input.Remove(lastMatch.Index, lastMatch.Length);
                    input = input.Remove(0, input.IndexOf(' ') + 1);

                    Console.WriteLine(input);
                }
            }
        }
    }
}
