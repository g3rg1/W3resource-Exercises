using System;
using System.Text;

namespace Remove_Non_Letter_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var len = input.Length;
            var sb = new StringBuilder();
            for (int i = 0; i < len; i++)
            {
                if(!char.IsLetter(input[i]))
                {
                    continue;
                }
                sb.Append(input[i]);
            }
            var result = sb.ToString();
            Console.WriteLine(result);
        }
    }
}
