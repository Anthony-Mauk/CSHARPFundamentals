using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenges
{
    [TestClass]
    public class Challenge1
    {
        [TestMethod]
        public void PrintSeriesOfLetters()
        {
            string challengeStr = "Supercalifragilisticexpialidocious";
            char[] charArr = challengeStr.ToCharArray();
            foreach (char ch in charArr)
            {
                Console.WriteLine(ch);
            }
        }
        public void PrintIOnly()
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
    }
}
