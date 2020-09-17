using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Loops
{
    [TestClass]
    public class LoopExamples
    {
        [TestMethod]
        public void WhileLoops()
        {
            //Stucture, check conditional, continue while true
            int total = 1;
            while (total != 10)
            {
                Console.WriteLine(total);
                total = total + 1;
            }

            total = 0;
            while (true)
            {
                if (total == 10)
                {
                    Console.WriteLine("Goal reached");
                    break;
                }
                total++;
            }

            int someCount;
            bool keepLooping = true;
            Random rand = new Random();
            while (keepLooping)
            {
                someCount = rand.Next(0, 20);
                if (someCount == 6 || someCount == 10)
                {
                    continue;  //starts the loop over
                }

                Console.WriteLine(someCount);
                if (someCount == 15)
                {
                    keepLooping = false;
                }
            }

        }

        [TestMethod]
        public void ForLoops()
        {
            int studentCount = 47;
            for (int i = 0; i < studentCount; i++)
            //(starting, conditional, increment)
            {
                Console.WriteLine(i);
            }

            string[] students = { "Jonathan", "Tomislav", "Gordon", "Adam", "Andrew", "Amanda" };
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Hello there {students[i]}!");
            }
        }

        [TestMethod]
        public void ForeachLoops() //used for collections
        {
            string[] students = { "Jonathan", "Tomislav", "Gordon", "Adam", "Andrew", "Amanda" };
            //int[] numbers = { 4, 5, 6, 1, 2, 3, -2, -1, 0 };
            //foreach (int i in numbers)
            //{
            //    System.Console.Write("{0} ", i);
            //}
            // Output: 4 5 6 1 2 3 -2 -1 0
            foreach(string student in students) //(holdingType singleIteration-anyName in whatsIN)
            {
                Console.WriteLine($"Hello my name is {student}");
            }
            string myName = "Amanda Joy Knight";
            foreach(char letter in myName)
            {
                if(letter != ' ')
                {
                    Console.WriteLine(letter);
                }
            }
        }
        [TestMethod]
        public void DoWhileLoops()
        {
            int iterator = 0;
            do
            {
                Console.WriteLine("Hello!");
                iterator++;
            }
            while (iterator < 5);

            do
            {
                Console.WriteLine("my do while condition is fales");
            }
            while (false);

            while (false)
            {
                Console.WriteLine("My condition is false");
            }

        }
    }
}
