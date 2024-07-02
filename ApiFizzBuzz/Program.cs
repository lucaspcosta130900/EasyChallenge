using System;
using System.Threading.Tasks;
using TwistedFizzBuzz;

namespace ApiFizzBuzz
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var results = await FizzBuzz.GetFizzBuzzWithApiTokensAsync(1, 100);
            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }
    }
}
