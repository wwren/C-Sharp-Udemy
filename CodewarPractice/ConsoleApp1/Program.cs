using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        private static string _happy;

        static void Main(string[] args)
        {
            int n = 100;
            int[] customer =  { 1, 2, 3, 4, 5 };

            int[] result = new int[n];

            int i = 0;
            
            foreach (var c in customer)
            {
                /*var i1 = result[i % n] <= result[(i + 1) % n] ? result[i % n] = result[i % n] + c : result[(i + 1) % n] = result[(i + 1) % n] + c;*/

                result[Array.IndexOf(result, result.Min())] += c;
                /*Console.WriteLine(i1);*/
                /*          if (result[i % n] <= result[(i + 1) % n])
                    result[i % n] += c;
                else
                    result[(i + 1) % n] += c;*/
                i++;
            }

            Console.WriteLine(result.Max());

        }
    }
}
