using System;
using System.Linq;

namespace LetterLoopsIII
{
    class Program
    {
        static void Main(string[] args)
            //INPUT = cwAt OUTPUT = C-Ww-Aaa-Tttt
        {
            var input = "cwAt";
            Console.WriteLine($"The original input was {input}");

            //string.Join() concatenates the results with a dash between each element
            //The Select extension method with 'c & i' as parameters returns an uppercase version of the character followed by a string of lowercase characters in the length of the index.
            var modifiedInput = string.Join("-", input.Select((c, i) => Char.ToUpper(c) + new string(Char.ToLower(c), i)));
            Console.WriteLine($"The modified input is: {modifiedInput}");

            Console.WriteLine("press any key to exit.");
            Console.ReadKey();
        }
    }
}
