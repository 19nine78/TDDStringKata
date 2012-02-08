using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringCalculator
{
    /// <summary>
    /// Basic calculator class used to perform the String Calculator
    /// code Kata http://osherove.com/tdd-kata-1/
    /// </summary>
    public class MyCalculator
    {
        /// <summary>
        /// Add method
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public int Add(string numbers)
        {
            if (numbers == "")
            {
                return 0;
            }

            if (!numbers.Contains(","))
            {
                return int.Parse(numbers);
            }

            var nums = numbers.Split(',');

            int total = 0;

            foreach (var num in nums)
            {
                total = total + int.Parse(num);
            }

            return total;
        }
    }
}
