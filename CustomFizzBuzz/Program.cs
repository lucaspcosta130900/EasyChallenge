using System;
using TwistedFizzBuzz;

namespace CustomFizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = -20;
            int end = 127;
            int fizzDivisor = 5;
            int buzzDivisor = 9;
            int barDivisor = 27;
            string fizzToken = "Fizz";
            string buzzToken = "Buzz";
            string barToken = "Bar";

            for (int i = start; i <= end; i++)
            {
                string output = FizzBuzz.GetFizzBuzzValue(i, fizzDivisor, buzzDivisor, fizzToken, buzzToken);
                if (i % barDivisor == 0) output += barToken;
                if (string.IsNullOrEmpty(output)) output = i.ToString();
                Console.WriteLine(output);
            }
        }
    }
}
