using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Classes
{
    //first make public
    public class Calculator
    {
        public int Add(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }
        //create overload
        public double Add(double numOne, double numTwo)
        {
            double sum = numOne + numTwo;
            return sum;
        }
        // -
        public double Subtract (double numOne, double numTwo)
        {
            double difference = numOne - numTwo;
            return difference;
        }
        // *
        public double Multiply (double numOne, double numTwo)
        {
            double product = numOne * numTwo;
            return product;
        }
        // /
        public double Divide(double numOne, double numTwo)
        {
            double factor = numOne / numTwo;
            return factor;
        }
        // %
        public double CalculateRemainder(double numOne, double numTwo)
        {
            double remainder = numOne % numTwo;
            return remainder;
        }
        // now create a complicated method to calculate age
        public int CalculateAge(DateTime birthday) 
        {
            TimeSpan ageSpan = DateTime.Now - birthday;
            double totalAgeInYears = ageSpan.TotalDays / 365.25;
            int years = Convert.ToInt32(Math.Floor(totalAgeInYears));
            return years;
        }
    }
}
