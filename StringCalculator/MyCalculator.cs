using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace StringCalculator
{
    /// <summary>
    /// Basic calculator class used to perform the String Calculator
    /// code Kata http://osherove.com/tdd-kata-1/
    /// </summary>
    public class MyCalculator
    {

        private List<String> delimiters = new List<string> { ",", "\n" };
        private bool CustomDelimiter = false;

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

            //identify the delimiter if it exists
            if (numbers.Length > 2 && numbers.Substring(0, 2) == "//")
            {
                var delimiter = numbers.Substring(2, 1);
                delimiters.Add(delimiter);
                CustomDelimiter = true;
                //numbers to be summed will follow after a newline
                numbers = numbers.Split('\n')[1];

            }

            if (!numbers.Contains(",") && !CustomDelimiter)
            {
                return int.Parse(numbers);
            }





            var nums = numbers.Split(delimiters.ToArray(), StringSplitOptions.RemoveEmptyEntries);

            int total = 0;

            foreach (var num in nums)
            {
                total = total + int.Parse(num);
            }

            return total;
        }
    }
}
