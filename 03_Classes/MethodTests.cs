using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Classes
{
    [TestClass]
    public class MethodTests
    {
        [TestMethod]
        public void GreeterMethodExecution()
        {
            //open a window into Greeter class in order to have access
            Greeter greeter = new Greeter();
            greeter.SayHello();
            // calling method and passing a string (what we made)
            greeter.SayHello("Squidward");
            greeter.SayHello("Geeter");
            greeter.SayHello("Mr. Krabs");
            greeter.SayHello("867-5309");
            //run random greeting in array in Greeter.cs
            greeter.GetRandomGreeting();
        }
    }
}
