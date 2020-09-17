using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Inheritance_Classes2
{
    public class Person //create a new class
    {
        //create only through method
        private string _firstName;
        private string _lastName; //backing fields - _creates backing
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Name //only way to set is to use 2 methods below
        {
            get
            {
                string fullName = $"{_firstName} {_lastName}";
                return (!string.IsNullOrWhiteSpace(fullName)) ? fullName : "Unnamed";
            }
        }

        public void SetFirstame(string name)
        {
            _firstName = name;
        }
        public void SetLastName(string name)
        {
            _lastName = name;
        }
    }
}
