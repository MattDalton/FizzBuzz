using FizzBuzzProject;

namespace FizzBuzzUnitTests
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void TestDivisibleBy3()
        {
            FizzBuzz FizzBuzz = new FizzBuzz();

            Assert.AreEqual("Fizz", FizzBuzz.GetOutput(3));
        }

        [TestMethod]
        public void TestDivisibleBy5()
        {
            FizzBuzz FizzBuzz = new FizzBuzz();

            Assert.AreEqual("Buzz", FizzBuzz.GetOutput(5));
        }

        [TestMethod]
        public void TestDivisibleBy3Or5()
        {
            FizzBuzz FizzBuzz = new FizzBuzz();

            Assert.AreEqual("FizzBuzz", FizzBuzz.GetOutput(15));
        }
    }
}