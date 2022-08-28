using System.Diagnostics;

namespace FizzBuzzProblem.Library
{


    public class FizzBuzz
    {
        public static string GetValue(int value)
        {
            string output = string.Empty;
            if (value % 3 == 0 && value % 5 == 0)
                output += "FizzBuzz";
            else if (value % 3 == 0)
                output += "Fizz";
            else  if (value % 5 == 0)
                output += "Buzz";
            if (string.IsNullOrEmpty(output))
                output = value.ToString();
            return output;
        }
    }
}
