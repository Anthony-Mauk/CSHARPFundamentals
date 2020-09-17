using System;
using _06_Inheritance_Classes2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _06_Inheritace_Tests
{
    [TestClass]
    public class CatTests
    {
        [TestMethod]
        public void CatTesting()
        {
            Animal firstAnimal = new Animal();
            Console.WriteLine("Break after animal");
            Cat firstCat = new Cat();
            firstAnimal.Move();
            firstCat.Move();
            firstCat.MakeSound();

            Liger oneLiger = new Liger();
            oneLiger.Move();
            oneLiger.MakeSound();
        }
    }
}
