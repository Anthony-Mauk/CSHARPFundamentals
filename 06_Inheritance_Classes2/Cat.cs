using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Inheritance_Classes2
{
    public class Cat : Animal //only able to inherit from 1 class
    {
        public double ClawLength { get; set; }

        public Cat()//constructor
        {
            Console.WriteLine("This is the Cat constructor");
            IsMammal = true;
            TypeOfDiet = DietType.Carnivore;
        }
        //class methods
        public override void Move()
        {
            Console.WriteLine($"The {GetType().Name} moves quickly");
        }
        //create virtual cat method
        public virtual void MakeSound()
        {
            Console.WriteLine("Meow.");
        }
    }
    public class Liger : Cat
    {
        public Liger()
        {
            Console.WriteLine("This is the Liger constructor");
        }
        public override void Move()
        {
            Console.WriteLine($"The {GetType().Name} stalks its prey");
            base.Move();
        }
        public override void MakeSound()
        {
            Console.WriteLine("Roar!");
        }
    }
}
