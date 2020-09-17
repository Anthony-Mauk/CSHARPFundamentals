using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Inheritance_Classes2
{
    public enum DietType { Herbivore = 1, Omivore, Carnivore}
    public class Animal
    {
        public int NumOfLegs { get; set; }
        public bool IsMammal { get; set; }
        public bool HasFur { get; set; }
        public DietType TypeOfDiet { get; set; }
     
        public Animal()
        {
            Console.WriteLine("This is the Animal Constructor");
        }
        public virtual void Move()
        {
            Console.WriteLine($"This {GetType().Name} moves.");
        }
    }

}
