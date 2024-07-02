using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TwistedFizzBuzz
{
    public class FizzBuzz
    {
        public static List<string> GetFizzBuzzRange(int start, int end, int fizzDivisor = 3, int buzzDivisor = 5, string fizzToken = "Fizz", string buzzToken = "Buzz")
        {
            var result = new List<string>();
            for (int i = start; i <= end; i++)
            {
                result.Add(GetFizzBuzzValue(i, fizzDivisor, buzzDivisor, fizzToken, buzzToken));
            }
            return result;
        }

        public static List<string> GetFizzBuzzNonSequential(List<int> numbers, int fizzDivisor = 3, int buzzDivisor = 5, string fizzToken = "Fizz", string buzzToken = "Buzz")
        {
            var result = new List<string>();
            foreach (var number in numbers)
            {
                result.Add(GetFizzBuzzValue(number, fizzDivisor, buzzDivisor, fizzToken, buzzToken));
            }
            return result;
        }

        public static string GetFizzBuzzValue(int number, int fizzDivisor, int buzzDivisor, string fizzToken, string buzzToken)
        {
            string output = "";
            if (number % fizzDivisor == 0) output += fizzToken;
            if (number % buzzDivisor == 0) output += buzzToken;
            return string.IsNullOrEmpty(output) ? number.ToString() : output;
        }

        public static async Task<List<string>> GetFizzBuzzWithApiTokensAsync(int start, int end)
        {
            var tokens = await GetApiTokensAsync();
            var result = new List<string>();

            for (int i = start; i <= end; i++)
            {
                string output = "";
                foreach (var token in tokens)
                {
                    if (i % token.Divisor == 0)
                    {
                        output += token.Token;
                    }
                }
                result.Add(string.IsNullOrEmpty(output) ? i.ToString() : output);
            }

            return result;
        }

        private static async Task<List<ApiResponse>> GetApiTokensAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetStringAsync("https://rich-red-cocoon-veil.cyclic.app/");
                return JsonConvert.DeserializeObject<List<ApiResponse>>(response);
            }
        }
    }
}
