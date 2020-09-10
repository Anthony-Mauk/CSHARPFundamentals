using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ValueTypeExamples
    {
        [TestMethod]
        public void Booleans
            ()
        {
            bool isDeclared; //declare variable
            isDeclared = true; //initialize variable

            bool isDeclarationAndInitialized = false; //declare & initialize
            isDeclarationAndInitialized = true; //reassign variable
        }

        [TestMethod]
        public void Characters()
        {
            char character = 'a';  //declare character initialize a
            char symbol = '?'; //initialize ?
            char number = '7'; //initialize 7
            char space = ' '; //initialize space
            char specialCharacter = '\n'; //intitialize as new line
        }
        [TestMethod]
        public void WholeNumbers()
         
        {
            byte byteExample = 255;
            sbyte sbyteExample = -128;
            short shortExample = 32767;
            Int16 anotherShortExample = 32000;
            int intMin = -2147483648;
            Int32 intMax = 2147483647;
            long longExample = 9223372036854775807;
            Int64 longMin = -9223372036854775807;

            int a = 42; //declare and initialize
            int b = 20;

            byte age = 87;
        }

        [TestMethod]
        public void Decimals()
        {
            float floatExample = 1.045231f;  //f at end marks as float
            double doubleExample = 1.789053278907036d; //if you don't assign float or type - it will make a double
            decimal decimalExample = 1.2578907289045789789789789789789m; //m for decimal

            Console.WriteLine(1.2578907289045789789789789789789f);
            Console.WriteLine(1.2578907289045789789789789789789d);
            Console.WriteLine(1.2578907289045789789789789789789m);
        }

        enum PastryType {Cake, Cupcake, Croissant, Poptart, Pie, Donut};
        // enums must contain one of the types in the initialization
        // do we have to initialize when we create? yes
        //why outside - create outside, use inside a test method
        [TestMethod]
        public void Enums()
        {
            PastryType myPastry = PastryType.Croissant;
            PastryType anotherOne = PastryType.Poptart;
        }
        [TestMethod]
        public void Structs()
        {
            Int32 age = 112; //Int32 is a struct or value type
            DateTime today = DateTime.Today;
            Console.WriteLine(today);
            DateTime birthday = new DateTime(1805,12,03); //new creates a new instance

        }
    }

}
