using System;

namespace Sum_Of_500_Prime_Nums
{
    class Program
    {
        static void Main(string[] args)
        {
            var primeCount = int.Parse(Console.ReadLine());
            var arr = new ulong[primeCount];
            var arrIndex = 0;
            bool isPrime;

            for (ulong i = 2; ; i++)
            {
                isPrime = true;
                ulong num = i;

                for (ulong j = 2; j <= i; j++)
                {
                    if (num % j == 0 && num != j)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    arr[arrIndex] = num;
                    arrIndex++;
                    primeCount--;
                }
                if (primeCount == 0)
                {
                    break;
                }
            }

            ulong sum = 0;
            Console.WriteLine(string.Join(" ", arr));
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine(sum);
        }
    }
}
