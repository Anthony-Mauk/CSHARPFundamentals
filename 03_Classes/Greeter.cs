using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Classes
{
    public class Greeter
    {
        //creating methods
        //1 Access Modifier
        //2 Return Type
        // Method Signature (Name, Parameters)
        public void SayHello(string name)
        {
            Console.WriteLine($"Hello there, {name}");
        }

        public void SayHello()
        {
            Console.WriteLine("Hello Stranger");
        }

        //create a field
        Random _rando = new Random();
        //1 access modifier, return type, method signature or name then parameters (filled or empty)
        public void GetRandomGreeting()
        {
            string[] availableGreetings = new string[] { "Hello", "Howdy", "Sup", "Hola", "Sup Dude", "Hi Y'all", "Guten Tag", "Hello There" };
            int randomNumber = _rando.Next(0, availableGreetings.Length);
            string randoGreeting = availableGreetings.ElementAt(randomNumber);
            Console.WriteLine(randoGreeting);
        }

    }
}
