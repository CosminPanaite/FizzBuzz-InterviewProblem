using DocumentFormat.OpenXml.Drawing.Charts;
using NUnit.Framework;

namespace FizzBuzz.Library.Test
{
    [TestFixture]
    public class FizzBuzzTest
    {
        [Test]
        public void Function_Returns_NumberValue([Values(1,2,4,7,8,11,13,14,19,22,23,26,28,29,31,32,34,37,41,43,44,46,47,49)] int input)
        {
            string output = FizzBuzzProblem.Library.FizzBuzz.GetValue(input);
            Assert.AreEqual(input.ToString(), output);
        }
        public void Function_Returns_Fizz([Values(3,6,9,12,18,21,24,27,33,36,39,42,48,51,54,57,63)] int input)
        {
            string output = FizzBuzzProblem.Library.FizzBuzz.GetValue(input);
            Assert.AreEqual("Fizz", output);
        }
        public void Function_Returns_Buzz([Values(5, 10,20 ,25, 35, 40,50)] int input)
        {
            string output = FizzBuzzProblem.Library.FizzBuzz.GetValue(input);
            Assert.AreEqual("FizzBuzz", output);
        }
        public void Function_Returns_FizzBuzz([Values(15,30,45,60,75,90)] int input)
        {
            string output = FizzBuzzProblem.Library.FizzBuzz.GetValue(input);
            Assert.AreEqual("FizzBuzz", output);
        }
    } }
