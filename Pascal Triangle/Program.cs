using System;

namespace Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = 0;
            var n = int.Parse(Console.ReadLine());
            var empty = n - 1;
            for (int i = 0; i <= n*2 - 1; i++)
            {
                if(i%2==0)
                {
                    continue;
                }

                num = 1;
                Console.Write(new string(' ', empty));
                empty--;

                for (int j = 0; j < i; j++)
                {
                    Console.Write(num);
                    if (j < (i - 1) / 2)
                    {
                        num++;
                    }
                    else
                    {
                        num--;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
