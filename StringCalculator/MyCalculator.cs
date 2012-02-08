using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringCalculator
{
    public class MyCalculator
    {
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
