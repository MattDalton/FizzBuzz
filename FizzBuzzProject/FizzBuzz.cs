using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzProject
{
    public class FizzBuzz:IFizzBuzz
    {
        public string GetOutput(int number)
        {
            if (number % 3 == 0) return "Fizz";
            return "";
        }
    }
}
