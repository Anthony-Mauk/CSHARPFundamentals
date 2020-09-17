using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ReferenceTypeExamples
    {
        [TestMethod]
        public void Strings()
        {
            string thisIsDeclaration; //declare a string variable

            string declared; // declare
            declared = "This is iniiitialized"; // initialize

            string declareAndInitialization = "This is both declaring and initializzzing";

            //Concatenatation 

            string firstName = "Bobert";
            string lastName = "Billiam";
            
            int age = 112;
            string concatenatedFullName = firstName + " " + lastName;

            //composite 
            string compositeFullName = string.Format("{0} {1}. Attorney", firstName, lastName, age);

            //interpolation
            string interpolationFullName = $"{lastName}, {firstName} {lastName}. I am {age}.";

            Console.WriteLine(concatenatedFullName);
            Console.WriteLine(compositeFullName);
            Console.WriteLine(interpolationFullName);
        }

        [TestMethod]
        public void Collections()
        {
            //Arrays are a collection of something - specific amount of spots
            string stringExample = "Hello World";

            string[] stringArray = { "Hello", "World", "Why", "is it", "always", stringExample, "?" };
            // will only hold the number of slots declared

            string thirdItem = stringArray[2];
            Console.WriteLine(thirdItem);
            Console.WriteLine(stringArray[2]);
            Console.WriteLine(stringArray[0]);
            stringArray[0] = "Hey There";
            Console.WriteLine(stringArray[0]);

            //Lists - can add or remove elements - add or remove inserts in blank basket...
            List<string> listOfStrings = new List<string>();
            List<int> listOfIntegers = new List<int>();
            listOfStrings.Add("42");
            listOfIntegers.Add(42); //adds elements into list
            Console.WriteLine(listOfIntegers[0]);

            //Queques
            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue("Im first!");
            firstInFirstOut.Enqueue("Im next");
            string firstItem = firstInFirstOut.Dequeue(); // takes out of queue and puts in string
            Console.WriteLine(firstItem);

            //Dictionaries - have to have key and value
            Dictionary<int, string> keyAndValue = new Dictionary<int, string>();
            keyAndValue.Add(7, "Agent"); //saves as 7
            string valueSeven = keyAndValue[7]; //puts Agent into dictionary for 7
            Console.WriteLine(valueSeven);

            //other examples
            SortedList<int, string> sortedKeyAndValue = new SortedList<int, string>();
            HashSet<int> uniqueList = new HashSet<int>();
            Stack<string> lastInFirstOut = new Stack<string>();
         }
        [TestMethod]
        public void Classes()
        {
            Random rng = new Random(); //existing class built in - psuedo random generator
            int randomNumber = rng.Next();//can set min and max (1,100) between 1 and 99
            Console.WriteLine(randomNumber);


        }

    }
}
