using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Conditionals
{
    [TestClass]
    public class IfElse
    {
        [TestMethod]
        public void IfStatements()
        {
            bool userIsHungry = true;
            if (userIsHungry) 
            {
                Console.WriteLine("You should eat");
                Console.WriteLine("That's rough");
            }

            int hourSpentStudying = 4;
            if(hourSpentStudying < 10)
            {
                Console.WriteLine("Are you trying?");
            }
        }
        [TestMethod]
        public void IfElseStatement()
        {
            bool choresAreDone = false;
            if(choresAreDone)
            {
                Console.WriteLine("Go have fun playing");
            }
            else
            {
                Console.WriteLine("You need to finish chores");
            }
            //nested if else
            string input = "7"; //read line always returns a string
            int totalHours = int.Parse(input);// parsing = .parse
            
            if(totalHours >= 8)
            {
                Console.WriteLine("you should be rested");
            }
            else
            {
                Console.WriteLine("you might be tired");
                if (totalHours < 3)
                {
                    Console.WriteLine(", you should get more sleep");
                }
            }

            int age = 5;//why if else if we have switch?
            if(age > 17)
            {
                Console.WriteLine("you are an adult");
            }
            else
            {
                if(age > 12)
                {
                    Console.WriteLine("you are a teenager");
                }
                else if (age > 2)
                {
                    Console.WriteLine("You are a little kid!");
                }
                else
                {
                    Console.WriteLine("How are you on the computer?");
                }
            }
            if(age < 65 && age > 18)
            {
                Console.WriteLine("Your between 19 and 64");
            }
            if(age < 17 || age > 18)
            {
                Console.WriteLine("You're Not 17 or 18");
            }
        }
    }
}
