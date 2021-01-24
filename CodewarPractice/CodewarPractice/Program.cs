using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodewarPractice
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class ProdFib
    {
        public static ulong[] productFib(ulong prod)
        {

            UInt64 max = (UInt64)Math.Ceiling(Math.Sqrt(prod));
            List<UInt64> fib = new List<UInt64>();

            //init Fib sequence
            fib.Add(1);
            fib.Add(1);
            int i = 2;
            while (fib[i - 1].CompareTo(max) < 0)
            {
                fib.Add(fib[i - 1] + fib[i - 2]);
                i++;
            }

            fib.ForEach(f => Console.WriteLine(f));

            int j = 0;
            UInt64 result = 0;
            while (result.CompareTo(prod) <= 0)
            {
                result = fib[j] * fib[j + 1];
                Console.WriteLine(result);

                if (result.CompareTo(prod) == 0)
                {
                    return new ulong[3] { fib[j], fib[j + 1], 1 };
                }
                j++;
            }
            return new ulong[3] { fib[j - 1], fib[j], 0 };

        }
    }
}
