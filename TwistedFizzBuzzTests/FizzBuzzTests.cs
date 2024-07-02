using Microsoft.VisualStudio.TestTools.UnitTesting;
using TwistedFizzBuzz;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TwistedFizzBuzzTests
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void TestGetFizzBuzzRange()
        {
            var result = FizzBuzz.GetFizzBuzzRange(1, 15);
            var expected = new List<string> { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" };
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestGetFizzBuzzNonSequential()
        {
            var result = FizzBuzz.GetFizzBuzzNonSequential(new List<int> { -5, 6, 300, 12, 15 });
            var expected = new List<string> { "Buzz", "Fizz", "FizzBuzz", "Fizz", "FizzBuzz" };
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestGetFizzBuzzValue()
        {
            Assert.AreEqual("Fizz", FizzBuzz.GetFizzBuzzValue(3, 3, 5, "Fizz", "Buzz"));
            Assert.AreEqual("Buzz", FizzBuzz.GetFizzBuzzValue(5, 3, 5, "Fizz", "Buzz"));
            Assert.AreEqual("FizzBuzz", FizzBuzz.GetFizzBuzzValue(15, 3, 5, "Fizz", "Buzz"));
            Assert.AreEqual("7", FizzBuzz.GetFizzBuzzValue(7, 3, 5, "Fizz", "Buzz"));
        }

        [TestMethod]
        public async Task TestGetFizzBuzzWithApiTokensAsync()
        {
            var result = await FizzBuzz.GetFizzBuzzWithApiTokensAsync(1, 15);
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count == 15);
        }
    }
}
