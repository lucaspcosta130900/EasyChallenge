using System;
using TwistedFizzBuzz;

namespace StandardFizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var results = FizzBuzz.GetFizzBuzzRange(1, 100);
            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }
    }
}
