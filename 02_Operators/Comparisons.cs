using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Operators
{
    [TestClass]
    public class Comparisons
    {
        [TestMethod]
        public void ComparisonOperators()//comparison operators compare in boolean
        {
            //create variables
            int age = 142;
            string userName = "Sandy";
            bool equals = age == 12;
            bool userIsAdam = userName == "SpongeBob";

            bool notEqual = age != 1001;
            bool userIsNotPatrick = userName != "Patrick";
            bool testBool = false;

            List<string> firstList = new List<string>();
            firstList.Add(userName);
            List<string> secondLilst = new List<string>();
            secondLilst.Add(userName);
            bool listsAreEqual = firstList == secondLilst;
            bool itemsOnList = firstList[0] == secondLilst[0];
            Console.WriteLine(listsAreEqual);
            Console.WriteLine(itemsOnList);

            bool greaterThan = age > 10;
            bool greaterThanOrEqual = age >= 142;
            bool lessThan = age > 9001;
            bool lessThanOrEqual = age <= 142;

            // || are the or comparison
            bool orValue = greaterThan || lessThan;
            bool anotherOr = age < 9005 || userName == "banana";
            // && is the and comparison
            bool andValue = greaterThan && lessThan;
            bool anotherAnd = userName == "Sandy" && age >= 42;
        }
    }
}
