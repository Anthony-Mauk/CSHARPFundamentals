using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Operators
{
    [TestClass]
    public class Arithmetic
    {
        [TestMethod]
        public void SimpleOperators()
        {
            //when need to run math you have 5 main operators
            int a = 13;
            int b = 74;

            //adding
            int sum = a + b;
            Console.WriteLine(sum);

            //subtracting
            int difference = a - b;
            Console.WriteLine(difference);

            //product - multiply
            int product = a * b;
            Console.WriteLine(product);

            int quotient = a / b;
            Console.WriteLine(quotient);

            int remainder = a % b;
            Console.WriteLine(remainder);

            DateTime now = DateTime.Now;
            DateTime someDay = new DateTime(1984, 11, 26);
            TimeSpan timeSpan = now - someDay;
            Console.WriteLine(timeSpan);
            Console.WriteLine(timeSpan.Days);
        }
    }
}
