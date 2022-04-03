using System;
using System.Collections.Generic;

namespace Check_Prime_Constituants
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var primeNums = new List<int>();
            bool isPrime;
            for (int i = 2; i <= n; i++)
            {
                isPrime = true;

                for (int j = 2; j <= i; j++)
                {
                    if(i%j==0 && i != j)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if(isPrime)
                {
                    primeNums.Add(i);
                }
            }

            var len = primeNums.Count;

            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    if(i == j)
                    {
                        continue;
                    }

                    if(primeNums[i] + primeNums[j] == n)
                    {
                        Console.WriteLine($"{n} = {primeNums[i]} + {primeNums[j]}");
                        primeNums[i] = -1;
                        primeNums[j] = -1;
                    }
                }
            }
        }
    }
}
