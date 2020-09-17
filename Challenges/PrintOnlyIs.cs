using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenges
{
    [TestClass]
    public class PrintOnlyIs
    {
        [TestMethod]
        public void PrintOnlyI()
        {
            string challengeStr = "Supercalifragilisticexpialidocious";
            char[] charArr = challengeStr.ToCharArray();
            foreach (char letter in charArr)
            {
                if (letter != 'i')
                {
                    Console.WriteLine("not an i");
                }
                else
                {
                    Console.WriteLine(letter);
                }
            }
           
        }
        [TestMethod]
        public void FindLs()
        {
            string challengeStr = "Supercalifragilisticexpialidocious";
            char[] charArr = challengeStr.ToCharArray();
            foreach (char letter in charArr)
            {
                if (letter != 'l')
                {
                    Console.WriteLine("not an l");
                }
                else
                {
                    Console.WriteLine(letter);
                }
            }

        }
        [TestMethod]
        public void CountArray()
        {
            string challengeStr = "Supercalifragilisticexpialidocious";
            char[] charArr = challengeStr.ToCharArray();
            {
                Console.WriteLine(charArr.Length);
            }
        }
    }
}
