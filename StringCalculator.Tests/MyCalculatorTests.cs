using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace StringCalculator.Tests
{
    [TestFixture]
    public class MyCalculatorTests
    {
        [Test]
        public void Add_EmptyString_ReturnsZero()
        {
            MyCalculator c = GetNewCalc();

            int result = c.Add("");

            Assert.AreEqual(0,result);
        }

        [Test]
        public void Add_OneNumber_ReturnsThatNumber()
        {
            MyCalculator c = GetNewCalc();

            int result = c.Add("1");

            Assert.AreEqual(1,result);
        }

        [Test]
        public void Add_TwoNumbers_ReturnsTheSum()
        {
            MyCalculator c = GetNewCalc();

            int result = c.Add("1,2");

            Assert.AreEqual(3,result);
        }

        [TestCase("1,2,3",6)]
        [TestCase("1,2,3,4", 10)]
        public void Add_MultipleNumbers_ReturnsTheirSum(string numbers, int expected)
        {
            MyCalculator c = GetNewCalc();

            int result = c.Add(numbers);

            Assert.AreEqual(expected,result);
        }


        private static MyCalculator GetNewCalc()
        {
            return new MyCalculator();
        }
    }
}
