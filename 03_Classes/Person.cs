using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Classes
{
    public class Person //add class and make public
    {
        public string FirstName { get; set; } //prop tab tab
        
        private string _lastName;

        public string LastName
        {
            get { return _lastName; } //when call on value returns value in backing field
            set { _lastName = value; } //set and being saved into backing field
        } //built out same as one...
        public DateTime DateOfBirth { get; set; }

        public Vehicle Transport { get; set; }// passes vehicle object to be a parameter of person
        
        public string FullName
        {
            get 
            { // in body of getter - get method, set value
                return $"{FirstName} {LastName}";
                //not adding set value, cannot add valuue outside of class
            }
        }
        public int Age
        {
            get
            {
                TimeSpan ageSpan = DateTime.Now - DateOfBirth;
                double totalAgeInYears = ageSpan.TotalDays / 365.25;
                int yearsOfAge = Convert.ToInt32(Math.Floor(totalAgeInYears));
                return yearsOfAge;
            }
        }

        //constructors = pass in properties
        public Person() { }
        //when create next empty goes away
        public Person(string firstName, string lastName, DateTime dob, Vehicle transport) 
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dob;
            Transport = transport;
        }//created overloaded constructor
    }
}
