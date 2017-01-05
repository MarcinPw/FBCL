using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBCL
{
    public class FizzBuzz
    {
        /// <summary>
        /// Check if value is divisible by three
        /// </summary>
        /// <param name="num"></param>
        /// <returns>boolean</returns>
        public bool DivideByThree(int num)
        {
            return num % 3 == 0;
        }
        /// <summary>
        /// Check if value is divisible by five
        /// </summary>
        /// <param name="num"></param>
        /// <returns>boolean</returns>
        public bool DivideByFive(int num)
        {
            return num % 5 == 0;
        }
        /// <summary>
        /// Check if value is divisible by three and five
        /// </summary>
        /// <param name="num"></param>
        /// <returns>boolean</returns>
        public bool DivideByThreeAndFive(int num)
        {
            return (num % 3 == 0 && num % 5 == 0);
        }
        /// <summary>
        /// Main game method
        /// </summary>
        /// <param name="num"></param>
        /// <returns>0 if number is not divisible by 3 or 5</returns>
        public string Evaluate(int num)
        {
            if (DivideByThreeAndFive(num))
            {
                return "FizzBuzz";
            }
            else if (DivideByFive(num))
            {
                return "Buzz";
            }
            else if (DivideByThree(num))
            {
                return "Fizz";
            }
            else
                return num.ToString();
        }
    }
}
