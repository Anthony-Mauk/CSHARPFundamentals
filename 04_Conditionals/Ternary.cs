using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Conditionals
{
    [TestClass]
    public class Ternary
    {
        [TestMethod]
        public void Ternaries()
        {
            int age = 31;
            //ternary structure  assigns value
            //(condition/Boolean) ? trueResult: falseResult;
            bool isAdult = (age > 17) ? true : false;

            int numOne = 10; //think of as User Input
            string output = (numOne == 10) ? "you guessed it" : "you didn't gess it";
            Console.WriteLine((output == "you guessed it")?"Congrats": "Try again");
        }
    }
}
