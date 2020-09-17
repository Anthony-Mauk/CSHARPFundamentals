using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Conditionals
{
    [TestClass]
    public class Switch
    {
        enum WeekDay { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday}
        [TestMethod]
        public void SwitchCases()
        {
            int input = 1;
            switch (input)
            {
                case 1:
                    Console.WriteLine("hello");
                    break;
                case 2:
                    Console.WriteLine("This is option 2");
                    break;
                default:
                    Console.WriteLine("This is default");
                    break;
            }

            WeekDay today = WeekDay.Monday;
            switch (today)
            {
                case WeekDay.Monday: // then stack rest of answers for weekday
                case WeekDay.Tuesday:
                case WeekDay.Wednesday:
                case WeekDay.Thursday:
                case WeekDay.Friday:
                    Console.WriteLine("Hope you are ready to work");
                    break;
                case WeekDay.Saturday:
                case WeekDay.Sunday:
                    Console.WriteLine("This is a weekend day");
                    break;
            }
        }
        public void SwitchExperssions()
        {
            string output;
            int action = 1;
            switch (action)
            {
                case 0:
                    output = "Case 0";
                    break;
                case 1:
                    output = "Case 1";
                    break;
                case 2:
                    output = "Case 2";
                    break;
                default:
                    output = "Default Case";
                    break;
            }
            Console.WriteLine(output);
            //Switch Expression
            output = action switch
            {
                0 => "Case 0",
                1 => "Case 0",
                2 => "Case 0",
                _ => "Default Case",
            };
            Console.WriteLine(output);
        }
    }
}
