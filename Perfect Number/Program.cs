using System;
using System.Collections.Generic;

namespace Perfect_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var divisors = new List<int>();
            for (int i = 1; i < n; i++)
            {
                if(n%i==0)
                {
                    divisors.Add(i);
                }
            }
            var sum = 0;

            foreach (var num in divisors)
            {
                sum += num;
            }

            if(sum == n)
            {
                Console.WriteLine("Num is perfect.");
            }
            else
            {
                Console.WriteLine("Num is not perfect.");
            }
        }
    }
}
