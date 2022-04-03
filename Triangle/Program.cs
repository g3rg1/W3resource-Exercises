using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());
            var res = Math.Max(n, k);
            for (int i = 0; i < n; i++)
            {
                for (int j = k; j > i; j--)
                {
                    Console.Write(res);
                }
                Console.WriteLine();
            }
        }
    }
}
